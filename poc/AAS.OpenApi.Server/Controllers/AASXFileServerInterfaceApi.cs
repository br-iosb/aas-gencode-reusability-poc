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
    public class AASXFileServerInterfaceApiController : ControllerBase, IAASXFileServerInterfaceApiController
    { 
        /// <summary>
        /// Deletes a specific AASX package from the server
        /// </summary>
        /// <param name="packageId">The Package Id (BASE64-URL-encoded)</param>
        /// <response code="204">Deleted successfully</response>
        [HttpDelete]
        [Route("/packages/{packageId}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteAASXByPackageId")]
        public virtual IActionResult DeleteAASXByPackageId([FromRoute][Required]string packageId)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a specific AASX package from the server
        /// </summary>
        /// <param name="packageId">The package Id (BASE64-URL-encoded)</param>
        /// <response code="200">Requested AASX package</response>
        [HttpGet]
        [Route("/packages/{packageId}")]
        [ValidateModelState]
        [SwaggerOperation("GetAASXByPackageId")]
        [SwaggerResponse(statusCode: 200, type: typeof(byte[]), description: "Requested AASX package")]
        public virtual IActionResult GetAASXByPackageId([FromRoute][Required]string packageId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(byte[]));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<byte[]>(exampleJson)
                        : default(byte[]);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns a list of available AASX packages at the server
        /// </summary>
        /// <param name="aasId">The Asset Administration Shell’s unique id (BASE64-URL-encoded)</param>
        /// <response code="200">Requested package list</response>
        [HttpGet]
        [Route("/packages")]
        [ValidateModelState]
        [SwaggerOperation("GetAllAASXPackageIds")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<PackageDescription>), description: "Requested package list")]
        public virtual IActionResult GetAllAASXPackageIds([FromQuery]string aasId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<PackageDescription>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"aasIds\" : [ \"aasIds\", \"aasIds\" ],\n  \"packageId\" : \"packageId\"\n}, {\n  \"aasIds\" : [ \"aasIds\", \"aasIds\" ],\n  \"packageId\" : \"packageId\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<PackageDescription>>(exampleJson)
                        : default(List<PackageDescription>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }


    }
}