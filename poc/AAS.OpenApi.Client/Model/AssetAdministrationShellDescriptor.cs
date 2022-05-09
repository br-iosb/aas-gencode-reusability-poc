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
    /// AssetAdministrationShellDescriptor
    /// </summary>
    [DataContract]
        public partial class AssetAdministrationShellDescriptor : Descriptor,  IEquatable<AssetAdministrationShellDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAdministrationShellDescriptor" /> class.
        /// </summary>
        /// <param name="administration">administration.</param>
        /// <param name="description">description.</param>
        /// <param name="globalAssetId">globalAssetId.</param>
        /// <param name="idShort">idShort.</param>
        /// <param name="identification">identification (required).</param>
        /// <param name="specificAssetIds">specificAssetIds.</param>
        /// <param name="submodelDescriptors">submodelDescriptors.</param>
        public AssetAdministrationShellDescriptor(AdministrativeInformation administration = default(AdministrativeInformation), List<LangString> description = default(List<LangString>), Reference globalAssetId = default(Reference), string idShort = default(string), string identification = default(string), List<IdentifierKeyValuePair> specificAssetIds = default(List<IdentifierKeyValuePair>), List<SubmodelDescriptor> submodelDescriptors = default(List<SubmodelDescriptor>), List<Endpoint> endpoints = default(List<Endpoint>)) : base(endpoints)
        {
            // to ensure "identification" is required (not null)
            if (identification == null)
            {
                throw new InvalidDataException("identification is a required property for AssetAdministrationShellDescriptor and cannot be null");
            }
            else
            {
                this.Identification = identification;
            }
            this.Administration = administration;
            this.Description = description;
            this.GlobalAssetId = globalAssetId;
            this.IdShort = idShort;
            this.SpecificAssetIds = specificAssetIds;
            this.SubmodelDescriptors = submodelDescriptors;
        }
        
        /// <summary>
        /// Gets or Sets Administration
        /// </summary>
        [DataMember(Name="administration", EmitDefaultValue=false)]
        public AdministrativeInformation Administration { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public List<LangString> Description { get; set; }

        /// <summary>
        /// Gets or Sets GlobalAssetId
        /// </summary>
        [DataMember(Name="globalAssetId", EmitDefaultValue=false)]
        public Reference GlobalAssetId { get; set; }

        /// <summary>
        /// Gets or Sets IdShort
        /// </summary>
        [DataMember(Name="idShort", EmitDefaultValue=false)]
        public string IdShort { get; set; }

        /// <summary>
        /// Gets or Sets Identification
        /// </summary>
        [DataMember(Name="identification", EmitDefaultValue=false)]
        public string Identification { get; set; }

        /// <summary>
        /// Gets or Sets SpecificAssetIds
        /// </summary>
        [DataMember(Name="specificAssetIds", EmitDefaultValue=false)]
        public List<IdentifierKeyValuePair> SpecificAssetIds { get; set; }

        /// <summary>
        /// Gets or Sets SubmodelDescriptors
        /// </summary>
        [DataMember(Name="submodelDescriptors", EmitDefaultValue=false)]
        public List<SubmodelDescriptor> SubmodelDescriptors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetAdministrationShellDescriptor {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Administration: ").Append(Administration).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GlobalAssetId: ").Append(GlobalAssetId).Append("\n");
            sb.Append("  IdShort: ").Append(IdShort).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  SpecificAssetIds: ").Append(SpecificAssetIds).Append("\n");
            sb.Append("  SubmodelDescriptors: ").Append(SubmodelDescriptors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetAdministrationShellDescriptor);
        }

        /// <summary>
        /// Returns true if AssetAdministrationShellDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetAdministrationShellDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetAdministrationShellDescriptor input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Administration == input.Administration ||
                    (this.Administration != null &&
                    this.Administration.Equals(input.Administration))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && base.Equals(input) && 
                (
                    this.GlobalAssetId == input.GlobalAssetId ||
                    (this.GlobalAssetId != null &&
                    this.GlobalAssetId.Equals(input.GlobalAssetId))
                ) && base.Equals(input) && 
                (
                    this.IdShort == input.IdShort ||
                    (this.IdShort != null &&
                    this.IdShort.Equals(input.IdShort))
                ) && base.Equals(input) && 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
                ) && base.Equals(input) && 
                (
                    this.SpecificAssetIds == input.SpecificAssetIds ||
                    this.SpecificAssetIds != null &&
                    input.SpecificAssetIds != null &&
                    this.SpecificAssetIds.SequenceEqual(input.SpecificAssetIds)
                ) && base.Equals(input) && 
                (
                    this.SubmodelDescriptors == input.SubmodelDescriptors ||
                    this.SubmodelDescriptors != null &&
                    input.SubmodelDescriptors != null &&
                    this.SubmodelDescriptors.SequenceEqual(input.SubmodelDescriptors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Administration != null)
                    hashCode = hashCode * 59 + this.Administration.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GlobalAssetId != null)
                    hashCode = hashCode * 59 + this.GlobalAssetId.GetHashCode();
                if (this.IdShort != null)
                    hashCode = hashCode * 59 + this.IdShort.GetHashCode();
                if (this.Identification != null)
                    hashCode = hashCode * 59 + this.Identification.GetHashCode();
                if (this.SpecificAssetIds != null)
                    hashCode = hashCode * 59 + this.SpecificAssetIds.GetHashCode();
                if (this.SubmodelDescriptors != null)
                    hashCode = hashCode * 59 + this.SubmodelDescriptors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
