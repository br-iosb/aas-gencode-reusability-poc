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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class SubmodelElementList : SubmodelElementAttributes, IEquatable<SubmodelElementList>
    { 
        /// <summary>
        /// Gets or Sets SemanticIdValues
        /// </summary>

        [DataMember(Name="semanticIdValues")]
        public Reference SemanticIdValues { get; set; }

        /// <summary>
        /// Gets or Sets SubmodelElementTypeValues
        /// </summary>

        [DataMember(Name="submodelElementTypeValues")]
        public ModelType SubmodelElementTypeValues { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>

        [DataMember(Name="value")]
        public List<SubmodelElement> Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueTypeValues
        /// </summary>

        [DataMember(Name="valueTypeValues")]
        public ValueTypeEnum ValueTypeValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmodelElementList {\n");
            sb.Append("  SemanticIdValues: ").Append(SemanticIdValues).Append("\n");
            sb.Append("  SubmodelElementTypeValues: ").Append(SubmodelElementTypeValues).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueTypeValues: ").Append(ValueTypeValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SubmodelElementList)obj);
        }

        /// <summary>
        /// Returns true if SubmodelElementList instances are equal
        /// </summary>
        /// <param name="other">Instance of SubmodelElementList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmodelElementList other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SemanticIdValues == other.SemanticIdValues ||
                    SemanticIdValues != null &&
                    SemanticIdValues.Equals(other.SemanticIdValues)
                ) && 
                (
                    SubmodelElementTypeValues == other.SubmodelElementTypeValues ||
                    SubmodelElementTypeValues != null &&
                    SubmodelElementTypeValues.Equals(other.SubmodelElementTypeValues)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.SequenceEqual(other.Value)
                ) && 
                (
                    ValueTypeValues == other.ValueTypeValues ||
                    ValueTypeValues != null &&
                    ValueTypeValues.Equals(other.ValueTypeValues)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (SemanticIdValues != null)
                    hashCode = hashCode * 59 + SemanticIdValues.GetHashCode();
                    if (SubmodelElementTypeValues != null)
                    hashCode = hashCode * 59 + SubmodelElementTypeValues.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (ValueTypeValues != null)
                    hashCode = hashCode * 59 + ValueTypeValues.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SubmodelElementList left, SubmodelElementList right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SubmodelElementList left, SubmodelElementList right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
