/* 
 * DotAAS Part 2 | HTTP/REST | Entire Interface Collection
 *
 * The entire interface collection as part of Details of the Asset Administration Shell Part 2
 *
 * OpenAPI spec version: V1.0RC01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using AAS.OpenApi.Client.Client;

namespace AAS.OpenApi.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IAssetAdministrationShellSerializationInterfaceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>byte[]</returns>
        byte[] GenerateSerializationByIds (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions);

        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> GenerateSerializationByIdsWithHttpInfo (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> GenerateSerializationByIdsAsync (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions);

        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> GenerateSerializationByIdsAsyncWithHttpInfo (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class AssetAdministrationShellSerializationInterfaceApi : IAssetAdministrationShellSerializationInterfaceApi
    {
        private AAS.OpenApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAdministrationShellSerializationInterfaceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetAdministrationShellSerializationInterfaceApi(String basePath)
        {
            this.Configuration = new AAS.OpenApi.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AAS.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAdministrationShellSerializationInterfaceApi"/> class
        /// </summary>
        /// <returns></returns>
        public AssetAdministrationShellSerializationInterfaceApi()
        {
            this.Configuration = AAS.OpenApi.Client.Client.Configuration.Default;

            ExceptionFactory = AAS.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAdministrationShellSerializationInterfaceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AssetAdministrationShellSerializationInterfaceApi(AAS.OpenApi.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AAS.OpenApi.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AAS.OpenApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AAS.OpenApi.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AAS.OpenApi.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat) 
        /// </summary>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>byte[]</returns>
        public byte[] GenerateSerializationByIds (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions)
        {
             ApiResponse<byte[]> localVarResponse = GenerateSerializationByIdsWithHttpInfo(aasIds, submodelIds, includeConceptDescriptions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat) 
        /// </summary>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > GenerateSerializationByIdsWithHttpInfo (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions)
        {
            // verify the required parameter 'aasIds' is set
            if (aasIds == null)
                throw new ApiException(400, "Missing required parameter 'aasIds' when calling AssetAdministrationShellSerializationInterfaceApi->GenerateSerializationByIds");
            // verify the required parameter 'submodelIds' is set
            if (submodelIds == null)
                throw new ApiException(400, "Missing required parameter 'submodelIds' when calling AssetAdministrationShellSerializationInterfaceApi->GenerateSerializationByIds");
            // verify the required parameter 'includeConceptDescriptions' is set
            if (includeConceptDescriptions == null)
                throw new ApiException(400, "Missing required parameter 'includeConceptDescriptions' when calling AssetAdministrationShellSerializationInterfaceApi->GenerateSerializationByIds");

            var localVarPath = "/serialization";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/asset-administration-shell-package+xml",
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (aasIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "aasIds", aasIds)); // query parameter
            if (submodelIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "submodelIds", submodelIds)); // query parameter
            if (includeConceptDescriptions != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeConceptDescriptions", includeConceptDescriptions)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateSerializationByIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (byte[]) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }

        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat) 
        /// </summary>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> GenerateSerializationByIdsAsync (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions)
        {
             ApiResponse<byte[]> localVarResponse = await GenerateSerializationByIdsAsyncWithHttpInfo(aasIds, submodelIds, includeConceptDescriptions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat) 
        /// </summary>
        /// <exception cref="AAS.OpenApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> GenerateSerializationByIdsAsyncWithHttpInfo (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions)
        {
            // verify the required parameter 'aasIds' is set
            if (aasIds == null)
                throw new ApiException(400, "Missing required parameter 'aasIds' when calling AssetAdministrationShellSerializationInterfaceApi->GenerateSerializationByIds");
            // verify the required parameter 'submodelIds' is set
            if (submodelIds == null)
                throw new ApiException(400, "Missing required parameter 'submodelIds' when calling AssetAdministrationShellSerializationInterfaceApi->GenerateSerializationByIds");
            // verify the required parameter 'includeConceptDescriptions' is set
            if (includeConceptDescriptions == null)
                throw new ApiException(400, "Missing required parameter 'includeConceptDescriptions' when calling AssetAdministrationShellSerializationInterfaceApi->GenerateSerializationByIds");

            var localVarPath = "/serialization";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/asset-administration-shell-package+xml",
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (aasIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "aasIds", aasIds)); // query parameter
            if (submodelIds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "submodelIds", submodelIds)); // query parameter
            if (includeConceptDescriptions != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "includeConceptDescriptions", includeConceptDescriptions)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateSerializationByIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (byte[]) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
        }

    }
}
