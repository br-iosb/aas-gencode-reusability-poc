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
    /// AccessControlPolicyPoints
    /// </summary>
    [DataContract]
        public partial class AccessControlPolicyPoints :  IEquatable<AccessControlPolicyPoints>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlPolicyPoints" /> class.
        /// </summary>
        /// <param name="policyAdministrationPoint">policyAdministrationPoint (required).</param>
        /// <param name="policyDecisionPoint">policyDecisionPoint (required).</param>
        /// <param name="policyEnforcementPoint">policyEnforcementPoint (required).</param>
        /// <param name="policyInformationPoints">policyInformationPoints.</param>
        public AccessControlPolicyPoints(PolicyAdministrationPoint policyAdministrationPoint = default(PolicyAdministrationPoint), PolicyDecisionPoint policyDecisionPoint = default(PolicyDecisionPoint), PolicyEnforcementPoint policyEnforcementPoint = default(PolicyEnforcementPoint), PolicyInformationPoints policyInformationPoints = default(PolicyInformationPoints))
        {
            // to ensure "policyAdministrationPoint" is required (not null)
            if (policyAdministrationPoint == null)
            {
                throw new InvalidDataException("policyAdministrationPoint is a required property for AccessControlPolicyPoints and cannot be null");
            }
            else
            {
                this.PolicyAdministrationPoint = policyAdministrationPoint;
            }
            // to ensure "policyDecisionPoint" is required (not null)
            if (policyDecisionPoint == null)
            {
                throw new InvalidDataException("policyDecisionPoint is a required property for AccessControlPolicyPoints and cannot be null");
            }
            else
            {
                this.PolicyDecisionPoint = policyDecisionPoint;
            }
            // to ensure "policyEnforcementPoint" is required (not null)
            if (policyEnforcementPoint == null)
            {
                throw new InvalidDataException("policyEnforcementPoint is a required property for AccessControlPolicyPoints and cannot be null");
            }
            else
            {
                this.PolicyEnforcementPoint = policyEnforcementPoint;
            }
            this.PolicyInformationPoints = policyInformationPoints;
        }
        
        /// <summary>
        /// Gets or Sets PolicyAdministrationPoint
        /// </summary>
        [DataMember(Name="policyAdministrationPoint", EmitDefaultValue=false)]
        public PolicyAdministrationPoint PolicyAdministrationPoint { get; set; }

        /// <summary>
        /// Gets or Sets PolicyDecisionPoint
        /// </summary>
        [DataMember(Name="policyDecisionPoint", EmitDefaultValue=false)]
        public PolicyDecisionPoint PolicyDecisionPoint { get; set; }

        /// <summary>
        /// Gets or Sets PolicyEnforcementPoint
        /// </summary>
        [DataMember(Name="policyEnforcementPoint", EmitDefaultValue=false)]
        public PolicyEnforcementPoint PolicyEnforcementPoint { get; set; }

        /// <summary>
        /// Gets or Sets PolicyInformationPoints
        /// </summary>
        [DataMember(Name="policyInformationPoints", EmitDefaultValue=false)]
        public PolicyInformationPoints PolicyInformationPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessControlPolicyPoints {\n");
            sb.Append("  PolicyAdministrationPoint: ").Append(PolicyAdministrationPoint).Append("\n");
            sb.Append("  PolicyDecisionPoint: ").Append(PolicyDecisionPoint).Append("\n");
            sb.Append("  PolicyEnforcementPoint: ").Append(PolicyEnforcementPoint).Append("\n");
            sb.Append("  PolicyInformationPoints: ").Append(PolicyInformationPoints).Append("\n");
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
            return this.Equals(input as AccessControlPolicyPoints);
        }

        /// <summary>
        /// Returns true if AccessControlPolicyPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessControlPolicyPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessControlPolicyPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyAdministrationPoint == input.PolicyAdministrationPoint ||
                    (this.PolicyAdministrationPoint != null &&
                    this.PolicyAdministrationPoint.Equals(input.PolicyAdministrationPoint))
                ) && 
                (
                    this.PolicyDecisionPoint == input.PolicyDecisionPoint ||
                    (this.PolicyDecisionPoint != null &&
                    this.PolicyDecisionPoint.Equals(input.PolicyDecisionPoint))
                ) && 
                (
                    this.PolicyEnforcementPoint == input.PolicyEnforcementPoint ||
                    (this.PolicyEnforcementPoint != null &&
                    this.PolicyEnforcementPoint.Equals(input.PolicyEnforcementPoint))
                ) && 
                (
                    this.PolicyInformationPoints == input.PolicyInformationPoints ||
                    (this.PolicyInformationPoints != null &&
                    this.PolicyInformationPoints.Equals(input.PolicyInformationPoints))
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
                if (this.PolicyAdministrationPoint != null)
                    hashCode = hashCode * 59 + this.PolicyAdministrationPoint.GetHashCode();
                if (this.PolicyDecisionPoint != null)
                    hashCode = hashCode * 59 + this.PolicyDecisionPoint.GetHashCode();
                if (this.PolicyEnforcementPoint != null)
                    hashCode = hashCode * 59 + this.PolicyEnforcementPoint.GetHashCode();
                if (this.PolicyInformationPoints != null)
                    hashCode = hashCode * 59 + this.PolicyInformationPoints.GetHashCode();
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
