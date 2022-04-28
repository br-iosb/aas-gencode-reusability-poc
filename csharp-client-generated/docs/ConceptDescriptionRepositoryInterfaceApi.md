# IO.Swagger.Api.ConceptDescriptionRepositoryInterfaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteConceptDescriptionById**](ConceptDescriptionRepositoryInterfaceApi.md#deleteconceptdescriptionbyid) | **DELETE** /concept-descriptions/{cdIdentifier} | Deletes a Concept Description
[**GetAllConceptDescriptions**](ConceptDescriptionRepositoryInterfaceApi.md#getallconceptdescriptions) | **GET** /concept-descriptions | Returns all Concept Descriptions
[**GetConceptDescriptionById**](ConceptDescriptionRepositoryInterfaceApi.md#getconceptdescriptionbyid) | **GET** /concept-descriptions/{cdIdentifier} | Returns a specific Concept Description
[**PostConceptDescription**](ConceptDescriptionRepositoryInterfaceApi.md#postconceptdescription) | **POST** /concept-descriptions | Creates a new Concept Description
[**PutConceptDescriptionById**](ConceptDescriptionRepositoryInterfaceApi.md#putconceptdescriptionbyid) | **PUT** /concept-descriptions/{cdIdentifier} | Updates an existing Concept Description

<a name="deleteconceptdescriptionbyid"></a>
# **DeleteConceptDescriptionById**
> void DeleteConceptDescriptionById (string cdIdentifier)

Deletes a Concept Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteConceptDescriptionByIdExample
    {
        public void main()
        {
            var apiInstance = new ConceptDescriptionRepositoryInterfaceApi();
            var cdIdentifier = cdIdentifier_example;  // string | The Concept Description’s unique id (BASE64-URL-encoded)

            try
            {
                // Deletes a Concept Description
                apiInstance.DeleteConceptDescriptionById(cdIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConceptDescriptionRepositoryInterfaceApi.DeleteConceptDescriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cdIdentifier** | **string**| The Concept Description’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallconceptdescriptions"></a>
# **GetAllConceptDescriptions**
> List<ConceptDescription> GetAllConceptDescriptions (string idShort = null, string isCaseOf = null, string dataSpecificationRef = null)

Returns all Concept Descriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllConceptDescriptionsExample
    {
        public void main()
        {
            var apiInstance = new ConceptDescriptionRepositoryInterfaceApi();
            var idShort = idShort_example;  // string | The Concept Description’s IdShort (optional) 
            var isCaseOf = isCaseOf_example;  // string | IsCaseOf reference (BASE64-URL-encoded) (optional) 
            var dataSpecificationRef = dataSpecificationRef_example;  // string | DataSpecification reference (BASE64-URL-encoded) (optional) 

            try
            {
                // Returns all Concept Descriptions
                List&lt;ConceptDescription&gt; result = apiInstance.GetAllConceptDescriptions(idShort, isCaseOf, dataSpecificationRef);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConceptDescriptionRepositoryInterfaceApi.GetAllConceptDescriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idShort** | **string**| The Concept Description’s IdShort | [optional] 
 **isCaseOf** | **string**| IsCaseOf reference (BASE64-URL-encoded) | [optional] 
 **dataSpecificationRef** | **string**| DataSpecification reference (BASE64-URL-encoded) | [optional] 

### Return type

[**List<ConceptDescription>**](ConceptDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getconceptdescriptionbyid"></a>
# **GetConceptDescriptionById**
> ConceptDescription GetConceptDescriptionById (string cdIdentifier)

Returns a specific Concept Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConceptDescriptionByIdExample
    {
        public void main()
        {
            var apiInstance = new ConceptDescriptionRepositoryInterfaceApi();
            var cdIdentifier = cdIdentifier_example;  // string | The Concept Description’s unique id (BASE64-URL-encoded)

            try
            {
                // Returns a specific Concept Description
                ConceptDescription result = apiInstance.GetConceptDescriptionById(cdIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConceptDescriptionRepositoryInterfaceApi.GetConceptDescriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cdIdentifier** | **string**| The Concept Description’s unique id (BASE64-URL-encoded) | 

### Return type

[**ConceptDescription**](ConceptDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postconceptdescription"></a>
# **PostConceptDescription**
> ConceptDescription PostConceptDescription (ConceptDescription body)

Creates a new Concept Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostConceptDescriptionExample
    {
        public void main()
        {
            var apiInstance = new ConceptDescriptionRepositoryInterfaceApi();
            var body = new ConceptDescription(); // ConceptDescription | Concept Description object

            try
            {
                // Creates a new Concept Description
                ConceptDescription result = apiInstance.PostConceptDescription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConceptDescriptionRepositoryInterfaceApi.PostConceptDescription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConceptDescription**](ConceptDescription.md)| Concept Description object | 

### Return type

[**ConceptDescription**](ConceptDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putconceptdescriptionbyid"></a>
# **PutConceptDescriptionById**
> void PutConceptDescriptionById (ConceptDescription body, string cdIdentifier)

Updates an existing Concept Description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutConceptDescriptionByIdExample
    {
        public void main()
        {
            var apiInstance = new ConceptDescriptionRepositoryInterfaceApi();
            var body = new ConceptDescription(); // ConceptDescription | Concept Description object
            var cdIdentifier = cdIdentifier_example;  // string | The Concept Description’s unique id (BASE64-URL-encoded)

            try
            {
                // Updates an existing Concept Description
                apiInstance.PutConceptDescriptionById(body, cdIdentifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConceptDescriptionRepositoryInterfaceApi.PutConceptDescriptionById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConceptDescription**](ConceptDescription.md)| Concept Description object | 
 **cdIdentifier** | **string**| The Concept Description’s unique id (BASE64-URL-encoded) | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
