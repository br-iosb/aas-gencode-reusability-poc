# IO.Swagger.Api.SubmodelRegistryInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSubmodelDescriptorById**](SubmodelRegistryInterfaceApi.md#deletesubmodeldescriptorbyid) | **DELETE** /registry/submodel-descriptors/{submodelIdentifier} | Deletes a Submodel Descriptor, i.e. de-registers a submodel
[**GetAllSubmodelDescriptors**](SubmodelRegistryInterfaceApi.md#getallsubmodeldescriptors) | **GET** /registry/submodel-descriptors | Returns all Submodel Descriptors
[**GetSubmodelDescriptorById**](SubmodelRegistryInterfaceApi.md#getsubmodeldescriptorbyid) | **GET** /registry/submodel-descriptors/{submodelIdentifier} | Returns a specific Submodel Descriptor
[**PostSubmodelDescriptor**](SubmodelRegistryInterfaceApi.md#postsubmodeldescriptor) | **POST** /registry/submodel-descriptors | Creates a new Submodel Descriptor, i.e. registers a submodel
[**PutSubmodelDescriptorById**](SubmodelRegistryInterfaceApi.md#putsubmodeldescriptorbyid) | **PUT** /registry/submodel-descriptors/{submodelIdentifier} | Updates an existing Submodel Descriptor

<a name="deletesubmodeldescriptorbyid"></a>
# **DeleteSubmodelDescriptorById**
> void DeleteSubmodelDescriptorById (string submodelIdentifier)

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
    public class DeleteSubmodelDescriptorByIdExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRegistryInterfaceApi();
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes a Submodel Descriptor, i.e. de-registers a submodel
                apiInstance.DeleteSubmodelDescriptorById(submodelIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRegistryInterfaceApi.DeleteSubmodelDescriptorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submodelIdentifier** | **string**| The Submodel’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallsubmodeldescriptors"></a>
# **GetAllSubmodelDescriptors**
> List<SubmodelDescriptor> GetAllSubmodelDescriptors ()

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
    public class GetAllSubmodelDescriptorsExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRegistryInterfaceApi();

            try
            {
                // Returns all Submodel Descriptors
                List&lt;SubmodelDescriptor&gt; result = apiInstance.GetAllSubmodelDescriptors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRegistryInterfaceApi.GetAllSubmodelDescriptors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SubmodelDescriptor>**](SubmodelDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubmodeldescriptorbyid"></a>
# **GetSubmodelDescriptorById**
> SubmodelDescriptor GetSubmodelDescriptorById (string submodelIdentifier)

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
    public class GetSubmodelDescriptorByIdExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRegistryInterfaceApi();
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns a specific Submodel Descriptor
                SubmodelDescriptor result = apiInstance.GetSubmodelDescriptorById(submodelIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRegistryInterfaceApi.GetSubmodelDescriptorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submodelIdentifier** | **string**| The Submodel’s unique id (BASE64-URL-encoded) | 

### Return type

[**SubmodelDescriptor**](SubmodelDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsubmodeldescriptor"></a>
# **PostSubmodelDescriptor**
> SubmodelDescriptor PostSubmodelDescriptor (SubmodelDescriptor body)

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
    public class PostSubmodelDescriptorExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRegistryInterfaceApi();
            var body = new SubmodelDescriptor(); // SubmodelDescriptor | Submodel Descriptor object

            try
            {
                // Creates a new Submodel Descriptor, i.e. registers a submodel
                SubmodelDescriptor result = apiInstance.PostSubmodelDescriptor(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRegistryInterfaceApi.PostSubmodelDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmodelDescriptor**](SubmodelDescriptor.md)| Submodel Descriptor object | 

### Return type

[**SubmodelDescriptor**](SubmodelDescriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putsubmodeldescriptorbyid"></a>
# **PutSubmodelDescriptorById**
> void PutSubmodelDescriptorById (SubmodelDescriptor body, string submodelIdentifier)

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
    public class PutSubmodelDescriptorByIdExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRegistryInterfaceApi();
            var body = new SubmodelDescriptor(); // SubmodelDescriptor | Submodel Descriptor object
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Updates an existing Submodel Descriptor
                apiInstance.PutSubmodelDescriptorById(body, submodelIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRegistryInterfaceApi.PutSubmodelDescriptorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmodelDescriptor**](SubmodelDescriptor.md)| Submodel Descriptor object | 
 **submodelIdentifier** | **string**| The Submodel’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
