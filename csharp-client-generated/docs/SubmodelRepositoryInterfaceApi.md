# IO.Swagger.Api.SubmodelRepositoryInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSubmodelById**](SubmodelRepositoryInterfaceApi.md#deletesubmodelbyid) | **DELETE** /submodels/{submodelIdentifier} | Deletes a Submodel
[**GetAllSubmodels**](SubmodelRepositoryInterfaceApi.md#getallsubmodels) | **GET** /submodels | Returns all Submodels
[**GetSubmodelById**](SubmodelRepositoryInterfaceApi.md#getsubmodelbyid) | **GET** /submodels/{submodelIdentifier} | Returns a specific Submodel
[**PostSubmodel**](SubmodelRepositoryInterfaceApi.md#postsubmodel) | **POST** /submodels | Creates a new Submodel
[**PutSubmodelById**](SubmodelRepositoryInterfaceApi.md#putsubmodelbyid) | **PUT** /submodels/{submodelIdentifier} | Creates a new or updates an existing Submodel

<a name="deletesubmodelbyid"></a>
# **DeleteSubmodelById**
> void DeleteSubmodelById (string submodelIdentifier)

Deletes a Submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubmodelByIdExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRepositoryInterfaceApi();
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes a Submodel
                apiInstance.DeleteSubmodelById(submodelIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRepositoryInterfaceApi.DeleteSubmodelById: " + e.Message );
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
<a name="getallsubmodels"></a>
# **GetAllSubmodels**
> List<Submodel> GetAllSubmodels (string semanticId = null, string idShort = null)

Returns all Submodels

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllSubmodelsExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRepositoryInterfaceApi();
            var semanticId = semanticId_example;  // string | The value of the semantic id reference (BASE64-URL-encoded) (optional) 
            var idShort = idShort_example;  // string | The Submodel’s idShort (optional) 

            try
            {
                // Returns all Submodels
                List&lt;Submodel&gt; result = apiInstance.GetAllSubmodels(semanticId, idShort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRepositoryInterfaceApi.GetAllSubmodels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **semanticId** | **string**| The value of the semantic id reference (BASE64-URL-encoded) | [optional] 
 **idShort** | **string**| The Submodel’s idShort | [optional] 

### Return type

[**List<Submodel>**](Submodel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubmodelbyid"></a>
# **GetSubmodelById**
> Submodel GetSubmodelById (string submodelIdentifier)

Returns a specific Submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubmodelByIdExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRepositoryInterfaceApi();
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns a specific Submodel
                Submodel result = apiInstance.GetSubmodelById(submodelIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRepositoryInterfaceApi.GetSubmodelById: " + e.Message );
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

[**Submodel**](Submodel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsubmodel"></a>
# **PostSubmodel**
> Submodel PostSubmodel (Submodel body)

Creates a new Submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSubmodelExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRepositoryInterfaceApi();
            var body = new Submodel(); // Submodel | Submodel object

            try
            {
                // Creates a new Submodel
                Submodel result = apiInstance.PostSubmodel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRepositoryInterfaceApi.PostSubmodel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Submodel**](Submodel.md)| Submodel object | 

### Return type

[**Submodel**](Submodel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putsubmodelbyid"></a>
# **PutSubmodelById**
> Submodel PutSubmodelById (Submodel body, string submodelIdentifier)

Creates a new or updates an existing Submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutSubmodelByIdExample
    {
        public void main()
        {
            var apiInstance = new SubmodelRepositoryInterfaceApi();
            var body = new Submodel(); // Submodel | Submodel object
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Creates a new or updates an existing Submodel
                Submodel result = apiInstance.PutSubmodelById(body, submodelIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelRepositoryInterfaceApi.PutSubmodelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Submodel**](Submodel.md)| Submodel object | 
 **submodelIdentifier** | **string**| The Submodel’s unique id (BASE64-URL-encoded) | 

### Return type

[**Submodel**](Submodel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
