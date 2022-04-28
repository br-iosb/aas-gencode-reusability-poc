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
    /// SubjectAttributes
    /// </summary>
    [DataContract]
        public partial class SubjectAttributes :  IEquatable<SubjectAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectAttributes" /> class.
        /// </summary>
        /// <param name="subjectAttributes">subjectAttributes.</param>
        public SubjectAttributes(List<Reference> subjectAttributes = default(List<Reference>))
        {
            this._SubjectAttributes = subjectAttributes;
        }
        
        /// <summary>
        /// Gets or Sets _SubjectAttributes
        /// </summary>
        [DataMember(Name="subjectAttributes", EmitDefaultValue=false)]
        public List<Reference> _SubjectAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubjectAttributes {\n");
            sb.Append("  _SubjectAttributes: ").Append(_SubjectAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SubjectAttributes);
        }

        /// <summary>
        /// Returns true if SubjectAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of SubjectAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubjectAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._SubjectAttributes == input._SubjectAttributes ||
                    this._SubjectAttributes != null &&
                    input._SubjectAttributes != null &&
                    this._SubjectAttributes.SequenceEqual(input._SubjectAttributes)
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
                int hashCode = 41;
                if (this._SubjectAttributes != null)
                    hashCode = hashCode * 59 + this._SubjectAttributes.GetHashCode();
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
