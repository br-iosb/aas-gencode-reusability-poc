# IO.Swagger.Api.AssetAdministrationShellRegistryInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAssetAdministrationShellDescriptorById**](AssetAdministrationShellRegistryInterfaceApi.md#deleteassetadministrationshelldescriptorbyid) | **DELETE** /registry/shell-descriptors/{aasIdentifier} | Deletes an Asset Administration Shell Descriptor, i.e. de-registers an AAS
[**DeleteSubmodelDescriptorByIdAASRegistry**](AssetAdministrationShellRegistryInterfaceApi.md#deletesubmodeldescriptorbyidaasregistry) | **DELETE** /registry/shell-descriptors/{aasIdentifier}/submodel-descriptors/{submodelIdentifier} | Deletes a Submodel Descriptor, i.e. de-registers a submodel
[**GetAllAssetAdministrationShellDescriptors**](AssetAdministrationShellRegistryInterfaceApi.md#getallassetadministrationshelldescriptors) | **GET** /registry/shell-descriptors | Returns all Asset Administration Shell Descriptors
[**GetAllSubmodelDescriptorsAASRegistry**](AssetAdministrationShellRegistryInterfaceApi.md#getallsubmodeldescriptorsaasregistry) | **GET** /registry/shell-descriptors/{aasIdentifier}/submodel-descriptors | Returns all Submodel Descriptors
[**GetAssetAdministrationShellDescriptorById**](AssetAdministrationShellRegistryInterfaceApi.md#getassetadministrationshelldescriptorbyid) | **GET** /registry/shell-descriptors/{aasIdentifier} | Returns a specific Asset Administration Shell Descriptor
[**GetSubmodelDescriptorByIdAASRegistry**](AssetAdministrationShellRegistryInterfaceApi.md#getsubmodeldescriptorbyidaasregistry) | **GET** /registry/shell-descriptors/{aasIdentifier}/submodel-descriptors/{submodelIdentifier} | Returns a specific Submodel Descriptor
[**PostAssetAdministrationShellDescriptor**](AssetAdministrationShellRegistryInterfaceApi.md#postassetadministrationshelldescriptor) | **POST** /registry/shell-descriptors | Creates a new Asset Administration Shell Descriptor, i.e. registers an AAS
[**PostSubmodelDescriptorAASRegistry**](AssetAdministrationShellRegistryInterfaceApi.md#postsubmodeldescriptoraasregistry) | **POST** /registry/shell-descriptors/{aasIdentifier}/submodel-descriptors | Creates a new Submodel Descriptor, i.e. registers a submodel
[**PutAssetAdministrationShellDescriptorById**](AssetAdministrationShellRegistryInterfaceApi.md#putassetadministrationshelldescriptorbyid) | **PUT** /registry/shell-descriptors/{aasIdentifier} | Updates an existing Asset Administration Shell Descriptor
[**PutSubmodelDescriptorByIdAASRegistry**](AssetAdministrationShellRegistryInterfaceApi.md#putsubmodeldescriptorbyidaasregistry) | **PUT** /registry/shell-descriptors/{aasIdentifier}/submodel-descriptors/{submodelIdentifier} | Updates an existing Submodel Descriptor

<a name="deleteassetadministrationshelldescriptorbyid"></a>
# **DeleteAssetAdministrationShellDescriptorById**
> void DeleteAssetAdministrationShellDescriptorById (string aasIdentifier)

Deletes an Asset Administration Shell Descriptor, i.e. de-registers an AAS

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAssetAdministrationShellDescriptorByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes an Asset Administration Shell Descriptor, i.e. de-registers an AAS
                apiInstance.DeleteAssetAdministrationShellDescriptorById(aasIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.DeleteAssetAdministrationShellDescriptorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesubmodeldescriptorbyidaasregistry"></a>
# **DeleteSubmodelDescriptorByIdAASRegistry**
> void DeleteSubmodelDescriptorByIdAASRegistry (string aasIdentifier, string submodelIdentifier)

Deletes a Submodel Descriptor, i.e. de-registers a submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubmodelDescriptorByIdAASRegistryExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes a Submodel Descriptor, i.e. de-registers a submodel
                apiInstance.DeleteSubmodelDescriptorByIdAASRegistry(aasIdentifier, submodelIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.DeleteSubmodelDescriptorByIdAASRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 
 **submodelIdentifier** | **string**| The Submodel’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallassetadministrationshelldescriptors"></a>
# **GetAllAssetAdministrationShellDescriptors**
> List<AssetAdministrationShellDescriptor> GetAllAssetAdministrationShellDescriptors ()

Returns all Asset Administration Shell Descriptors

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAssetAdministrationShellDescriptorsExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();

            try
            {
                // Returns all Asset Administration Shell Descriptors
                List&lt;AssetAdministrationShellDescriptor&gt; result = apiInstance.GetAllAssetAdministrationShellDescriptors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.GetAllAssetAdministrationShellDescriptors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AssetAdministrationShellDescriptor>**](AssetAdministrationShellDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallsubmodeldescriptorsaasregistry"></a>
# **GetAllSubmodelDescriptorsAASRegistry**
> List<SubmodelDescriptor> GetAllSubmodelDescriptorsAASRegistry (string aasIdentifier)

Returns all Submodel Descriptors

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllSubmodelDescriptorsAASRegistryExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns all Submodel Descriptors
                List&lt;SubmodelDescriptor&gt; result = apiInstance.GetAllSubmodelDescriptorsAASRegistry(aasIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.GetAllSubmodelDescriptorsAASRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 

### Return type

[**List<SubmodelDescriptor>**](SubmodelDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetadministrationshelldescriptorbyid"></a>
# **GetAssetAdministrationShellDescriptorById**
> AssetAdministrationShellDescriptor GetAssetAdministrationShellDescriptorById (string aasIdentifier)

Returns a specific Asset Administration Shell Descriptor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetAdministrationShellDescriptorByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns a specific Asset Administration Shell Descriptor
                AssetAdministrationShellDescriptor result = apiInstance.GetAssetAdministrationShellDescriptorById(aasIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.GetAssetAdministrationShellDescriptorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 

### Return type

[**AssetAdministrationShellDescriptor**](AssetAdministrationShellDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubmodeldescriptorbyidaasregistry"></a>
# **GetSubmodelDescriptorByIdAASRegistry**
> SubmodelDescriptor GetSubmodelDescriptorByIdAASRegistry (string aasIdentifier, string submodelIdentifier)

Returns a specific Submodel Descriptor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubmodelDescriptorByIdAASRegistryExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns a specific Submodel Descriptor
                SubmodelDescriptor result = apiInstance.GetSubmodelDescriptorByIdAASRegistry(aasIdentifier, submodelIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.GetSubmodelDescriptorByIdAASRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 
 **submodelIdentifier** | **string**| The Submodel’s unique id (BASE64-URL-encoded) | 

### Return type

[**SubmodelDescriptor**](SubmodelDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postassetadministrationshelldescriptor"></a>
# **PostAssetAdministrationShellDescriptor**
> AssetAdministrationShellDescriptor PostAssetAdministrationShellDescriptor (AssetAdministrationShellDescriptor body)

Creates a new Asset Administration Shell Descriptor, i.e. registers an AAS

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAssetAdministrationShellDescriptorExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var body = new AssetAdministrationShellDescriptor(); // AssetAdministrationShellDescriptor | Asset Administration Shell Descriptor object

            try
            {
                // Creates a new Asset Administration Shell Descriptor, i.e. registers an AAS
                AssetAdministrationShellDescriptor result = apiInstance.PostAssetAdministrationShellDescriptor(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.PostAssetAdministrationShellDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetAdministrationShellDescriptor**](AssetAdministrationShellDescriptor.md)| Asset Administration Shell Descriptor object | 

### Return type

[**AssetAdministrationShellDescriptor**](AssetAdministrationShellDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsubmodeldescriptoraasregistry"></a>
# **PostSubmodelDescriptorAASRegistry**
> SubmodelDescriptor PostSubmodelDescriptorAASRegistry (SubmodelDescriptor body, string aasIdentifier)

Creates a new Submodel Descriptor, i.e. registers a submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSubmodelDescriptorAASRegistryExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var body = new SubmodelDescriptor(); // SubmodelDescriptor | Submodel Descriptor object
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Creates a new Submodel Descriptor, i.e. registers a submodel
                SubmodelDescriptor result = apiInstance.PostSubmodelDescriptorAASRegistry(body, aasIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.PostSubmodelDescriptorAASRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmodelDescriptor**](SubmodelDescriptor.md)| Submodel Descriptor object | 
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 

### Return type

[**SubmodelDescriptor**](SubmodelDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putassetadministrationshelldescriptorbyid"></a>
# **PutAssetAdministrationShellDescriptorById**
> void PutAssetAdministrationShellDescriptorById (AssetAdministrationShellDescriptor body, string aasIdentifier)

Updates an existing Asset Administration Shell Descriptor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAssetAdministrationShellDescriptorByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var body = new AssetAdministrationShellDescriptor(); // AssetAdministrationShellDescriptor | Asset Administration Shell Descriptor object
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Updates an existing Asset Administration Shell Descriptor
                apiInstance.PutAssetAdministrationShellDescriptorById(body, aasIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.PutAssetAdministrationShellDescriptorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetAdministrationShellDescriptor**](AssetAdministrationShellDescriptor.md)| Asset Administration Shell Descriptor object | 
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putsubmodeldescriptorbyidaasregistry"></a>
# **PutSubmodelDescriptorByIdAASRegistry**
> void PutSubmodelDescriptorByIdAASRegistry (SubmodelDescriptor body, string aasIdentifier, string submodelIdentifier)

Updates an existing Submodel Descriptor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutSubmodelDescriptorByIdAASRegistryExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRegistryInterfaceApi();
            var body = new SubmodelDescriptor(); // SubmodelDescriptor | Submodel Descriptor object
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Updates an existing Submodel Descriptor
                apiInstance.PutSubmodelDescriptorByIdAASRegistry(body, aasIdentifier, submodelIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRegistryInterfaceApi.PutSubmodelDescriptorByIdAASRegistry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmodelDescriptor**](SubmodelDescriptor.md)| Submodel Descriptor object | 
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 
 **submodelIdentifier** | **string**| The Submodel’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
