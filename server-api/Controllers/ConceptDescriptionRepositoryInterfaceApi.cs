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
using AAS.Server.Attributes;

using Microsoft.AspNetCore.Authorization;
using AAS.Server.Models;

namespace AAS.Server.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ConceptDescriptionRepositoryInterfaceApiController : ControllerBase
    { 
        /// <summary>
        /// Deletes a Concept Description
        /// </summary>
        /// <param name="cdIdentifier">The Concept Description’s unique id (BASE64-URL-encoded)</param>
        /// <response code="204">Concept Description deleted successfully</response>
        [HttpDelete]
        [Route("/concept-descriptions/{cdIdentifier}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteConceptDescriptionById")]
        public virtual IActionResult DeleteConceptDescriptionById([FromRoute][Required]string cdIdentifier)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all Concept Descriptions
        /// </summary>
        /// <param name="idShort">The Concept Description’s IdShort</param>
        /// <param name="isCaseOf">IsCaseOf reference (BASE64-URL-encoded)</param>
        /// <param name="dataSpecificationRef">DataSpecification reference (BASE64-URL-encoded)</param>
        /// <response code="200">Requested Concept Descriptions</response>
        [HttpGet]
        [Route("/concept-descriptions")]
        [ValidateModelState]
        [SwaggerOperation("GetAllConceptDescriptions")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ConceptDescription>), description: "Requested Concept Descriptions")]
        public virtual IActionResult GetAllConceptDescriptions([FromQuery]string idShort, [FromQuery]string isCaseOf, [FromQuery]string dataSpecificationRef)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ConceptDescription>));
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ConceptDescription>>(exampleJson)
                        : default(List<ConceptDescription>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Returns a specific Concept Description
        /// </summary>
        /// <param name="cdIdentifier">The Concept Description’s unique id (BASE64-URL-encoded)</param>
        /// <response code="200">Requested Concept Description</response>
        [HttpGet]
        [Route("/concept-descriptions/{cdIdentifier}")]
        [ValidateModelState]
        [SwaggerOperation("GetConceptDescriptionById")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConceptDescription), description: "Requested Concept Description")]
        public virtual IActionResult GetConceptDescriptionById([FromRoute][Required]string cdIdentifier)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConceptDescription));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ConceptDescription>(exampleJson)
                        : default(ConceptDescription);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Creates a new Concept Description
        /// </summary>
        /// <param name="body">Concept Description object</param>
        /// <response code="201">Concept Description created successfully</response>
        [HttpPost]
        [Route("/concept-descriptions")]
        [ValidateModelState]
        [SwaggerOperation("PostConceptDescription")]
        [SwaggerResponse(statusCode: 201, type: typeof(ConceptDescription), description: "Concept Description created successfully")]
        public virtual IActionResult PostConceptDescription([FromBody]ConceptDescription body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(ConceptDescription));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ConceptDescription>(exampleJson)
                        : default(ConceptDescription);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates an existing Concept Description
        /// </summary>
        /// <param name="body">Concept Description object</param>
        /// <param name="cdIdentifier">The Concept Description’s unique id (BASE64-URL-encoded)</param>
        /// <response code="204">Concept Description updated successfully</response>
        [HttpPut]
        [Route("/concept-descriptions/{cdIdentifier}")]
        [ValidateModelState]
        [SwaggerOperation("PutConceptDescriptionById")]
        public virtual IActionResult PutConceptDescriptionById([FromBody]ConceptDescription body, [FromRoute][Required]string cdIdentifier)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }
    }
}
