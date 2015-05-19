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
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure ApiManagement Service
    /// </summary>
    public static partial class SubscriptionsOperationsExtensions
    {
        /// <summary>
        /// Creates new product subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Create(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).CreateAsync(resourceGroupName, serviceName, sid, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates new product subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> CreateAsync(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionCreateParameters parameters)
        {
            return operations.CreateAsync(resourceGroupName, serviceName, sid, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes specific subscription of the Api Management service
        /// instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid, string etag)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).DeleteAsync(resourceGroupName, serviceName, sid, etag);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes specific subscription of the Api Management service
        /// instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid, string etag)
        {
            return operations.DeleteAsync(resourceGroupName, serviceName, sid, etag, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static SubscriptionGetResponse Get(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).GetAsync(resourceGroupName, serviceName, sid);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets specific API of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<SubscriptionGetResponse> GetAsync(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid)
        {
            return operations.GetAsync(resourceGroupName, serviceName, sid, CancellationToken.None);
        }
        
        /// <summary>
        /// List all subscriptions of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='query'>
        /// Optional.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static SubscriptionListResponse List(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, QueryParameters query)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).ListAsync(resourceGroupName, serviceName, query);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List all subscriptions of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='query'>
        /// Optional.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<SubscriptionListResponse> ListAsync(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, QueryParameters query)
        {
            return operations.ListAsync(resourceGroupName, serviceName, query, CancellationToken.None);
        }
        
        /// <summary>
        /// List all subscriptions of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static SubscriptionListResponse ListNext(this ISubscriptionsOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List all subscriptions of the Api Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<SubscriptionListResponse> ListNextAsync(this ISubscriptionsOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Regenerates primary key of existing subscription of the Api
        /// Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse RegeneratePrimaryKey(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).RegeneratePrimaryKeyAsync(resourceGroupName, serviceName, sid);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Regenerates primary key of existing subscription of the Api
        /// Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RegeneratePrimaryKeyAsync(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid)
        {
            return operations.RegeneratePrimaryKeyAsync(resourceGroupName, serviceName, sid, CancellationToken.None);
        }
        
        /// <summary>
        /// Regenerates secindary key of existing subscription of the Api
        /// Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse RegenerateSecondaryKey(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).RegenerateSecondaryKeyAsync(resourceGroupName, serviceName, sid);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Regenerates secindary key of existing subscription of the Api
        /// Management service instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RegenerateSecondaryKeyAsync(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid)
        {
            return operations.RegenerateSecondaryKeyAsync(resourceGroupName, serviceName, sid, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates specific product subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <param name='parameters'>
        /// Required. Update parameters.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Update(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionUpdateParameters parameters, string etag)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISubscriptionsOperations)s).UpdateAsync(resourceGroupName, serviceName, sid, parameters, etag);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates specific product subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ISubscriptionsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <param name='sid'>
        /// Required. Identifier of the subscription.
        /// </param>
        /// <param name='parameters'>
        /// Required. Update parameters.
        /// </param>
        /// <param name='etag'>
        /// Required. ETag.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> UpdateAsync(this ISubscriptionsOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionUpdateParameters parameters, string etag)
        {
            return operations.UpdateAsync(resourceGroupName, serviceName, sid, parameters, etag, CancellationToken.None);
        }
    }
}
