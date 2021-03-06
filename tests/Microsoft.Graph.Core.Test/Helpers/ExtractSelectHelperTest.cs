// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.Core.Test.Helpers
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ExtractSelectHelperTest
    {
        /// <summary>
        /// Simple base class to use as a template parameter for testing
        /// </summary>
        private class EventBase
        {
            public DateTimeOffset CreatedDateTime { get; set; }
        }

        /// <summary>
        /// Simple class to use as a template parameter for testing
        /// </summary>
        private class Event : EventBase
        {
            public string Body { get; set; }

            public string Subject { get; set; }

        }

        /// <summary>
        /// Simple recursive class to use as a template parameter for testing
        /// </summary>
        private class User
        {
            public string DisplayName { get; set; }

            public User Manager { get; set; }

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullOnNullArgument()
        {
            string s = this.TestExtractMembers<Event>(null);
        }

        [TestMethod]
        public void SingleMemberAnonymousTypeImplicitMember()
        {
            Expression<Func<Event, object>> expression = (theEvent) => new { theEvent.Body };
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("body", s);
        }

        [TestMethod]
        public void SingleMemberAnonymousTypeExplicitMember()
        {
            Expression<Func<Event, object>> expression = (theEvent) => new { NotBody = theEvent.Body };
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("body", s);
        }

        [TestMethod]
        public void MultiMemberAnonymousTypeImplicitMember()
        {
            Expression<Func<Event, object>> expression = (theEvent) => new { theEvent.Body, theEvent.Subject};
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("body,subject", s);
        }

        [TestMethod]
        public void MultiMemberAnonymousTypeExplicitMember()
        {
            Expression<Func<Event, object>> expression = (theEvent) => new { Body = theEvent.Body, NotSubject = theEvent.Subject };
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("body,subject", s);
        }

        [TestMethod]
        public void MultiMemberAnonymousTypeImplicitExplicitMemberMix()
        {
            Expression<Func<Event, object>> expression = (theEvent) => new { theEvent.Body, NotSubject = theEvent.Subject };
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("body,subject", s);
        }

        [TestMethod]
        public void NonMemberArgumentType()
        {
            string greeting = "Hello";
            Expression<Func<Event, object>> expression = (theEvent) => new { theEvent.Body, greeting };
            this.TestErrorExtractMembers(expression);
        }

        [TestMethod]
        public void LiftedButMatchingType()
        {
            Event liftee = new Event();
            Expression<Func<Event, object>> expression = (theEvent) => new { theEvent.Body, liftee.Subject };
            this.TestErrorExtractMembers(expression);
        }

        [TestMethod]
        public void SimpleMemberAccess()
        {
            Expression<Func<Event, object>> expression = (theEvent) => theEvent.Body;
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("body", s);
        }

        [TestMethod]
        public void TraversalNotIncluded()
        {
            Expression<Func<User, object>> expression = (theUser) => new { ((User)theUser.Manager).DisplayName };
            this.TestErrorExtractMembers(expression);
        }

        [TestMethod]
        public void SimpleMemberFromBaseType()
        {
            Expression<Func<Event, object>> expression = (theEvent) => theEvent.CreatedDateTime;
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("createdDateTime", s);
        }

        [TestMethod]
        public void SingleMemberAnonymousTypeImplicitMemberFromBaseType()
        {
            Expression<Func<Event, object>> expression = (theEvent) => new { theEvent.CreatedDateTime };
            string s = this.TestExtractMembers(expression);
            Assert.AreEqual<string>("createdDateTime", s);
        }

        /// <summary>
        /// Helper for positive test cases
        /// </summary>
        private string TestExtractMembers<T>(Expression<Func<T, object>> expression)
        {
            string error;
            string s = ExpressionExtractHelper.ExtractMembers(expression, out error);

            // Repetitive asserts go here.
            Assert.IsNotNull(s, $"Unexpected null from ExtractSelectHelper with error '{error}'");
            Assert.IsNull(error, "Unexpected error message from ExtractSelectHelper");
            return s;
        }

        /// <summary>
        /// Helper for negative test cases
        /// </summary>
        private void TestErrorExtractMembers<T>(Expression<Func<T, object>> expression)
        {
            string error;
            string s = ExpressionExtractHelper.ExtractMembers(expression, out error);

            // Repetitive asserts go here.
            Assert.IsNull(s, $"Unexpected non-null from ExtractSelectHelper with result '{s}'");
            Assert.IsNotNull(error, "Unexpected empty error message from ExtractSelectHelper");
            Assert.IsTrue(error.Length > 10, "Unexpectedly short error message from ExtractSelectHelper");
        }

    }
}

