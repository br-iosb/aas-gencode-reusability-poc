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
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SubmodelRepositoryInterfaceApiController : ControllerBase
    { 
        /// <summary>
        /// Deletes a Submodel
        /// </summary>
        /// <param name="submodelIdentifier">The Submodel’s unique id (BASE64-URL-encoded)</param>
        /// <response code="204">Submodel deleted successfully</response>
        [HttpDelete]
        [Route("/submodels/{submodelIdentifier}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteSubmodelById")]
        public virtual IActionResult DeleteSubmodelById([FromRoute][Required]string submodelIdentifier)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all Submodels
        /// </summary>
        /// <param name="semanticId">The value of the semantic id reference (BASE64-URL-encoded)</param>
        /// <param name="idShort">The Submodel’s idShort</param>
        /// <response code="200">Requested Submodels</response>
        [HttpGet]
        [Route("/submodels")]
        [ValidateModelState]
        [SwaggerOperation("GetAllSubmodels")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Submodel>), description: "Requested Submodels")]
        public virtual IActionResult GetAllSubmodels([FromQuery]string semanticId, [FromQuery]string idShort)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Submodel>));
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Submodel>>(exampleJson)
                        : default(List<Submodel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns a specific Submodel
        /// </summary>
        /// <param name="submodelIdentifier">The Submodel’s unique id (BASE64-URL-encoded)</param>
        /// <response code="200">Requested Submodel</response>
        [HttpGet]
        [Route("/submodels/{submodelIdentifier}")]
        [ValidateModelState]
        [SwaggerOperation("GetSubmodelById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Submodel), description: "Requested Submodel")]
        public virtual IActionResult GetSubmodelById([FromRoute][Required]string submodelIdentifier)
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
        /// Creates a new Submodel
        /// </summary>
        /// <param name="body">Submodel object</param>
        /// <response code="201">Submodel created successfully</response>
        [HttpPost]
        [Route("/submodels")]
        [ValidateModelState]
        [SwaggerOperation("PostSubmodel")]
        [SwaggerResponse(statusCode: 201, type: typeof(Submodel), description: "Submodel created successfully")]
        public virtual IActionResult PostSubmodel([FromBody]Submodel body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(Submodel));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Submodel>(exampleJson)
                        : default(Submodel);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Creates a new or updates an existing Submodel
        /// </summary>
        /// <param name="body">Submodel object</param>
        /// <param name="submodelIdentifier">The Submodel’s unique id (BASE64-URL-encoded)</param>
        /// <response code="201">Submodel created successfully</response>
        /// <response code="204">Submodel updated successfully</response>
        [HttpPut]
        [Route("/submodels/{submodelIdentifier}")]
        [ValidateModelState]
        [SwaggerOperation("PutSubmodelById")]
        [SwaggerResponse(statusCode: 201, type: typeof(Submodel), description: "Submodel created successfully")]
        public virtual IActionResult PutSubmodelById([FromBody]Submodel body, [FromRoute][Required]string submodelIdentifier)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(Submodel));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Submodel>(exampleJson)
                        : default(Submodel);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
