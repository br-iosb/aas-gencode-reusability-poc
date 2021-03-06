/*
 * DotAAS Part 2 | HTTP/REST | Entire Interface Collection
 *
 * The entire interface collection as part of Details of the Asset Administration Shell Part 2
 *
 * OpenAPI spec version: V1.0RC01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using AAS.OpenApi.Server.Attributes;

using Microsoft.AspNetCore.Authorization;
using AAS.OpenApi.Server.Models;

namespace AAS.OpenApi.Server.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SubmodelInterfaceApiController : ControllerBase, ISubmodelInterfaceApiController
    { 
        /// <summary>
        /// Deletes a submodel element at a specified path within the submodel elements hierarchy
        /// </summary>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <response code="204">Submodel element deleted successfully</response>
        [HttpDelete]
        [Route("/submodel/submodel-elements/{idShortPath}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteSubmodelElementByPath")]
        public virtual IActionResult DeleteSubmodelElementByPath([FromRoute][Required]string idShortPath)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all submodel elements including their hierarchy
        /// </summary>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="200">List of found submodel elements</response>
        [HttpGet]
        [Route("/submodel/submodel-elements")]
        [ValidateModelState]
        [SwaggerOperation("GetAllSubmodelElements")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SubmodelElement>), description: "List of found submodel elements")]
        public virtual IActionResult GetAllSubmodelElements([FromQuery]string level, [FromQuery]string content, [FromQuery]string extent)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SubmodelElement>));
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<SubmodelElement>>(exampleJson)
                        : default(List<SubmodelElement>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns the Operation result of an asynchronous invoked Operation
        /// </summary>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated), in this case an operation</param>
        /// <param name="handleId">The returned handle id of an operation???s asynchronous invocation used to request the current state of the operation???s execution (BASE64-URL-encoded)</param>
        /// <param name="content"></param>
        /// <response code="200">Operation result object</response>
        [HttpGet]
        [Route("/submodel/submodel-elements/{idShortPath}/operation-results/{handleId}")]
        [ValidateModelState]
        [SwaggerOperation("GetOperationAsyncResult")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResult), description: "Operation result object")]
        public virtual IActionResult GetOperationAsyncResult([FromRoute][Required]string idShortPath, [FromRoute][Required]string handleId, [FromQuery]string content)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OperationResult));
            string exampleJson = null;
            exampleJson = "{\n  \"outputArguments\" : [ null, null ],\n  \"requestId\" : \"requestId\",\n  \"executionResult\" : {\n    \"success\" : true,\n    \"messages\" : [ {\n      \"code\" : \"code\",\n      \"messageType\" : \"Undefined\",\n      \"text\" : \"text\",\n      \"timestamp\" : \"timestamp\"\n    }, {\n      \"code\" : \"code\",\n      \"messageType\" : \"Undefined\",\n      \"text\" : \"text\",\n      \"timestamp\" : \"timestamp\"\n    } ]\n  },\n  \"executionState\" : \"Initiated\",\n  \"inoutputArguments\" : [ {\n    \"value\" : \"\"\n  }, {\n    \"value\" : \"\"\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OperationResult>(exampleJson)
                        : default(OperationResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns the Submodel
        /// </summary>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="200">Requested Submodel</response>
        [HttpGet]
        [Route("/submodel")]
        [ValidateModelState]
        [SwaggerOperation("GetSubmodel")]
        [SwaggerResponse(statusCode: 200, type: typeof(Submodel), description: "Requested Submodel")]
        public virtual IActionResult GetSubmodel([FromQuery]string level, [FromQuery]string content, [FromQuery]string extent)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Submodel));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Submodel>(exampleJson)
                        : default(Submodel);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns a specific submodel element from the Submodel at a specified path
        /// </summary>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="200">Requested submodel element</response>
        [HttpGet]
        [Route("/submodel/submodel-elements/{idShortPath}")]
        [ValidateModelState]
        [SwaggerOperation("GetSubmodelElementByPath")]
        [SwaggerResponse(statusCode: 200, type: typeof(SubmodelElement), description: "Requested submodel element")]
        public virtual IActionResult GetSubmodelElementByPath([FromRoute][Required]string idShortPath, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SubmodelElement));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SubmodelElement>(exampleJson)
                        : default(SubmodelElement);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Synchronously or asynchronously invokes an Operation at a specified path
        /// </summary>
        /// <param name="body">Operation request object</param>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated), in this case an operation</param>
        /// <param name="_async">Determines whether an operation invocation is performed asynchronously or synchronously</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <response code="200">Operation result object</response>
        [HttpPost]
        [Route("/submodel/submodel-elements/{idShortPath}/invoke")]
        [ValidateModelState]
        [SwaggerOperation("InvokeOperation")]
        [SwaggerResponse(statusCode: 200, type: typeof(OperationResult), description: "Operation result object")]
        public virtual IActionResult InvokeOperation([FromBody]OperationRequest body, [FromRoute][Required]string idShortPath, [FromQuery]bool? _async, [FromQuery]string content)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OperationResult));
            string exampleJson = null;
            exampleJson = "{\n  \"outputArguments\" : [ null, null ],\n  \"requestId\" : \"requestId\",\n  \"executionResult\" : {\n    \"success\" : true,\n    \"messages\" : [ {\n      \"code\" : \"code\",\n      \"messageType\" : \"Undefined\",\n      \"text\" : \"text\",\n      \"timestamp\" : \"timestamp\"\n    }, {\n      \"code\" : \"code\",\n      \"messageType\" : \"Undefined\",\n      \"text\" : \"text\",\n      \"timestamp\" : \"timestamp\"\n    } ]\n  },\n  \"executionState\" : \"Initiated\",\n  \"inoutputArguments\" : [ {\n    \"value\" : \"\"\n  }, {\n    \"value\" : \"\"\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<OperationResult>(exampleJson)
                        : default(OperationResult);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Creates a new submodel element
        /// </summary>
        /// <param name="body">Requested submodel element</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="201">Submodel element created successfully</response>
        [HttpPost]
        [Route("/submodel/submodel-elements")]
        [ValidateModelState]
        [SwaggerOperation("PostSubmodelElement")]
        [SwaggerResponse(statusCode: 201, type: typeof(SubmodelElement), description: "Submodel element created successfully")]
        public virtual IActionResult PostSubmodelElement([FromBody]SubmodelElement body, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(SubmodelElement));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SubmodelElement>(exampleJson)
                        : default(SubmodelElement);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Creates a new submodel element at a specified path within submodel elements hierarchy
        /// </summary>
        /// <param name="body">Requested submodel element</param>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="201">Submodel element created successfully</response>
        [HttpPost]
        [Route("/submodel/submodel-elements/{idShortPath}")]
        [ValidateModelState]
        [SwaggerOperation("PostSubmodelElementByPath")]
        [SwaggerResponse(statusCode: 201, type: typeof(SubmodelElement), description: "Submodel element created successfully")]
        public virtual IActionResult PostSubmodelElementByPath([FromBody]SubmodelElement body, [FromRoute][Required]string idShortPath, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(SubmodelElement));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SubmodelElement>(exampleJson)
                        : default(SubmodelElement);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates the Submodel
        /// </summary>
        /// <param name="body">Submodel object</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="204">Submodel updated successfully</response>
        [HttpPut]
        [Route("/submodel")]
        [ValidateModelState]
        [SwaggerOperation("PutSubmodel")]
        public virtual IActionResult PutSubmodel([FromBody]Submodel body, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing submodel element at a specified path within submodel elements hierarchy
        /// </summary>
        /// <param name="body">Requested submodel element</param>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="204">Submodel element updated successfully</response>
        [HttpPut]
        [Route("/submodel/submodel-elements/{idShortPath}")]
        [ValidateModelState]
        [SwaggerOperation("PutSubmodelElementByPath")]
        public virtual IActionResult PutSubmodelElementByPath([FromBody]SubmodelElement body, [FromRoute][Required]string idShortPath, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }
    }
}
