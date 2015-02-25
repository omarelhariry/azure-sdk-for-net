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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RemoteApp;
using Microsoft.Azure.Management.RemoteApp.Models;

namespace Microsoft.Azure.Management.RemoteApp
{
    /// <summary>
    /// RmoteApp management client
    /// </summary>
    public static partial class PrincipalOperationsExtensions
    {
        /// <summary>
        /// Adds a list of principals to the given collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.IPrincipalOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// Required. A list of RemoteApp principals to add.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        public static SecurityPrincipalOperationsResult Add(this IPrincipalOperations operations, string collectionName, SecurityPrincipalList securityPrincipalList)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPrincipalOperations)s).AddAsync(collectionName, securityPrincipalList);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Adds a list of principals to the given collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.IPrincipalOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// Required. A list of RemoteApp principals to add.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        public static Task<SecurityPrincipalOperationsResult> AddAsync(this IPrincipalOperations operations, string collectionName, SecurityPrincipalList securityPrincipalList)
        {
            return operations.AddAsync(collectionName, securityPrincipalList, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a list of principals from the given collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.IPrincipalOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// Required. A list of RemoteApp principals to delete.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        public static SecurityPrincipalOperationsResult Delete(this IPrincipalOperations operations, string collectionName, SecurityPrincipalList securityPrincipalList)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPrincipalOperations)s).DeleteAsync(collectionName, securityPrincipalList);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a list of principals from the given collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.IPrincipalOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <param name='securityPrincipalList'>
        /// Required. A list of RemoteApp principals to delete.
        /// </param>
        /// <returns>
        /// The response for the collection user operation.
        /// </returns>
        public static Task<SecurityPrincipalOperationsResult> DeleteAsync(this IPrincipalOperations operations, string collectionName, SecurityPrincipalList securityPrincipalList)
        {
            return operations.DeleteAsync(collectionName, securityPrincipalList, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of all RemoteApp principals associated with the given
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.IPrincipalOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <returns>
        /// The list of principals with consent status.
        /// </returns>
        public static SecurityPrincipalInfoListResult List(this IPrincipalOperations operations, string collectionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPrincipalOperations)s).ListAsync(collectionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of all RemoteApp principals associated with the given
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.IPrincipalOperations.
        /// </param>
        /// <param name='collectionName'>
        /// Required. The RemoteApp collection name.
        /// </param>
        /// <returns>
        /// The list of principals with consent status.
        /// </returns>
        public static Task<SecurityPrincipalInfoListResult> ListAsync(this IPrincipalOperations operations, string collectionName)
        {
            return operations.ListAsync(collectionName, CancellationToken.None);
        }
    }
}
