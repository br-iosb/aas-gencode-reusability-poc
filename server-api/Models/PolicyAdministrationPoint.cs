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
    public partial class PolicyAdministrationPoint : IEquatable<PolicyAdministrationPoint>
    { 
        /// <summary>
        /// Gets or Sets ExternalAccessControl
        /// </summary>
        [Required]

        [DataMember(Name="externalAccessControl")]
        public bool? ExternalAccessControl { get; set; }

        /// <summary>
        /// Gets or Sets LocalAccessControl
        /// </summary>

        [DataMember(Name="localAccessControl")]
        public AccessControl LocalAccessControl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyAdministrationPoint {\n");
            sb.Append("  ExternalAccessControl: ").Append(ExternalAccessControl).Append("\n");
            sb.Append("  LocalAccessControl: ").Append(LocalAccessControl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PolicyAdministrationPoint)obj);
        }

        /// <summary>
        /// Returns true if PolicyAdministrationPoint instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyAdministrationPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyAdministrationPoint other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ExternalAccessControl == other.ExternalAccessControl ||
                    ExternalAccessControl != null &&
                    ExternalAccessControl.Equals(other.ExternalAccessControl)
                ) && 
                (
                    LocalAccessControl == other.LocalAccessControl ||
                    LocalAccessControl != null &&
                    LocalAccessControl.Equals(other.LocalAccessControl)
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
                    if (ExternalAccessControl != null)
                    hashCode = hashCode * 59 + ExternalAccessControl.GetHashCode();
                    if (LocalAccessControl != null)
                    hashCode = hashCode * 59 + LocalAccessControl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PolicyAdministrationPoint left, PolicyAdministrationPoint right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PolicyAdministrationPoint left, PolicyAdministrationPoint right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}