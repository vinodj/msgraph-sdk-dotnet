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
    /// The type Onenote Section.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OnenoteSection : OnenoteEntityHierarchyModel
    {
    
        /// <summary>
        /// Gets or sets is default.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets links.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "links", Required = Newtonsoft.Json.Required.Default)]
        public SectionLinks Links { get; set; }
    
        /// <summary>
        /// Gets or sets pages url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pagesUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PagesUrl { get; set; }
    
        /// <summary>
        /// Gets or sets parent notebook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentNotebook", Required = Newtonsoft.Json.Required.Default)]
        public Notebook ParentNotebook { get; set; }
    
        /// <summary>
        /// Gets or sets parent section group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentSectionGroup", Required = Newtonsoft.Json.Required.Default)]
        public SectionGroup ParentSectionGroup { get; set; }
    
        /// <summary>
        /// Gets or sets pages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pages", Required = Newtonsoft.Json.Required.Default)]
        public IOnenoteSectionPagesCollectionPage Pages { get; set; }
    
    }
}

