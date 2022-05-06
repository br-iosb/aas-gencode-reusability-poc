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
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using AAS.OpenApi.Server.Models;

namespace AAS.OpenApi.Server.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public interface ISubmodelInterfaceApiController
    { 
        /// <summary>
        /// Deletes a submodel element at a specified path within the submodel elements hierarchy
        /// </summary>
        
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <response code="204">Submodel element deleted successfully</response>
        IActionResult DeleteSubmodelElementByPath([FromRoute][Required]string idShortPath);

        /// <summary>
        /// Returns all submodel elements including their hierarchy
        /// </summary>
        
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="200">List of found submodel elements</response>
        IActionResult GetAllSubmodelElements([FromQuery]string level, [FromQuery]string content, [FromQuery]string extent);

        /// <summary>
        /// Returns the Operation result of an asynchronous invoked Operation
        /// </summary>
        
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated), in this case an operation</param>
        /// <param name="handleId">The returned handle id of an operation’s asynchronous invocation used to request the current state of the operation’s execution (BASE64-URL-encoded)</param>
        /// <param name="content"></param>
        /// <response code="200">Operation result object</response>
        IActionResult GetOperationAsyncResult([FromRoute][Required]string idShortPath, [FromRoute][Required]string handleId, [FromQuery]string content);

        /// <summary>
        /// Returns the Submodel
        /// </summary>
        
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="200">Requested Submodel</response>
        IActionResult GetSubmodel([FromQuery]string level, [FromQuery]string content, [FromQuery]string extent);

        /// <summary>
        /// Returns a specific submodel element from the Submodel at a specified path
        /// </summary>
        
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="200">Requested submodel element</response>
        IActionResult GetSubmodelElementByPath([FromRoute][Required]string idShortPath, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent);

        /// <summary>
        /// Synchronously or asynchronously invokes an Operation at a specified path
        /// </summary>
        
        /// <param name="body">Operation request object</param>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated), in this case an operation</param>
        /// <param name="_async">Determines whether an operation invocation is performed asynchronously or synchronously</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <response code="200">Operation result object</response>
        IActionResult InvokeOperation([FromBody]OperationRequest body, [FromRoute][Required]string idShortPath, [FromQuery]bool? _async, [FromQuery]string content);

        /// <summary>
        /// Creates a new submodel element
        /// </summary>
        
        /// <param name="body">Requested submodel element</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="201">Submodel element created successfully</response>
        IActionResult PostSubmodelElement([FromBody]SubmodelElement body, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent);

        /// <summary>
        /// Creates a new submodel element at a specified path within submodel elements hierarchy
        /// </summary>
        
        /// <param name="body">Requested submodel element</param>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="201">Submodel element created successfully</response>
        IActionResult PostSubmodelElementByPath([FromBody]SubmodelElement body, [FromRoute][Required]string idShortPath, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent);

        /// <summary>
        /// Updates the Submodel
        /// </summary>
        
        /// <param name="body">Submodel object</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="204">Submodel updated successfully</response>
        IActionResult PutSubmodel([FromBody]Submodel body, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent);

        /// <summary>
        /// Updates an existing submodel element at a specified path within submodel elements hierarchy
        /// </summary>
        
        /// <param name="body">Requested submodel element</param>
        /// <param name="idShortPath">IdShort path to the submodel element (dot-separated)</param>
        /// <param name="level">Determines the structural depth of the respective resource content</param>
        /// <param name="content">Determines the request or response kind of the resource</param>
        /// <param name="extent">Determines to which extent the resource is being serialized</param>
        /// <response code="204">Submodel element updated successfully</response>
        IActionResult PutSubmodelElementByPath([FromBody]SubmodelElement body, [FromRoute][Required]string idShortPath, [FromQuery]string level, [FromQuery]string content, [FromQuery]string extent);
    }
}