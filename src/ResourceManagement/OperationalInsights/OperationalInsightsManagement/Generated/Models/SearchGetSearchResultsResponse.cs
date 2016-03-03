// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// The get search result operation response.
    /// </summary>
    public partial class SearchGetSearchResultsResponse : AzureOperationResponse
    {
        private SearchError _error;
        
        /// <summary>
        /// Optional. Gets or sets the error.
        /// </summary>
        public SearchError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Gets or sets the id of the search, which includes the
        /// full url.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private SearchMetadata _metadata;
        
        /// <summary>
        /// Optional. Gets or sets the metadata from search results.
        /// </summary>
        public SearchMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }
        
        private IList<object> _value;
        
        /// <summary>
        /// Optional. Gets or sets the array of result values.
        /// </summary>
        public IList<object> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchGetSearchResultsResponse
        /// class.
        /// </summary>
        public SearchGetSearchResultsResponse()
        {
            this.Value = new LazyList<object>();
        }
    }
}
