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
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// Operations for managing Tenant Policy.
    /// </summary>
    public partial interface ITenantPolicyOperations
    {
        /// <summary>
        /// Deletes tenant-level policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='etag'>
        /// ETag.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string serviceName, string etag, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets tenant-level policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='format'>
        /// Format of the policy. Supported formats:
        /// application/vnd.ms-azure-apim.policy+xml
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get policy output operation.
        /// </returns>
        Task<PolicyGetResponse> GetAsync(string resourceGroupName, string serviceName, string format, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets tenant-level policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='format'>
        /// Format of the policy. Supported formats:
        /// application/vnd.ms-azure-apim.policy+xml
        /// </param>
        /// <param name='policyStream'>
        /// Policy stream.
        /// </param>
        /// <param name='etag'>
        /// ETag.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SetAsync(string resourceGroupName, string serviceName, string format, Stream policyStream, string etag, CancellationToken cancellationToken);
    }
}
