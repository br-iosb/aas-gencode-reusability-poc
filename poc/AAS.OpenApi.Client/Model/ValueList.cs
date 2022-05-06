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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = AAS.OpenApi.Client.Client.SwaggerDateConverter;

namespace AAS.OpenApi.Client.Model
{
    /// <summary>
    /// ValueList
    /// </summary>
    [DataContract]
        public partial class ValueList :  IEquatable<ValueList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueList" /> class.
        /// </summary>
        /// <param name="valueReferencePairTypes">valueReferencePairTypes (required).</param>
        public ValueList(List<ValueReferencePairType> valueReferencePairTypes = default(List<ValueReferencePairType>))
        {
            // to ensure "valueReferencePairTypes" is required (not null)
            if (valueReferencePairTypes == null)
            {
                throw new InvalidDataException("valueReferencePairTypes is a required property for ValueList and cannot be null");
            }
            else
            {
                this.ValueReferencePairTypes = valueReferencePairTypes;
            }
        }
        
        /// <summary>
        /// Gets or Sets ValueReferencePairTypes
        /// </summary>
        [DataMember(Name="valueReferencePairTypes", EmitDefaultValue=false)]
        public List<ValueReferencePairType> ValueReferencePairTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValueList {\n");
            sb.Append("  ValueReferencePairTypes: ").Append(ValueReferencePairTypes).Append("\n");
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
            return this.Equals(input as ValueList);
        }

        /// <summary>
        /// Returns true if ValueList instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValueReferencePairTypes == input.ValueReferencePairTypes ||
                    this.ValueReferencePairTypes != null &&
                    input.ValueReferencePairTypes != null &&
                    this.ValueReferencePairTypes.SequenceEqual(input.ValueReferencePairTypes)
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
                if (this.ValueReferencePairTypes != null)
                    hashCode = hashCode * 59 + this.ValueReferencePairTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}