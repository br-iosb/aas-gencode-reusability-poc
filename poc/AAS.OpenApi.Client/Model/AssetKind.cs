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
using SwaggerDateConverter = AAS.OpenApi.Client.Client.SwaggerDateConverter;

namespace AAS.OpenApi.Client.Model
{
    /// <summary>
    /// Defines AssetKind
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum AssetKind
    {
        /// <summary>
        /// Enum Type for value: Type
        /// </summary>
        [EnumMember(Value = "Type")]
        Type = 1,
        /// <summary>
        /// Enum Instance for value: Instance
        /// </summary>
        [EnumMember(Value = "Instance")]
        Instance = 2    }
}
