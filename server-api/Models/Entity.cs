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

namespace AAS.Server.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Entity : SubmodelElementAttributes, IEquatable<Entity>
    { 
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [Required]

        [DataMember(Name="entityType")]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Gets or Sets GlobalAssetId
        /// </summary>

        [DataMember(Name="globalAssetId")]
        public Reference GlobalAssetId { get; set; }

        /// <summary>
        /// Gets or Sets SpecificAssetIds
        /// </summary>

        [DataMember(Name="specificAssetIds")]
        public List<IdentifierKeyValuePair> SpecificAssetIds { get; set; }

        /// <summary>
        /// Gets or Sets Statements
        /// </summary>

        [DataMember(Name="statements")]
        public List<SubmodelElement> Statements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entity {\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  GlobalAssetId: ").Append(GlobalAssetId).Append("\n");
            sb.Append("  SpecificAssetIds: ").Append(SpecificAssetIds).Append("\n");
            sb.Append("  Statements: ").Append(Statements).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Entity)obj);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="other">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EntityType == other.EntityType ||
                    EntityType != null &&
                    EntityType.Equals(other.EntityType)
                ) && 
                (
                    GlobalAssetId == other.GlobalAssetId ||
                    GlobalAssetId != null &&
                    GlobalAssetId.Equals(other.GlobalAssetId)
                ) && 
                (
                    SpecificAssetIds == other.SpecificAssetIds ||
                    SpecificAssetIds != null &&
                    SpecificAssetIds.SequenceEqual(other.SpecificAssetIds)
                ) && 
                (
                    Statements == other.Statements ||
                    Statements != null &&
                    Statements.SequenceEqual(other.Statements)
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
                    if (EntityType != null)
                    hashCode = hashCode * 59 + EntityType.GetHashCode();
                    if (GlobalAssetId != null)
                    hashCode = hashCode * 59 + GlobalAssetId.GetHashCode();
                    if (SpecificAssetIds != null)
                    hashCode = hashCode * 59 + SpecificAssetIds.GetHashCode();
                    if (Statements != null)
                    hashCode = hashCode * 59 + Statements.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Entity left, Entity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
