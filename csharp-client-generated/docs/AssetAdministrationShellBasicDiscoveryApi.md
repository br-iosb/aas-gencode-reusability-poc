# IO.Swagger.Api.AssetAdministrationShellBasicDiscoveryApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAllAssetLinksById**](AssetAdministrationShellBasicDiscoveryApi.md#deleteallassetlinksbyid) | **DELETE** /lookup/shells/{aasIdentifier} | Deletes all Asset identifier key-value-pair linked to an Asset Administration Shell to edit discoverable content
[**GetAllAssetAdministrationShellIdsByAssetLink**](AssetAdministrationShellBasicDiscoveryApi.md#getallassetadministrationshellidsbyassetlink) | **GET** /lookup/shells | Returns a list of Asset Administration Shell ids based on Asset identifier key-value-pairs
[**GetAllAssetLinksById**](AssetAdministrationShellBasicDiscoveryApi.md#getallassetlinksbyid) | **GET** /lookup/shells/{aasIdentifier} | Returns a list of Asset identifier key-value-pairs based on an Asset Administration Shell id to edit discoverable content
[**PostAllAssetLinksById**](AssetAdministrationShellBasicDiscoveryApi.md#postallassetlinksbyid) | **POST** /lookup/shells/{aasIdentifier} | Creates all Asset identifier key-value-pair linked to an Asset Administration Shell to edit discoverable content

<a name="deleteallassetlinksbyid"></a>
# **DeleteAllAssetLinksById**
> void DeleteAllAssetLinksById (string aasIdentifier)

Deletes all Asset identifier key-value-pair linked to an Asset Administration Shell to edit discoverable content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAllAssetLinksByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellBasicDiscoveryApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes all Asset identifier key-value-pair linked to an Asset Administration Shell to edit discoverable content
                apiInstance.DeleteAllAssetLinksById(aasIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellBasicDiscoveryApi.DeleteAllAssetLinksById: " + e.Message );
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
<a name="getallassetadministrationshellidsbyassetlink"></a>
# **GetAllAssetAdministrationShellIdsByAssetLink**
> List<string> GetAllAssetAdministrationShellIdsByAssetLink (List<IdentifierKeyValuePair> assetIds = null)

Returns a list of Asset Administration Shell ids based on Asset identifier key-value-pairs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAssetAdministrationShellIdsByAssetLinkExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellBasicDiscoveryApi();
            var assetIds = new List<IdentifierKeyValuePair>(); // List<IdentifierKeyValuePair> | The key-value-pair of an Asset identifier (optional) 

            try
            {
                // Returns a list of Asset Administration Shell ids based on Asset identifier key-value-pairs
                List&lt;string&gt; result = apiInstance.GetAllAssetAdministrationShellIdsByAssetLink(assetIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellBasicDiscoveryApi.GetAllAssetAdministrationShellIdsByAssetLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetIds** | [**List&lt;IdentifierKeyValuePair&gt;**](IdentifierKeyValuePair.md)| The key-value-pair of an Asset identifier | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallassetlinksbyid"></a>
# **GetAllAssetLinksById**
> List<IdentifierKeyValuePair> GetAllAssetLinksById (string aasIdentifier)

Returns a list of Asset identifier key-value-pairs based on an Asset Administration Shell id to edit discoverable content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAssetLinksByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellBasicDiscoveryApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns a list of Asset identifier key-value-pairs based on an Asset Administration Shell id to edit discoverable content
                List&lt;IdentifierKeyValuePair&gt; result = apiInstance.GetAllAssetLinksById(aasIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellBasicDiscoveryApi.GetAllAssetLinksById: " + e.Message );
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

[**List<IdentifierKeyValuePair>**](IdentifierKeyValuePair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postallassetlinksbyid"></a>
# **PostAllAssetLinksById**
> List<IdentifierKeyValuePair> PostAllAssetLinksById (List<IdentifierKeyValuePair> body, string aasIdentifier)

Creates all Asset identifier key-value-pair linked to an Asset Administration Shell to edit discoverable content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAllAssetLinksByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellBasicDiscoveryApi();
            var body = new List<IdentifierKeyValuePair>(); // List<IdentifierKeyValuePair> | Asset identifier key-value-pairs
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Creates all Asset identifier key-value-pair linked to an Asset Administration Shell to edit discoverable content
                List&lt;IdentifierKeyValuePair&gt; result = apiInstance.PostAllAssetLinksById(body, aasIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellBasicDiscoveryApi.PostAllAssetLinksById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;IdentifierKeyValuePair&gt;**](IdentifierKeyValuePair.md)| Asset identifier key-value-pairs | 
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 

### Return type

[**List<IdentifierKeyValuePair>**](IdentifierKeyValuePair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
