// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExtendedDatabaseBlobAuditingPoliciesOperations.
    /// </summary>
    public static partial class ExtendedDatabaseBlobAuditingPoliciesOperationsExtensions
    {
            /// <summary>
            /// Lists extended auditing settings of a database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static IPage<ExtendedDatabaseBlobAuditingPolicy> ListByDatabase(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName)
            {
                return operations.ListByDatabaseAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists extended auditing settings of a database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExtendedDatabaseBlobAuditingPolicy>> ListByDatabaseAsync(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an extended database's blob auditing policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static ExtendedDatabaseBlobAuditingPolicy Get(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName)
            {
                return operations.GetAsync(resourceGroupName, serverName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an extended database's blob auditing policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedDatabaseBlobAuditingPolicy> GetAsync(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an extended database's blob auditing policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// The extended database blob auditing policy.
            /// </param>
            public static ExtendedDatabaseBlobAuditingPolicy CreateOrUpdate(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, ExtendedDatabaseBlobAuditingPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an extended database's blob auditing policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='parameters'>
            /// The extended database blob auditing policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedDatabaseBlobAuditingPolicy> CreateOrUpdateAsync(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string resourceGroupName, string serverName, string databaseName, ExtendedDatabaseBlobAuditingPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists extended auditing settings of a database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExtendedDatabaseBlobAuditingPolicy> ListByDatabaseNext(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists extended auditing settings of a database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExtendedDatabaseBlobAuditingPolicy>> ListByDatabaseNextAsync(this IExtendedDatabaseBlobAuditingPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
