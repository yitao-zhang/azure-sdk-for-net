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

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Represents an item- or document-level indexing error.
    /// </summary>
    public partial class ItemError
    {
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Gets the message describing the error that occurred while
        /// attempting to index the item.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private string _key;
        
        /// <summary>
        /// Optional. Gets the key of the item for which indexing failed.
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ItemError class.
        /// </summary>
        public ItemError()
        {
        }
    }
}
