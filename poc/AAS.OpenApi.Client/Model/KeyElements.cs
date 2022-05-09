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
    /// Defines KeyElements
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum KeyElements
    {
        /// <summary>
        /// Enum AssetAdministrationShell for value: AssetAdministrationShell
        /// </summary>
        [EnumMember(Value = "AssetAdministrationShell")]
        AssetAdministrationShell = 1,
        /// <summary>
        /// Enum AccessPermissionRule for value: AccessPermissionRule
        /// </summary>
        [EnumMember(Value = "AccessPermissionRule")]
        AccessPermissionRule = 2,
        /// <summary>
        /// Enum ConceptDescription for value: ConceptDescription
        /// </summary>
        [EnumMember(Value = "ConceptDescription")]
        ConceptDescription = 3,
        /// <summary>
        /// Enum Submodel for value: Submodel
        /// </summary>
        [EnumMember(Value = "Submodel")]
        Submodel = 4,
        /// <summary>
        /// Enum AnnotatedRelationshipElement for value: AnnotatedRelationshipElement
        /// </summary>
        [EnumMember(Value = "AnnotatedRelationshipElement")]
        AnnotatedRelationshipElement = 5,
        /// <summary>
        /// Enum BasicEvent for value: BasicEvent
        /// </summary>
        [EnumMember(Value = "BasicEvent")]
        BasicEvent = 6,
        /// <summary>
        /// Enum Blob for value: Blob
        /// </summary>
        [EnumMember(Value = "Blob")]
        Blob = 7,
        /// <summary>
        /// Enum Capability for value: Capability
        /// </summary>
        [EnumMember(Value = "Capability")]
        Capability = 8,
        /// <summary>
        /// Enum DataElement for value: DataElement
        /// </summary>
        [EnumMember(Value = "DataElement")]
        DataElement = 9,
        /// <summary>
        /// Enum File for value: File
        /// </summary>
        [EnumMember(Value = "File")]
        File = 10,
        /// <summary>
        /// Enum Entity for value: Entity
        /// </summary>
        [EnumMember(Value = "Entity")]
        Entity = 11,
        /// <summary>
        /// Enum Event for value: Event
        /// </summary>
        [EnumMember(Value = "Event")]
        Event = 12,
        /// <summary>
        /// Enum MultiLanguageProperty for value: MultiLanguageProperty
        /// </summary>
        [EnumMember(Value = "MultiLanguageProperty")]
        MultiLanguageProperty = 13,
        /// <summary>
        /// Enum Operation for value: Operation
        /// </summary>
        [EnumMember(Value = "Operation")]
        Operation = 14,
        /// <summary>
        /// Enum Property for value: Property
        /// </summary>
        [EnumMember(Value = "Property")]
        Property = 15,
        /// <summary>
        /// Enum Range for value: Range
        /// </summary>
        [EnumMember(Value = "Range")]
        Range = 16,
        /// <summary>
        /// Enum ReferenceElement for value: ReferenceElement
        /// </summary>
        [EnumMember(Value = "ReferenceElement")]
        ReferenceElement = 17,
        /// <summary>
        /// Enum RelationshipElement for value: RelationshipElement
        /// </summary>
        [EnumMember(Value = "RelationshipElement")]
        RelationshipElement = 18,
        /// <summary>
        /// Enum SubmodelElement for value: SubmodelElement
        /// </summary>
        [EnumMember(Value = "SubmodelElement")]
        SubmodelElement = 19,
        /// <summary>
        /// Enum SubmodelElementList for value: SubmodelElementList
        /// </summary>
        [EnumMember(Value = "SubmodelElementList")]
        SubmodelElementList = 20,
        /// <summary>
        /// Enum SubmodelElementStruct for value: SubmodelElementStruct
        /// </summary>
        [EnumMember(Value = "SubmodelElementStruct")]
        SubmodelElementStruct = 21,
        /// <summary>
        /// Enum View for value: View
        /// </summary>
        [EnumMember(Value = "View")]
        View = 22,
        /// <summary>
        /// Enum FragmentReference for value: FragmentReference
        /// </summary>
        [EnumMember(Value = "FragmentReference")]
        FragmentReference = 23    }
}
