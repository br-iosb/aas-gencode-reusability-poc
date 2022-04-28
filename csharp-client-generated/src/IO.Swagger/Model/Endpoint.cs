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
    /// Endpoint
    /// </summary>
    [DataContract]
        public partial class Endpoint :  IEquatable<Endpoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="_interface">_interface (required).</param>
        /// <param name="protocolInformation">protocolInformation (required).</param>
        public Endpoint(string _interface = default(string), ProtocolInformation protocolInformation = default(ProtocolInformation))
        {
            // to ensure "_interface" is required (not null)
            if (_interface == null)
            {
                throw new InvalidDataException("_interface is a required property for Endpoint and cannot be null");
            }
            else
            {
                this._Interface = _interface;
            }
            // to ensure "protocolInformation" is required (not null)
            if (protocolInformation == null)
            {
                throw new InvalidDataException("protocolInformation is a required property for Endpoint and cannot be null");
            }
            else
            {
                this.ProtocolInformation = protocolInformation;
            }
        }
        
        /// <summary>
        /// Gets or Sets _Interface
        /// </summary>
        [DataMember(Name="interface", EmitDefaultValue=false)]
        public string _Interface { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolInformation
        /// </summary>
        [DataMember(Name="protocolInformation", EmitDefaultValue=false)]
        public ProtocolInformation ProtocolInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Endpoint {\n");
            sb.Append("  _Interface: ").Append(_Interface).Append("\n");
            sb.Append("  ProtocolInformation: ").Append(ProtocolInformation).Append("\n");
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
            return this.Equals(input as Endpoint);
        }

        /// <summary>
        /// Returns true if Endpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of Endpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Endpoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Interface == input._Interface ||
                    (this._Interface != null &&
                    this._Interface.Equals(input._Interface))
                ) && 
                (
                    this.ProtocolInformation == input.ProtocolInformation ||
                    (this.ProtocolInformation != null &&
                    this.ProtocolInformation.Equals(input.ProtocolInformation))
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
                if (this._Interface != null)
                    hashCode = hashCode * 59 + this._Interface.GetHashCode();
                if (this.ProtocolInformation != null)
                    hashCode = hashCode * 59 + this.ProtocolInformation.GetHashCode();
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
