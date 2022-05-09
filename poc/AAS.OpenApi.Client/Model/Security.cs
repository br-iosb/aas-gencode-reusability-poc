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
    /// Security
    /// </summary>
    [DataContract]
        public partial class Security :  IEquatable<Security>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Security" /> class.
        /// </summary>
        /// <param name="accessControlPolicyPoints">accessControlPolicyPoints (required).</param>
        /// <param name="certificate">certificate.</param>
        /// <param name="requiredCertificateExtension">requiredCertificateExtension.</param>
        public Security(AccessControlPolicyPoints accessControlPolicyPoints = default(AccessControlPolicyPoints), List<Certificate> certificate = default(List<Certificate>), List<Reference> requiredCertificateExtension = default(List<Reference>))
        {
            // to ensure "accessControlPolicyPoints" is required (not null)
            if (accessControlPolicyPoints == null)
            {
                throw new InvalidDataException("accessControlPolicyPoints is a required property for Security and cannot be null");
            }
            else
            {
                this.AccessControlPolicyPoints = accessControlPolicyPoints;
            }
            this.Certificate = certificate;
            this.RequiredCertificateExtension = requiredCertificateExtension;
        }
        
        /// <summary>
        /// Gets or Sets AccessControlPolicyPoints
        /// </summary>
        [DataMember(Name="accessControlPolicyPoints", EmitDefaultValue=false)]
        public AccessControlPolicyPoints AccessControlPolicyPoints { get; set; }

        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public List<Certificate> Certificate { get; set; }

        /// <summary>
        /// Gets or Sets RequiredCertificateExtension
        /// </summary>
        [DataMember(Name="requiredCertificateExtension", EmitDefaultValue=false)]
        public List<Reference> RequiredCertificateExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Security {\n");
            sb.Append("  AccessControlPolicyPoints: ").Append(AccessControlPolicyPoints).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  RequiredCertificateExtension: ").Append(RequiredCertificateExtension).Append("\n");
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
            return this.Equals(input as Security);
        }

        /// <summary>
        /// Returns true if Security instances are equal
        /// </summary>
        /// <param name="input">Instance of Security to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Security input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessControlPolicyPoints == input.AccessControlPolicyPoints ||
                    (this.AccessControlPolicyPoints != null &&
                    this.AccessControlPolicyPoints.Equals(input.AccessControlPolicyPoints))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    this.Certificate != null &&
                    input.Certificate != null &&
                    this.Certificate.SequenceEqual(input.Certificate)
                ) && 
                (
                    this.RequiredCertificateExtension == input.RequiredCertificateExtension ||
                    this.RequiredCertificateExtension != null &&
                    input.RequiredCertificateExtension != null &&
                    this.RequiredCertificateExtension.SequenceEqual(input.RequiredCertificateExtension)
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
                if (this.AccessControlPolicyPoints != null)
                    hashCode = hashCode * 59 + this.AccessControlPolicyPoints.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.RequiredCertificateExtension != null)
                    hashCode = hashCode * 59 + this.RequiredCertificateExtension.GetHashCode();
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
