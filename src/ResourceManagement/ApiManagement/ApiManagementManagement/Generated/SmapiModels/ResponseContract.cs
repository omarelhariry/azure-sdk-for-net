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
    public partial class ResponseContract
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets Operation response description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IList<RepresentationContract> _representations;
        
        /// <summary>
        /// Optional. Gets or sets Collection of operation response
        /// representations.
        /// </summary>
        public IList<RepresentationContract> Representations
        {
            get { return this._representations; }
            set { this._representations = value; }
        }
        
        private int _statusCode;
        
        /// <summary>
        /// Required. Gets or sets Operation response status code.
        /// </summary>
        public int StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResponseContract class.
        /// </summary>
        public ResponseContract()
        {
            this.Representations = new LazyList<RepresentationContract>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ResponseContract class with
        /// required arguments.
        /// </summary>
        public ResponseContract(int statusCode)
            : this()
        {
            this.StatusCode = statusCode;
        }
    }
}
