# IO.Swagger.Api.AssetAdministrationShellRepositoryInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAssetAdministrationShellById**](AssetAdministrationShellRepositoryInterfaceApi.md#deleteassetadministrationshellbyid) | **DELETE** /shells/{aasIdentifier} | Deletes an Asset Administration Shell
[**GetAllAssetAdministrationShells**](AssetAdministrationShellRepositoryInterfaceApi.md#getallassetadministrationshells) | **GET** /shells | Returns all Asset Administration Shells
[**GetAssetAdministrationShellById**](AssetAdministrationShellRepositoryInterfaceApi.md#getassetadministrationshellbyid) | **GET** /shells/{aasIdentifier} | Returns a specific Asset Administration Shell
[**PostAssetAdministrationShell**](AssetAdministrationShellRepositoryInterfaceApi.md#postassetadministrationshell) | **POST** /shells | Creates a new Asset Administration Shell
[**PutAssetAdministrationShellById**](AssetAdministrationShellRepositoryInterfaceApi.md#putassetadministrationshellbyid) | **PUT** /shells/{aasIdentifier} | Updates an existing Asset Administration Shell

<a name="deleteassetadministrationshellbyid"></a>
# **DeleteAssetAdministrationShellById**
> void DeleteAssetAdministrationShellById (string aasIdentifier)

Deletes an Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAssetAdministrationShellByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRepositoryInterfaceApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes an Asset Administration Shell
                apiInstance.DeleteAssetAdministrationShellById(aasIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRepositoryInterfaceApi.DeleteAssetAdministrationShellById: " + e.Message );
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
<a name="getallassetadministrationshells"></a>
# **GetAllAssetAdministrationShells**
> List<AssetAdministrationShell> GetAllAssetAdministrationShells (List<IdentifierKeyValuePair> assetIds = null, string idShort = null)

Returns all Asset Administration Shells

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAssetAdministrationShellsExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRepositoryInterfaceApi();
            var assetIds = new List<IdentifierKeyValuePair>(); // List<IdentifierKeyValuePair> | The key-value-pair of an Asset identifier (optional) 
            var idShort = idShort_example;  // string | The Asset Administration Shell’s IdShort (optional) 

            try
            {
                // Returns all Asset Administration Shells
                List&lt;AssetAdministrationShell&gt; result = apiInstance.GetAllAssetAdministrationShells(assetIds, idShort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRepositoryInterfaceApi.GetAllAssetAdministrationShells: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetIds** | [**List&lt;IdentifierKeyValuePair&gt;**](IdentifierKeyValuePair.md)| The key-value-pair of an Asset identifier | [optional] 
 **idShort** | **string**| The Asset Administration Shell’s IdShort | [optional] 

### Return type

[**List<AssetAdministrationShell>**](AssetAdministrationShell.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetadministrationshellbyid"></a>
# **GetAssetAdministrationShellById**
> AssetAdministrationShell GetAssetAdministrationShellById (string aasIdentifier)

Returns a specific Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetAdministrationShellByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRepositoryInterfaceApi();
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns a specific Asset Administration Shell
                AssetAdministrationShell result = apiInstance.GetAssetAdministrationShellById(aasIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRepositoryInterfaceApi.GetAssetAdministrationShellById: " + e.Message );
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

[**AssetAdministrationShell**](AssetAdministrationShell.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postassetadministrationshell"></a>
# **PostAssetAdministrationShell**
> AssetAdministrationShell PostAssetAdministrationShell (AssetAdministrationShell body)

Creates a new Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAssetAdministrationShellExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRepositoryInterfaceApi();
            var body = new AssetAdministrationShell(); // AssetAdministrationShell | Asset Administration Shell object

            try
            {
                // Creates a new Asset Administration Shell
                AssetAdministrationShell result = apiInstance.PostAssetAdministrationShell(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRepositoryInterfaceApi.PostAssetAdministrationShell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetAdministrationShell**](AssetAdministrationShell.md)| Asset Administration Shell object | 

### Return type

[**AssetAdministrationShell**](AssetAdministrationShell.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putassetadministrationshellbyid"></a>
# **PutAssetAdministrationShellById**
> void PutAssetAdministrationShellById (AssetAdministrationShell body, string aasIdentifier)

Updates an existing Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAssetAdministrationShellByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellRepositoryInterfaceApi();
            var body = new AssetAdministrationShell(); // AssetAdministrationShell | Asset Administration Shell object
            var aasIdentifier = aasIdentifier_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded)

            try
            {
                // Updates an existing Asset Administration Shell
                apiInstance.PutAssetAdministrationShellById(body, aasIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellRepositoryInterfaceApi.PutAssetAdministrationShellById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetAdministrationShell**](AssetAdministrationShell.md)| Asset Administration Shell object | 
 **aasIdentifier** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
