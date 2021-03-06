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

namespace AAS.OpenApi.Server.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class AssetInformation : IEquatable<AssetInformation>
    { 
        /// <summary>
        /// Gets or Sets AssetKind
        /// </summary>
        [Required]

        [DataMember(Name="assetKind")]
        public AssetKind AssetKind { get; set; }

        /// <summary>
        /// Gets or Sets BillOfMaterial
        /// </summary>

        [DataMember(Name="billOfMaterial")]
        public List<Reference> BillOfMaterial { get; set; }

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
        /// Gets or Sets Thumbnail
        /// </summary>

        [DataMember(Name="thumbnail")]
        public System.IO.Stream Thumbnail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetInformation {\n");
            sb.Append("  AssetKind: ").Append(AssetKind).Append("\n");
            sb.Append("  BillOfMaterial: ").Append(BillOfMaterial).Append("\n");
            sb.Append("  GlobalAssetId: ").Append(GlobalAssetId).Append("\n");
            sb.Append("  SpecificAssetIds: ").Append(SpecificAssetIds).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetInformation)obj);
        }

        /// <summary>
        /// Returns true if AssetInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetInformation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AssetKind == other.AssetKind ||
                    AssetKind != null &&
                    AssetKind.Equals(other.AssetKind)
                ) && 
                (
                    BillOfMaterial == other.BillOfMaterial ||
                    BillOfMaterial != null &&
                    BillOfMaterial.SequenceEqual(other.BillOfMaterial)
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
                    Thumbnail == other.Thumbnail ||
                    Thumbnail != null &&
                    Thumbnail.Equals(other.Thumbnail)
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
                    if (AssetKind != null)
                    hashCode = hashCode * 59 + AssetKind.GetHashCode();
                    if (BillOfMaterial != null)
                    hashCode = hashCode * 59 + BillOfMaterial.GetHashCode();
                    if (GlobalAssetId != null)
                    hashCode = hashCode * 59 + GlobalAssetId.GetHashCode();
                    if (SpecificAssetIds != null)
                    hashCode = hashCode * 59 + SpecificAssetIds.GetHashCode();
                    if (Thumbnail != null)
                    hashCode = hashCode * 59 + Thumbnail.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetInformation left, AssetInformation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetInformation left, AssetInformation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
