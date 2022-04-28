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
    public partial class PackagesBody : IEquatable<PackagesBody>
    { 
        /// <summary>
        /// Gets or Sets AasIds
        /// </summary>

        [DataMember(Name="aasIds")]
        public List<string> AasIds { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>

        [DataMember(Name="file")]
        public byte[] File { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>

        [DataMember(Name="fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackagesBody {\n");
            sb.Append("  AasIds: ").Append(AasIds).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PackagesBody)obj);
        }

        /// <summary>
        /// Returns true if PackagesBody instances are equal
        /// </summary>
        /// <param name="other">Instance of PackagesBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackagesBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AasIds == other.AasIds ||
                    AasIds != null &&
                    AasIds.SequenceEqual(other.AasIds)
                ) && 
                (
                    File == other.File ||
                    File != null &&
                    File.Equals(other.File)
                ) && 
                (
                    FileName == other.FileName ||
                    FileName != null &&
                    FileName.Equals(other.FileName)
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
                    if (AasIds != null)
                    hashCode = hashCode * 59 + AasIds.GetHashCode();
                    if (File != null)
                    hashCode = hashCode * 59 + File.GetHashCode();
                    if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PackagesBody left, PackagesBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PackagesBody left, PackagesBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
