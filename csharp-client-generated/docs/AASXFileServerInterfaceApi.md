# IO.Swagger.Api.AASXFileServerInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAASXByPackageId**](AASXFileServerInterfaceApi.md#deleteaasxbypackageid) | **DELETE** /packages/{packageId} | Deletes a specific AASX package from the server
[**GetAASXByPackageId**](AASXFileServerInterfaceApi.md#getaasxbypackageid) | **GET** /packages/{packageId} | Returns a specific AASX package from the server
[**GetAllAASXPackageIds**](AASXFileServerInterfaceApi.md#getallaasxpackageids) | **GET** /packages | Returns a list of available AASX packages at the server
[**PostAASXPackage**](AASXFileServerInterfaceApi.md#postaasxpackage) | **POST** /packages | Stores the AASX package at the server
[**PutAASXByPackageId**](AASXFileServerInterfaceApi.md#putaasxbypackageid) | **PUT** /packages/{packageId} | Updates the AASX package at the server

<a name="deleteaasxbypackageid"></a>
# **DeleteAASXByPackageId**
> void DeleteAASXByPackageId (string packageId)

Deletes a specific AASX package from the server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAASXByPackageIdExample
    {
        public void main()
        {
            var apiInstance = new AASXFileServerInterfaceApi();
            var packageId = packageId_example;  // string | The Package Id (BASE64-URL-encoded)

            try
            {
                // Deletes a specific AASX package from the server
                apiInstance.DeleteAASXByPackageId(packageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AASXFileServerInterfaceApi.DeleteAASXByPackageId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageId** | **string**| The Package Id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaasxbypackageid"></a>
# **GetAASXByPackageId**
> byte[] GetAASXByPackageId (string packageId)

Returns a specific AASX package from the server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAASXByPackageIdExample
    {
        public void main()
        {
            var apiInstance = new AASXFileServerInterfaceApi();
            var packageId = packageId_example;  // string | The package Id (BASE64-URL-encoded)

            try
            {
                // Returns a specific AASX package from the server
                byte[] result = apiInstance.GetAASXByPackageId(packageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AASXFileServerInterfaceApi.GetAASXByPackageId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **packageId** | **string**| The package Id (BASE64-URL-encoded) | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/asset-administration-shell-package

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallaasxpackageids"></a>
# **GetAllAASXPackageIds**
> List<PackageDescription> GetAllAASXPackageIds (string aasId = null)

Returns a list of available AASX packages at the server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllAASXPackageIdsExample
    {
        public void main()
        {
            var apiInstance = new AASXFileServerInterfaceApi();
            var aasId = aasId_example;  // string | The Asset Administration Shell’s unique id (BASE64-URL-encoded) (optional) 

            try
            {
                // Returns a list of available AASX packages at the server
                List&lt;PackageDescription&gt; result = apiInstance.GetAllAASXPackageIds(aasId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AASXFileServerInterfaceApi.GetAllAASXPackageIds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasId** | **string**| The Asset Administration Shell’s unique id (BASE64-URL-encoded) | [optional] 

### Return type

[**List<PackageDescription>**](PackageDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postaasxpackage"></a>
# **PostAASXPackage**
> PackageDescription PostAASXPackage (List<string> aasIds, byte[] file, string fileName)

Stores the AASX package at the server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostAASXPackageExample
    {
        public void main()
        {
            var apiInstance = new AASXFileServerInterfaceApi();
            var aasIds = new List<string>(); // List<string> | 
            var file = file_example;  // byte[] | 
            var fileName = fileName_example;  // string | 

            try
            {
                // Stores the AASX package at the server
                PackageDescription result = apiInstance.PostAASXPackage(aasIds, file, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AASXFileServerInterfaceApi.PostAASXPackage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIds** | [**List&lt;string&gt;**](string.md)|  | 
 **file** | **byte[]****byte[]**|  | 
 **fileName** | **string**|  | 

### Return type

[**PackageDescription**](PackageDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putaasxbypackageid"></a>
# **PutAASXByPackageId**
> void PutAASXByPackageId (List<string> aasIds, byte[] file, string fileName, string packageId)

Updates the AASX package at the server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutAASXByPackageIdExample
    {
        public void main()
        {
            var apiInstance = new AASXFileServerInterfaceApi();
            var aasIds = new List<string>(); // List<string> | 
            var file = file_example;  // byte[] | 
            var fileName = fileName_example;  // string | 
            var packageId = packageId_example;  // string | The Package Id (BASE64-URL-encoded)

            try
            {
                // Updates the AASX package at the server
                apiInstance.PutAASXByPackageId(aasIds, file, fileName, packageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AASXFileServerInterfaceApi.PutAASXByPackageId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aasIds** | [**List&lt;string&gt;**](string.md)|  | 
 **file** | **byte[]****byte[]**|  | 
 **fileName** | **string**|  | 
 **packageId** | **string**| The Package Id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
