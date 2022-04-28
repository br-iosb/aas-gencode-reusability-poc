# IO.Swagger.Api.AssetAdministrationShellSerializationInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateSerializationByIds**](AssetAdministrationShellSerializationInterfaceApi.md#generateserializationbyids) | **GET** /serialization | Returns an appropriate serialization based on the specified format (see SerializationFormat)

<a name="generateserializationbyids"></a>
# **GenerateSerializationByIds**
> byte[] GenerateSerializationByIds (List<string> aasIds, List<string> submodelIds, bool? includeConceptDescriptions)

Returns an appropriate serialization based on the specified format (see SerializationFormat)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GenerateSerializationByIdsExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellSerializationInterfaceApi();
            var aasIds = new List<string>(); // List<string> | The Asset Administration Shells' unique ids (BASE64-URL-encoded)
            var submodelIds = new List<string>(); // List<string> | The Submodels' unique ids (BASE64-URL-encoded)
            var includeConceptDescriptions = true;  // bool? | Include Concept Descriptions? (default to true)

            try
            {
                // Returns an appropriate serialization based on the specified format (see SerializationFormat)
                byte[] result = apiInstance.GenerateSerializationByIds(aasIds, submodelIds, includeConceptDescriptions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellSerializationInterfaceApi.GenerateSerializationByIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIds** | [**List&lt;string&gt;**](string.md)| The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded) | 
 **submodelIds** | [**List&lt;string&gt;**](string.md)| The Submodels&#x27; unique ids (BASE64-URL-encoded) | 
 **includeConceptDescriptions** | **bool?**| Include Concept Descriptions? | [default to true]

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/asset-administration-shell-package+xml, application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
