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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines EntityType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityType
    {
        /// <summary>
        /// Enum CoManagedEntity for value: CoManagedEntity
        /// </summary>
        [EnumMember(Value = "CoManagedEntity")]
        CoManagedEntity = 1,
        /// <summary>
        /// Enum SelfManagedEntity for value: SelfManagedEntity
        /// </summary>
        [EnumMember(Value = "SelfManagedEntity")]
        SelfManagedEntity = 2    }
}
