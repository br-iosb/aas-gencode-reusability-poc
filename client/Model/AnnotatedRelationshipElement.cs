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
using SwaggerDateConverter = AAS.Client.Client.SwaggerDateConverter;

namespace AAS.Client.Model
{
    /// <summary>
    /// AnnotatedRelationshipElement
    /// </summary>
    [DataContract]
        public partial class AnnotatedRelationshipElement : RelationshipElement,  IEquatable<AnnotatedRelationshipElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotatedRelationshipElement" /> class.
        /// </summary>
        /// <param name="annotation">annotation.</param>
        public AnnotatedRelationshipElement(List<DataElement> annotation = default(List<DataElement>), Reference first = default(Reference), Reference second = default(Reference)) : base(first, second)
        {
            this.Annotation = annotation;
        }
        
        /// <summary>
        /// Gets or Sets Annotation
        /// </summary>
        [DataMember(Name="annotation", EmitDefaultValue=false)]
        public List<DataElement> Annotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnotatedRelationshipElement {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
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
            return this.Equals(input as AnnotatedRelationshipElement);
        }

        /// <summary>
        /// Returns true if AnnotatedRelationshipElement instances are equal
        /// </summary>
        /// <param name="input">Instance of AnnotatedRelationshipElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnnotatedRelationshipElement input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Annotation == input.Annotation ||
                    this.Annotation != null &&
                    input.Annotation != null &&
                    this.Annotation.SequenceEqual(input.Annotation)
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
                if (this.Annotation != null)
                    hashCode = hashCode * 59 + this.Annotation.GetHashCode();
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
