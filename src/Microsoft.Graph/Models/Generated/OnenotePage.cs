// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Onenote Page.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OnenotePage : OnenoteEntitySchemaObjectModel
    {
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets created by app id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdByAppId", Required = Newtonsoft.Json.Required.Default)]
        public string CreatedByAppId { get; set; }
    
        /// <summary>
        /// Gets or sets links.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "links", Required = Newtonsoft.Json.Required.Default)]
        public PageLinks Links { get; set; }
    
        /// <summary>
        /// Gets or sets content url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ContentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "level", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Level { get; set; }
    
        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Order { get; set; }
    
        /// <summary>
        /// Gets or sets user tags.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userTags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> UserTags { get; set; }
    
        /// <summary>
        /// Gets or sets parent section.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentSection", Required = Newtonsoft.Json.Required.Default)]
        public OnenoteSection ParentSection { get; set; }
    
        /// <summary>
        /// Gets or sets parent notebook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentNotebook", Required = Newtonsoft.Json.Required.Default)]
        public Notebook ParentNotebook { get; set; }
    
    }
}

