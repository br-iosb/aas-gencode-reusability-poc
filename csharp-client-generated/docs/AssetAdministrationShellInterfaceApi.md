# IO.Swagger.Api.AssetAdministrationShellInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSubmodelReferenceById**](AssetAdministrationShellInterfaceApi.md#deletesubmodelreferencebyid) | **DELETE** /aas/submodels/{submodelIdentifier} | Deletes the submodel reference from the Asset Administration Shell
[**GetAllSubmodelReferences**](AssetAdministrationShellInterfaceApi.md#getallsubmodelreferences) | **GET** /aas/submodels | Returns all submodel references
[**GetAssetAdministrationShell**](AssetAdministrationShellInterfaceApi.md#getassetadministrationshell) | **GET** /aas | Returns the Asset Administration Shell
[**GetAssetInformation**](AssetAdministrationShellInterfaceApi.md#getassetinformation) | **GET** /aas/asset-information | Returns the Asset Information
[**PostSubmodelReference**](AssetAdministrationShellInterfaceApi.md#postsubmodelreference) | **POST** /aas/submodels | Creates a submodel reference at the Asset Administration Shell
[**PutAssetAdministrationShell**](AssetAdministrationShellInterfaceApi.md#putassetadministrationshell) | **PUT** /aas | Updates the Asset Administration Shell
[**PutAssetInformation**](AssetAdministrationShellInterfaceApi.md#putassetinformation) | **PUT** /aas/asset-information | Updates the Asset Information

<a name="deletesubmodelreferencebyid"></a>
# **DeleteSubmodelReferenceById**
> void DeleteSubmodelReferenceById (string submodelIdentifier)

Deletes the submodel reference from the Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubmodelReferenceByIdExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellInterfaceApi();
            var submodelIdentifier = submodelIdentifier_example;  // string | The Submodel’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes the submodel reference from the Asset Administration Shell
                apiInstance.DeleteSubmodelReferenceById(submodelIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellInterfaceApi.DeleteSubmodelReferenceById: " + e.Message );
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
<a name="getallsubmodelreferences"></a>
# **GetAllSubmodelReferences**
> List<Reference> GetAllSubmodelReferences ()

Returns all submodel references

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllSubmodelReferencesExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellInterfaceApi();

            try
            {
                // Returns all submodel references
                List&lt;Reference&gt; result = apiInstance.GetAllSubmodelReferences();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellInterfaceApi.GetAllSubmodelReferences: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Reference>**](Reference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetadministrationshell"></a>
# **GetAssetAdministrationShell**
> AssetAdministrationShell GetAssetAdministrationShell (string content = null)

Returns the Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetAdministrationShellExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellInterfaceApi();
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)

            try
            {
                // Returns the Asset Administration Shell
                AssetAdministrationShell result = apiInstance.GetAssetAdministrationShell(content);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellInterfaceApi.GetAssetAdministrationShell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]

### Return type

[**AssetAdministrationShell**](AssetAdministrationShell.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getassetinformation"></a>
# **GetAssetInformation**
> AssetInformation GetAssetInformation ()

Returns the Asset Information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetInformationExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellInterfaceApi();

            try
            {
                // Returns the Asset Information
                AssetInformation result = apiInstance.GetAssetInformation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellInterfaceApi.GetAssetInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AssetInformation**](AssetInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsubmodelreference"></a>
# **PostSubmodelReference**
> Reference PostSubmodelReference (Reference body)

Creates a submodel reference at the Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSubmodelReferenceExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellInterfaceApi();
            var body = new Reference(); // Reference | Reference to the Submodel

            try
            {
                // Creates a submodel reference at the Asset Administration Shell
                Reference result = apiInstance.PostSubmodelReference(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellInterfaceApi.PostSubmodelReference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Reference**](Reference.md)| Reference to the Submodel | 

### Return type

[**Reference**](Reference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putassetadministrationshell"></a>
# **PutAssetAdministrationShell**
> void PutAssetAdministrationShell (AssetAdministrationShell body, string content = null)

Updates the Asset Administration Shell

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAssetAdministrationShellExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellInterfaceApi();
            var body = new AssetAdministrationShell(); // AssetAdministrationShell | Asset Administration Shell object
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)

            try
            {
                // Updates the Asset Administration Shell
                apiInstance.PutAssetAdministrationShell(body, content);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellInterfaceApi.PutAssetAdministrationShell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetAdministrationShell**](AssetAdministrationShell.md)| Asset Administration Shell object | 
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putassetinformation"></a>
# **PutAssetInformation**
> void PutAssetInformation (AssetInformation body)

Updates the Asset Information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAssetInformationExample
    {
        public void main()
        {
            var apiInstance = new AssetAdministrationShellInterfaceApi();
            var body = new AssetInformation(); // AssetInformation | Asset Information object

            try
            {
                // Updates the Asset Information
                apiInstance.PutAssetInformation(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetAdministrationShellInterfaceApi.PutAssetInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AssetInformation**](AssetInformation.md)| Asset Information object | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
