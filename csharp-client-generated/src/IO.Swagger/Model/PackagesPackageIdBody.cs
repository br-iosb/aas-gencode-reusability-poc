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
    /// PackagesPackageIdBody
    /// </summary>
    [DataContract]
        public partial class PackagesPackageIdBody :  IEquatable<PackagesPackageIdBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackagesPackageIdBody" /> class.
        /// </summary>
        /// <param name="aasIds">aasIds.</param>
        /// <param name="file">file.</param>
        /// <param name="fileName">fileName.</param>
        public PackagesPackageIdBody(List<string> aasIds = default(List<string>), byte[] file = default(byte[]), string fileName = default(string))
        {
            this.AasIds = aasIds;
            this.File = file;
            this.FileName = fileName;
        }
        
        /// <summary>
        /// Gets or Sets AasIds
        /// </summary>
        [DataMember(Name="aasIds", EmitDefaultValue=false)]
        public List<string> AasIds { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public byte[] File { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackagesPackageIdBody {\n");
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
            return this.Equals(input as PackagesPackageIdBody);
        }

        /// <summary>
        /// Returns true if PackagesPackageIdBody instances are equal
        /// </summary>
        /// <param name="input">Instance of PackagesPackageIdBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackagesPackageIdBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AasIds == input.AasIds ||
                    this.AasIds != null &&
                    input.AasIds != null &&
                    this.AasIds.SequenceEqual(input.AasIds)
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
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
                if (this.AasIds != null)
                    hashCode = hashCode * 59 + this.AasIds.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
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
