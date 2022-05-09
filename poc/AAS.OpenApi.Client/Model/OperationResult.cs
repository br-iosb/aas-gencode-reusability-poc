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
    /// OperationResult
    /// </summary>
    [DataContract]
        public partial class OperationResult :  IEquatable<OperationResult>, IValidatableObject
    {
        /// <summary>
        /// Defines ExecutionState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ExecutionStateEnum
        {
            /// <summary>
            /// Enum Initiated for value: Initiated
            /// </summary>
            [EnumMember(Value = "Initiated")]
            Initiated = 1,
            /// <summary>
            /// Enum Running for value: Running
            /// </summary>
            [EnumMember(Value = "Running")]
            Running = 2,
            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3,
            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 4,
            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 5,
            /// <summary>
            /// Enum Timeout for value: Timeout
            /// </summary>
            [EnumMember(Value = "Timeout")]
            Timeout = 6        }
        /// <summary>
        /// Gets or Sets ExecutionState
        /// </summary>
        [DataMember(Name="executionState", EmitDefaultValue=false)]
        public ExecutionStateEnum? ExecutionState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResult" /> class.
        /// </summary>
        /// <param name="executionResult">executionResult.</param>
        /// <param name="executionState">executionState.</param>
        /// <param name="inoutputArguments">inoutputArguments.</param>
        /// <param name="outputArguments">outputArguments.</param>
        /// <param name="requestId">requestId.</param>
        public OperationResult(Result executionResult = default(Result), ExecutionStateEnum? executionState = default(ExecutionStateEnum?), List<OperationVariable> inoutputArguments = default(List<OperationVariable>), List<OperationVariable> outputArguments = default(List<OperationVariable>), string requestId = default(string))
        {
            this.ExecutionResult = executionResult;
            this.ExecutionState = executionState;
            this.InoutputArguments = inoutputArguments;
            this.OutputArguments = outputArguments;
            this.RequestId = requestId;
        }
        
        /// <summary>
        /// Gets or Sets ExecutionResult
        /// </summary>
        [DataMember(Name="executionResult", EmitDefaultValue=false)]
        public Result ExecutionResult { get; set; }


        /// <summary>
        /// Gets or Sets InoutputArguments
        /// </summary>
        [DataMember(Name="inoutputArguments", EmitDefaultValue=false)]
        public List<OperationVariable> InoutputArguments { get; set; }

        /// <summary>
        /// Gets or Sets OutputArguments
        /// </summary>
        [DataMember(Name="outputArguments", EmitDefaultValue=false)]
        public List<OperationVariable> OutputArguments { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationResult {\n");
            sb.Append("  ExecutionResult: ").Append(ExecutionResult).Append("\n");
            sb.Append("  ExecutionState: ").Append(ExecutionState).Append("\n");
            sb.Append("  InoutputArguments: ").Append(InoutputArguments).Append("\n");
            sb.Append("  OutputArguments: ").Append(OutputArguments).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as OperationResult);
        }

        /// <summary>
        /// Returns true if OperationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExecutionResult == input.ExecutionResult ||
                    (this.ExecutionResult != null &&
                    this.ExecutionResult.Equals(input.ExecutionResult))
                ) && 
                (
                    this.ExecutionState == input.ExecutionState ||
                    (this.ExecutionState != null &&
                    this.ExecutionState.Equals(input.ExecutionState))
                ) && 
                (
                    this.InoutputArguments == input.InoutputArguments ||
                    this.InoutputArguments != null &&
                    input.InoutputArguments != null &&
                    this.InoutputArguments.SequenceEqual(input.InoutputArguments)
                ) && 
                (
                    this.OutputArguments == input.OutputArguments ||
                    this.OutputArguments != null &&
                    input.OutputArguments != null &&
                    this.OutputArguments.SequenceEqual(input.OutputArguments)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.ExecutionResult != null)
                    hashCode = hashCode * 59 + this.ExecutionResult.GetHashCode();
                if (this.ExecutionState != null)
                    hashCode = hashCode * 59 + this.ExecutionState.GetHashCode();
                if (this.InoutputArguments != null)
                    hashCode = hashCode * 59 + this.InoutputArguments.GetHashCode();
                if (this.OutputArguments != null)
                    hashCode = hashCode * 59 + this.OutputArguments.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
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
