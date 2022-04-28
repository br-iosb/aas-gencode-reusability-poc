# IO.Swagger.Api.DescriptorInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDescriptor**](DescriptorInterfaceApi.md#getdescriptor) | **GET** /descriptor | Returns the self-describing information of a network resource (Descriptor)

<a name="getdescriptor"></a>
# **GetDescriptor**
> List<Descriptor> GetDescriptor ()

Returns the self-describing information of a network resource (Descriptor)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDescriptorExample
    {
        public void main()
        {
            var apiInstance = new DescriptorInterfaceApi();

            try
            {
                // Returns the self-describing information of a network resource (Descriptor)
                List&lt;Descriptor&gt; result = apiInstance.GetDescriptor();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DescriptorInterfaceApi.GetDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Descriptor>**](Descriptor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
