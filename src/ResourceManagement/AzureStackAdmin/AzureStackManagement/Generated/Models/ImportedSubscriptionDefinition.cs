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

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Your documentation here.
    /// </summary>
    public partial class ImportedSubscriptionDefinition
    {
        private string _cloudName;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string CloudName
        {
            get { return this._cloudName; }
            set { this._cloudName = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private bool? _linkToLocalSubscription;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public bool? LinkToLocalSubscription
        {
            get { return this._linkToLocalSubscription; }
            set { this._linkToLocalSubscription = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ImportedSubscriptionDefinition
        /// class.
        /// </summary>
        public ImportedSubscriptionDefinition()
        {
        }
    }
}
