# IO.Swagger.Api.SubmodelInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSubmodelElementByPath**](SubmodelInterfaceApi.md#deletesubmodelelementbypath) | **DELETE** /submodel/submodel-elements/{idShortPath} | Deletes a submodel element at a specified path within the submodel elements hierarchy
[**GetAllSubmodelElements**](SubmodelInterfaceApi.md#getallsubmodelelements) | **GET** /submodel/submodel-elements | Returns all submodel elements including their hierarchy
[**GetOperationAsyncResult**](SubmodelInterfaceApi.md#getoperationasyncresult) | **GET** /submodel/submodel-elements/{idShortPath}/operation-results/{handleId} | Returns the Operation result of an asynchronous invoked Operation
[**GetSubmodel**](SubmodelInterfaceApi.md#getsubmodel) | **GET** /submodel | Returns the Submodel
[**GetSubmodelElementByPath**](SubmodelInterfaceApi.md#getsubmodelelementbypath) | **GET** /submodel/submodel-elements/{idShortPath} | Returns a specific submodel element from the Submodel at a specified path
[**InvokeOperation**](SubmodelInterfaceApi.md#invokeoperation) | **POST** /submodel/submodel-elements/{idShortPath}/invoke | Synchronously or asynchronously invokes an Operation at a specified path
[**PostSubmodelElement**](SubmodelInterfaceApi.md#postsubmodelelement) | **POST** /submodel/submodel-elements | Creates a new submodel element
[**PostSubmodelElementByPath**](SubmodelInterfaceApi.md#postsubmodelelementbypath) | **POST** /submodel/submodel-elements/{idShortPath} | Creates a new submodel element at a specified path within submodel elements hierarchy
[**PutSubmodel**](SubmodelInterfaceApi.md#putsubmodel) | **PUT** /submodel | Updates the Submodel
[**PutSubmodelElementByPath**](SubmodelInterfaceApi.md#putsubmodelelementbypath) | **PUT** /submodel/submodel-elements/{idShortPath} | Updates an existing submodel element at a specified path within submodel elements hierarchy

<a name="deletesubmodelelementbypath"></a>
# **DeleteSubmodelElementByPath**
> void DeleteSubmodelElementByPath (string idShortPath)

Deletes a submodel element at a specified path within the submodel elements hierarchy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubmodelElementByPathExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var idShortPath = idShortPath_example;  // string | IdShort path to the submodel element (dot-separated)

            try
            {
                // Deletes a submodel element at a specified path within the submodel elements hierarchy
                apiInstance.DeleteSubmodelElementByPath(idShortPath);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.DeleteSubmodelElementByPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idShortPath** | **string**| IdShort path to the submodel element (dot-separated) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallsubmodelelements"></a>
# **GetAllSubmodelElements**
> List<SubmodelElement> GetAllSubmodelElements (string level = null, string content = null, string extent = null)

Returns all submodel elements including their hierarchy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllSubmodelElementsExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var level = level_example;  // string | Determines the structural depth of the respective resource content (optional)  (default to deep)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)
            var extent = extent_example;  // string | Determines to which extent the resource is being serialized (optional) 

            try
            {
                // Returns all submodel elements including their hierarchy
                List&lt;SubmodelElement&gt; result = apiInstance.GetAllSubmodelElements(level, content, extent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.GetAllSubmodelElements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **level** | **string**| Determines the structural depth of the respective resource content | [optional] [default to deep]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]
 **extent** | **string**| Determines to which extent the resource is being serialized | [optional] 

### Return type

[**List<SubmodelElement>**](SubmodelElement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoperationasyncresult"></a>
# **GetOperationAsyncResult**
> OperationResult GetOperationAsyncResult (string idShortPath, string handleId, string content = null)

Returns the Operation result of an asynchronous invoked Operation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOperationAsyncResultExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var idShortPath = idShortPath_example;  // string | IdShort path to the submodel element (dot-separated), in this case an operation
            var handleId = handleId_example;  // string | The returned handle id of an operation’s asynchronous invocation used to request the current state of the operation’s execution (BASE64-URL-encoded)
            var content = content_example;  // string |  (optional)  (default to normal)

            try
            {
                // Returns the Operation result of an asynchronous invoked Operation
                OperationResult result = apiInstance.GetOperationAsyncResult(idShortPath, handleId, content);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.GetOperationAsyncResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idShortPath** | **string**| IdShort path to the submodel element (dot-separated), in this case an operation | 
 **handleId** | **string**| The returned handle id of an operation’s asynchronous invocation used to request the current state of the operation’s execution (BASE64-URL-encoded) | 
 **content** | **string**|  | [optional] [default to normal]

### Return type

[**OperationResult**](OperationResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubmodel"></a>
# **GetSubmodel**
> Submodel GetSubmodel (string level = null, string content = null, string extent = null)

Returns the Submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubmodelExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var level = level_example;  // string | Determines the structural depth of the respective resource content (optional)  (default to deep)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)
            var extent = extent_example;  // string | Determines to which extent the resource is being serialized (optional) 

            try
            {
                // Returns the Submodel
                Submodel result = apiInstance.GetSubmodel(level, content, extent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.GetSubmodel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **level** | **string**| Determines the structural depth of the respective resource content | [optional] [default to deep]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]
 **extent** | **string**| Determines to which extent the resource is being serialized | [optional] 

### Return type

[**Submodel**](Submodel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubmodelelementbypath"></a>
# **GetSubmodelElementByPath**
> SubmodelElement GetSubmodelElementByPath (string idShortPath, string level = null, string content = null, string extent = null)

Returns a specific submodel element from the Submodel at a specified path

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubmodelElementByPathExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var idShortPath = idShortPath_example;  // string | IdShort path to the submodel element (dot-separated)
            var level = level_example;  // string | Determines the structural depth of the respective resource content (optional)  (default to deep)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)
            var extent = extent_example;  // string | Determines to which extent the resource is being serialized (optional) 

            try
            {
                // Returns a specific submodel element from the Submodel at a specified path
                SubmodelElement result = apiInstance.GetSubmodelElementByPath(idShortPath, level, content, extent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.GetSubmodelElementByPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idShortPath** | **string**| IdShort path to the submodel element (dot-separated) | 
 **level** | **string**| Determines the structural depth of the respective resource content | [optional] [default to deep]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]
 **extent** | **string**| Determines to which extent the resource is being serialized | [optional] 

### Return type

[**SubmodelElement**](SubmodelElement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="invokeoperation"></a>
# **InvokeOperation**
> OperationResult InvokeOperation (OperationRequest body, string idShortPath, bool? async = null, string content = null)

Synchronously or asynchronously invokes an Operation at a specified path

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvokeOperationExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var body = new OperationRequest(); // OperationRequest | Operation request object
            var idShortPath = idShortPath_example;  // string | IdShort path to the submodel element (dot-separated), in this case an operation
            var async = true;  // bool? | Determines whether an operation invocation is performed asynchronously or synchronously (optional)  (default to false)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)

            try
            {
                // Synchronously or asynchronously invokes an Operation at a specified path
                OperationResult result = apiInstance.InvokeOperation(body, idShortPath, async, content);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.InvokeOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OperationRequest**](OperationRequest.md)| Operation request object | 
 **idShortPath** | **string**| IdShort path to the submodel element (dot-separated), in this case an operation | 
 **async** | **bool?**| Determines whether an operation invocation is performed asynchronously or synchronously | [optional] [default to false]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]

### Return type

[**OperationResult**](OperationResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsubmodelelement"></a>
# **PostSubmodelElement**
> SubmodelElement PostSubmodelElement (SubmodelElement body, string level = null, string content = null, string extent = null)

Creates a new submodel element

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSubmodelElementExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var body = new SubmodelElement(); // SubmodelElement | Requested submodel element
            var level = level_example;  // string | Determines the structural depth of the respective resource content (optional)  (default to deep)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)
            var extent = extent_example;  // string | Determines to which extent the resource is being serialized (optional) 

            try
            {
                // Creates a new submodel element
                SubmodelElement result = apiInstance.PostSubmodelElement(body, level, content, extent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.PostSubmodelElement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmodelElement**](SubmodelElement.md)| Requested submodel element | 
 **level** | **string**| Determines the structural depth of the respective resource content | [optional] [default to deep]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]
 **extent** | **string**| Determines to which extent the resource is being serialized | [optional] 

### Return type

[**SubmodelElement**](SubmodelElement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postsubmodelelementbypath"></a>
# **PostSubmodelElementByPath**
> SubmodelElement PostSubmodelElementByPath (SubmodelElement body, string idShortPath, string level = null, string content = null, string extent = null)

Creates a new submodel element at a specified path within submodel elements hierarchy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSubmodelElementByPathExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var body = new SubmodelElement(); // SubmodelElement | Requested submodel element
            var idShortPath = idShortPath_example;  // string | IdShort path to the submodel element (dot-separated)
            var level = level_example;  // string | Determines the structural depth of the respective resource content (optional)  (default to deep)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)
            var extent = extent_example;  // string | Determines to which extent the resource is being serialized (optional) 

            try
            {
                // Creates a new submodel element at a specified path within submodel elements hierarchy
                SubmodelElement result = apiInstance.PostSubmodelElementByPath(body, idShortPath, level, content, extent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.PostSubmodelElementByPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmodelElement**](SubmodelElement.md)| Requested submodel element | 
 **idShortPath** | **string**| IdShort path to the submodel element (dot-separated) | 
 **level** | **string**| Determines the structural depth of the respective resource content | [optional] [default to deep]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]
 **extent** | **string**| Determines to which extent the resource is being serialized | [optional] 

### Return type

[**SubmodelElement**](SubmodelElement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putsubmodel"></a>
# **PutSubmodel**
> void PutSubmodel (Submodel body, string level = null, string content = null, string extent = null)

Updates the Submodel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutSubmodelExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var body = new Submodel(); // Submodel | Submodel object
            var level = level_example;  // string | Determines the structural depth of the respective resource content (optional)  (default to deep)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)
            var extent = extent_example;  // string | Determines to which extent the resource is being serialized (optional) 

            try
            {
                // Updates the Submodel
                apiInstance.PutSubmodel(body, level, content, extent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.PutSubmodel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Submodel**](Submodel.md)| Submodel object | 
 **level** | **string**| Determines the structural depth of the respective resource content | [optional] [default to deep]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]
 **extent** | **string**| Determines to which extent the resource is being serialized | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putsubmodelelementbypath"></a>
# **PutSubmodelElementByPath**
> void PutSubmodelElementByPath (SubmodelElement body, string idShortPath, string level = null, string content = null, string extent = null)

Updates an existing submodel element at a specified path within submodel elements hierarchy

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutSubmodelElementByPathExample
    {
        public void main()
        {
            var apiInstance = new SubmodelInterfaceApi();
            var body = new SubmodelElement(); // SubmodelElement | Requested submodel element
            var idShortPath = idShortPath_example;  // string | IdShort path to the submodel element (dot-separated)
            var level = level_example;  // string | Determines the structural depth of the respective resource content (optional)  (default to deep)
            var content = content_example;  // string | Determines the request or response kind of the resource (optional)  (default to normal)
            var extent = extent_example;  // string | Determines to which extent the resource is being serialized (optional) 

            try
            {
                // Updates an existing submodel element at a specified path within submodel elements hierarchy
                apiInstance.PutSubmodelElementByPath(body, idShortPath, level, content, extent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubmodelInterfaceApi.PutSubmodelElementByPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubmodelElement**](SubmodelElement.md)| Requested submodel element | 
 **idShortPath** | **string**| IdShort path to the submodel element (dot-separated) | 
 **level** | **string**| Determines the structural depth of the respective resource content | [optional] [default to deep]
 **content** | **string**| Determines the request or response kind of the resource | [optional] [default to normal]
 **extent** | **string**| Determines to which extent the resource is being serialized | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
