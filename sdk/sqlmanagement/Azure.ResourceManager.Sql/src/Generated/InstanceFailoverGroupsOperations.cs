// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The InstanceFailoverGroups service client. </summary>
    public partial class InstanceFailoverGroupsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal InstanceFailoverGroupsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of InstanceFailoverGroupsOperations for mocking. </summary>
        protected InstanceFailoverGroupsOperations()
        {
        }

        /// <summary> Initializes a new instance of InstanceFailoverGroupsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal InstanceFailoverGroupsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new InstanceFailoverGroupsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<InstanceFailoverGroup>> GetAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, locationName, failoverGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<InstanceFailoverGroup> Get(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, locationName, failoverGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the failover groups in a location. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="locationName"/> is null. </exception>
        public virtual AsyncPageable<InstanceFailoverGroup> ListByLocationAsync(string resourceGroupName, string locationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            async Task<Page<InstanceFailoverGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByLocationAsync(resourceGroupName, locationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InstanceFailoverGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByLocationNextPageAsync(nextLink, resourceGroupName, locationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the failover groups in a location. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="locationName"/> is null. </exception>
        public virtual Pageable<InstanceFailoverGroup> ListByLocation(string resourceGroupName, string locationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            Page<InstanceFailoverGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = RestClient.ListByLocation(resourceGroupName, locationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InstanceFailoverGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.ListByLocation");
                scope.Start();
                try
                {
                    var response = RestClient.ListByLocationNextPage(nextLink, resourceGroupName, locationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, <paramref name="failoverGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<InstanceFailoverGroupsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string locationName, string failoverGroupName, InstanceFailoverGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, locationName, failoverGroupName, parameters, cancellationToken).ConfigureAwait(false);
                return new InstanceFailoverGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, locationName, failoverGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, <paramref name="failoverGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual InstanceFailoverGroupsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string locationName, string failoverGroupName, InstanceFailoverGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, locationName, failoverGroupName, parameters, cancellationToken);
                return new InstanceFailoverGroupsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, locationName, failoverGroupName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<InstanceFailoverGroupsDeleteOperation> StartDeleteAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, locationName, failoverGroupName, cancellationToken).ConfigureAwait(false);
                return new InstanceFailoverGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, locationName, failoverGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a failover group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public virtual InstanceFailoverGroupsDeleteOperation StartDelete(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, locationName, failoverGroupName, cancellationToken);
                return new InstanceFailoverGroupsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, locationName, failoverGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Fails over from the current primary managed instance to this managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<InstanceFailoverGroupsFailoverOperation> StartFailoverAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartFailover");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.FailoverAsync(resourceGroupName, locationName, failoverGroupName, cancellationToken).ConfigureAwait(false);
                return new InstanceFailoverGroupsFailoverOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverRequest(resourceGroupName, locationName, failoverGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Fails over from the current primary managed instance to this managed instance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public virtual InstanceFailoverGroupsFailoverOperation StartFailover(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartFailover");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Failover(resourceGroupName, locationName, failoverGroupName, cancellationToken);
                return new InstanceFailoverGroupsFailoverOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverRequest(resourceGroupName, locationName, failoverGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Fails over from the current primary managed instance to this managed instance. This operation might result in data loss. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<InstanceFailoverGroupsForceFailoverAllowDataLossOperation> StartForceFailoverAllowDataLossAsync(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartForceFailoverAllowDataLoss");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ForceFailoverAllowDataLossAsync(resourceGroupName, locationName, failoverGroupName, cancellationToken).ConfigureAwait(false);
                return new InstanceFailoverGroupsForceFailoverAllowDataLossOperation(_clientDiagnostics, _pipeline, RestClient.CreateForceFailoverAllowDataLossRequest(resourceGroupName, locationName, failoverGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Fails over from the current primary managed instance to this managed instance. This operation might result in data loss. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="locationName"/>, or <paramref name="failoverGroupName"/> is null. </exception>
        public virtual InstanceFailoverGroupsForceFailoverAllowDataLossOperation StartForceFailoverAllowDataLoss(string resourceGroupName, string locationName, string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstanceFailoverGroupsOperations.StartForceFailoverAllowDataLoss");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ForceFailoverAllowDataLoss(resourceGroupName, locationName, failoverGroupName, cancellationToken);
                return new InstanceFailoverGroupsForceFailoverAllowDataLossOperation(_clientDiagnostics, _pipeline, RestClient.CreateForceFailoverAllowDataLossRequest(resourceGroupName, locationName, failoverGroupName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
