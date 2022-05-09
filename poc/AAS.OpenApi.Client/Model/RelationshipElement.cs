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
    /// RelationshipElement
    /// </summary>
    [DataContract]
        public partial class RelationshipElement : SubmodelElementAttributes,  IEquatable<RelationshipElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipElement" /> class.
        /// </summary>
        /// <param name="first">first (required).</param>
        /// <param name="second">second (required).</param>
        public RelationshipElement(Reference first = default(Reference), Reference second = default(Reference), List<EmbeddedDataSpecification> embeddedDataSpecifications = default(List<EmbeddedDataSpecification>), Reference semanticId = default(Reference), List<Constraint> qualifiers = default(List<Constraint>), ModelingKind kind = default(ModelingKind)) : base(embeddedDataSpecifications, semanticId, qualifiers, kind)
        {
            // to ensure "first" is required (not null)
            if (first == null)
            {
                throw new InvalidDataException("first is a required property for RelationshipElement and cannot be null");
            }
            else
            {
                this.First = first;
            }
            // to ensure "second" is required (not null)
            if (second == null)
            {
                throw new InvalidDataException("second is a required property for RelationshipElement and cannot be null");
            }
            else
            {
                this.Second = second;
            }
        }
        
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public Reference First { get; set; }

        /// <summary>
        /// Gets or Sets Second
        /// </summary>
        [DataMember(Name="second", EmitDefaultValue=false)]
        public Reference Second { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationshipElement {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Second: ").Append(Second).Append("\n");
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
            return this.Equals(input as RelationshipElement);
        }

        /// <summary>
        /// Returns true if RelationshipElement instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationshipElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationshipElement input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && base.Equals(input) && 
                (
                    this.Second == input.Second ||
                    (this.Second != null &&
                    this.Second.Equals(input.Second))
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
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Second != null)
                    hashCode = hashCode * 59 + this.Second.GetHashCode();
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
