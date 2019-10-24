// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ManifestsOperations operations.
    /// </summary>
    public partial interface IManifestsOperations
    {
        /// <summary>
        /// Get the manifest identified by `name` and `reference` where
        /// `reference` can be a tag or digest.
        /// </summary>
        /// <param name='name'>
        /// Name of the image (including the namespace)
        /// </param>
        /// <param name='reference'>
        /// A tag or a digest, pointing to a specific image
        /// </param>
        /// <param name='accept'>
        /// Accept header string delimited by comma. For example,
        /// application/vnd.docker.distribution.manifest.v2+json
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AcrErrorsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManifestWrapper>> GetWithHttpMessagesAsync(string name, string reference, string accept = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put the manifest identified by `name` and `reference` where
        /// `reference` can be a tag or digest.
        /// </summary>
        /// <param name='name'>
        /// Name of the image (including the namespace)
        /// </param>
        /// <param name='reference'>
        /// A tag or a digest, pointing to a specific image
        /// </param>
        /// <param name='payload'>
        /// Manifest body, can take v1 or v2 values depending on accept header
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AcrErrorsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object,ManifestsCreateHeaders>> CreateWithHttpMessagesAsync(string name, string reference, Manifest payload, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the manifest identified by `name` and `reference`. Note that
        /// a manifest can _only_ be deleted by `digest`.
        /// </summary>
        /// <param name='name'>
        /// Name of the image (including the namespace)
        /// </param>
        /// <param name='reference'>
        /// A tag or a digest, pointing to a specific image
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AcrErrorsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string name, string reference, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List manifests of a repository
        /// </summary>
        /// <param name='name'>
        /// Name of the image (including the namespace)
        /// </param>
        /// <param name='last'>
        /// Query parameter for the last item in previous query. Result set
        /// will include values lexically after last.
        /// </param>
        /// <param name='n'>
        /// query parameter for max number of items
        /// </param>
        /// <param name='orderby'>
        /// orderby query parameter
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AcrErrorsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AcrManifests>> GetListWithHttpMessagesAsync(string name, string last = default(string), int? n = default(int?), string orderby = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get manifest attributes
        /// </summary>
        /// <param name='name'>
        /// Name of the image (including the namespace)
        /// </param>
        /// <param name='reference'>
        /// A tag or a digest, pointing to a specific image
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AcrErrorsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManifestAttributes>> GetAttributesWithHttpMessagesAsync(string name, string reference, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update attributes of a manifest
        /// </summary>
        /// <param name='name'>
        /// Name of the image (including the namespace)
        /// </param>
        /// <param name='reference'>
        /// A tag or a digest, pointing to a specific image
        /// </param>
        /// <param name='value'>
        /// Repository attribute value
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AcrErrorsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> UpdateAttributesWithHttpMessagesAsync(string name, string reference, ChangeableAttributes value = default(ChangeableAttributes), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}