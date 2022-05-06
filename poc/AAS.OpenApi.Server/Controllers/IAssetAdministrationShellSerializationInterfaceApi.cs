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
    public interface IAssetAdministrationShellSerializationInterfaceApiController
    { 
        /// <summary>
        /// Returns an appropriate serialization based on the specified format (see SerializationFormat)
        /// </summary>
        
        /// <param name="aasIds">The Asset Administration Shells&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="submodelIds">The Submodels&#x27; unique ids (BASE64-URL-encoded)</param>
        /// <param name="includeConceptDescriptions">Include Concept Descriptions?</param>
        /// <response code="200">Requested serialization based on SerializationFormat</response>
        IActionResult GenerateSerializationByIds([FromQuery][Required()]List<string> aasIds, [FromQuery][Required()]List<string> submodelIds, [FromQuery][Required()]bool? includeConceptDescriptions);
    }
}
