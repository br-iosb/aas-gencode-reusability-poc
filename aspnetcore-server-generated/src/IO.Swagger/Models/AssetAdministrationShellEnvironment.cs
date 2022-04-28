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
    public partial class AssetAdministrationShellEnvironment : IEquatable<AssetAdministrationShellEnvironment>
    { 
        /// <summary>
        /// Gets or Sets AssetAdministrationShells
        /// </summary>

        [DataMember(Name="assetAdministrationShells")]
        public List<AssetAdministrationShell> AssetAdministrationShells { get; set; }

        /// <summary>
        /// Gets or Sets ConceptDescriptions
        /// </summary>

        [DataMember(Name="conceptDescriptions")]
        public List<ConceptDescription> ConceptDescriptions { get; set; }

        /// <summary>
        /// Gets or Sets Submodels
        /// </summary>

        [DataMember(Name="submodels")]
        public List<Submodel> Submodels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetAdministrationShellEnvironment {\n");
            sb.Append("  AssetAdministrationShells: ").Append(AssetAdministrationShells).Append("\n");
            sb.Append("  ConceptDescriptions: ").Append(ConceptDescriptions).Append("\n");
            sb.Append("  Submodels: ").Append(Submodels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return obj.GetType() == GetType() && Equals((AssetAdministrationShellEnvironment)obj);
        }

        /// <summary>
        /// Returns true if AssetAdministrationShellEnvironment instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetAdministrationShellEnvironment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetAdministrationShellEnvironment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AssetAdministrationShells == other.AssetAdministrationShells ||
                    AssetAdministrationShells != null &&
                    AssetAdministrationShells.SequenceEqual(other.AssetAdministrationShells)
                ) && 
                (
                    ConceptDescriptions == other.ConceptDescriptions ||
                    ConceptDescriptions != null &&
                    ConceptDescriptions.SequenceEqual(other.ConceptDescriptions)
                ) && 
                (
                    Submodels == other.Submodels ||
                    Submodels != null &&
                    Submodels.SequenceEqual(other.Submodels)
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
                    if (AssetAdministrationShells != null)
                    hashCode = hashCode * 59 + AssetAdministrationShells.GetHashCode();
                    if (ConceptDescriptions != null)
                    hashCode = hashCode * 59 + ConceptDescriptions.GetHashCode();
                    if (Submodels != null)
                    hashCode = hashCode * 59 + Submodels.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetAdministrationShellEnvironment left, AssetAdministrationShellEnvironment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetAdministrationShellEnvironment left, AssetAdministrationShellEnvironment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
