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
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    public partial class ApiContract
    {
        private AuthenticationSettingsContract _authenticationSettings;
        
        /// <summary>
        /// Optional. Gets or sets Collection of authentication settings
        /// included into this API.
        /// </summary>
        public AuthenticationSettingsContract AuthenticationSettings
        {
            get { return this._authenticationSettings; }
            set { this._authenticationSettings = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets API description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _idPath;
        
        /// <summary>
        /// Optional. Gets or sets API identifier path: /apis/{aid}
        /// </summary>
        public string IdPath
        {
            get { return this._idPath; }
            set { this._idPath = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets API name. Must be 1 to 300 characters long.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _path;
        
        /// <summary>
        /// Required. Gets or sets Path for API requests. Must be 1 to 400
        /// characters long.
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        
        private IList<ApiProtocolContract> _protocols;
        
        /// <summary>
        /// Required. Gets or sets Protocols over which API is made available.
        /// </summary>
        public IList<ApiProtocolContract> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }
        
        private string _serviceUrl;
        
        /// <summary>
        /// Required. Gets or sets Base address for API requests. Must be 1 to
        /// 2000 characters long.
        /// </summary>
        public string ServiceUrl
        {
            get { return this._serviceUrl; }
            set { this._serviceUrl = value; }
        }
        
        private SubscriptionKeyParameterNamesContract _subscriptionKeyParameterNames;
        
        /// <summary>
        /// Optional. Gets or sets Protocols over which API is made available.
        /// </summary>
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames
        {
            get { return this._subscriptionKeyParameterNames; }
            set { this._subscriptionKeyParameterNames = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiContract class.
        /// </summary>
        public ApiContract()
        {
            this.Protocols = new LazyList<ApiProtocolContract>();
        }
    }
}
