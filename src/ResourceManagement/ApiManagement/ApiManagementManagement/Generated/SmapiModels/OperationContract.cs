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
    public partial class OperationContract
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets Operation description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _method;
        
        /// <summary>
        /// Required. Gets or sets Operation Method (GET, PUT, POST, etc.).
        /// </summary>
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets Operation Name. Must be 1 to 300 characters
        /// long.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _operationIdPath;
        
        /// <summary>
        /// Optional. Gets or sets OperationId path.
        /// </summary>
        public string OperationIdPath
        {
            get { return this._operationIdPath; }
            set { this._operationIdPath = value; }
        }
        
        private RequestContract _request;
        
        /// <summary>
        /// Optional. Gets or sets Operation request.
        /// </summary>
        public RequestContract Request
        {
            get { return this._request; }
            set { this._request = value; }
        }
        
        private IList<ResponseContract> _responses;
        
        /// <summary>
        /// Optional. Gets or sets Array of Operation responses.
        /// </summary>
        public IList<ResponseContract> Responses
        {
            get { return this._responses; }
            set { this._responses = value; }
        }
        
        private IList<ParameterContract> _templateParameters;
        
        /// <summary>
        /// Optional. Gets or sets Collection of URL template parameters.
        /// </summary>
        public IList<ParameterContract> TemplateParameters
        {
            get { return this._templateParameters; }
            set { this._templateParameters = value; }
        }
        
        private string _urlTemplate;
        
        /// <summary>
        /// Required. Gets or sets Operation URI template. Cannot be more than
        /// 400 characters long.
        /// </summary>
        public string UrlTemplate
        {
            get { return this._urlTemplate; }
            set { this._urlTemplate = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OperationContract class.
        /// </summary>
        public OperationContract()
        {
            this.Responses = new LazyList<ResponseContract>();
            this.TemplateParameters = new LazyList<ParameterContract>();
        }
        
        /// <summary>
        /// Initializes a new instance of the OperationContract class with
        /// required arguments.
        /// </summary>
        public OperationContract(string name, string method, string urlTemplate)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (method == null)
            {
                throw new ArgumentNullException("method");
            }
            if (urlTemplate == null)
            {
                throw new ArgumentNullException("urlTemplate");
            }
            this.Name = name;
            this.Method = method;
            this.UrlTemplate = urlTemplate;
        }
    }
}
