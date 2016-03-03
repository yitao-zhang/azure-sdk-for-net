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
using System.Linq;

namespace Microsoft.Azure.Graph.RBAC.Models
{
    /// <summary>
    /// List role assignments filter.
    /// </summary>
    public partial class ApplicationFilterParameters
    {
        private System.Guid? _appId;
        
        /// <summary>
        /// Optional. Returns an application with a specific appId.
        /// </summary>
        public System.Guid? AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }
        
        private string _displayNameStartsWith;
        
        /// <summary>
        /// Optional. Returns all applications starting with this displayName.
        /// </summary>
        public string DisplayNameStartsWith
        {
            get { return this._displayNameStartsWith; }
            set { this._displayNameStartsWith = value; }
        }
        
        private string _identifierUri;
        
        /// <summary>
        /// Optional. Returns an application which contains the mentioned
        /// identifierUri.
        /// </summary>
        public string IdentifierUri
        {
            get { return this._identifierUri; }
            set { this._identifierUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApplicationFilterParameters class.
        /// </summary>
        public ApplicationFilterParameters()
        {
        }
    }
}
