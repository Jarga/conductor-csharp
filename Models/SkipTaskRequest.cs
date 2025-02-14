/* 
 * 
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

namespace Conductor.Client.Models
{
    /// <summary>
    /// SkipTaskRequest
    /// </summary>
    [DataContract]
    public partial class SkipTaskRequest :  IEquatable<SkipTaskRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTaskRequest" /> class.
        /// </summary>
        /// <param name="taskInput">taskInput.</param>
        /// <param name="taskOutput">taskOutput.</param>
        /// <param name="taskInputMessage">taskInputMessage.</param>
        /// <param name="taskOutputMessage">taskOutputMessage.</param>
        public SkipTaskRequest(Dictionary<string, Object> taskInput = default(Dictionary<string, Object>), Dictionary<string, Object> taskOutput = default(Dictionary<string, Object>), Any taskInputMessage = default(Any), Any taskOutputMessage = default(Any))
        {
            this.TaskInput = taskInput;
            this.TaskOutput = taskOutput;
            this.TaskInputMessage = taskInputMessage;
            this.TaskOutputMessage = taskOutputMessage;
        }
        
        /// <summary>
        /// Gets or Sets TaskInput
        /// </summary>
        [DataMember(Name="taskInput", EmitDefaultValue=false)]
        public Dictionary<string, Object> TaskInput { get; set; }

        /// <summary>
        /// Gets or Sets TaskOutput
        /// </summary>
        [DataMember(Name="taskOutput", EmitDefaultValue=false)]
        public Dictionary<string, Object> TaskOutput { get; set; }

        /// <summary>
        /// Gets or Sets TaskInputMessage
        /// </summary>
        [DataMember(Name="taskInputMessage", EmitDefaultValue=false)]
        public Any TaskInputMessage { get; set; }

        /// <summary>
        /// Gets or Sets TaskOutputMessage
        /// </summary>
        [DataMember(Name="taskOutputMessage", EmitDefaultValue=false)]
        public Any TaskOutputMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkipTaskRequest {\n");
            sb.Append("  TaskInput: ").Append(TaskInput).Append("\n");
            sb.Append("  TaskOutput: ").Append(TaskOutput).Append("\n");
            sb.Append("  TaskInputMessage: ").Append(TaskInputMessage).Append("\n");
            sb.Append("  TaskOutputMessage: ").Append(TaskOutputMessage).Append("\n");
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
            return this.Equals(input as SkipTaskRequest);
        }

        /// <summary>
        /// Returns true if SkipTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SkipTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkipTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskInput == input.TaskInput ||
                    this.TaskInput != null &&
                    this.TaskInput.SequenceEqual(input.TaskInput)
                ) && 
                (
                    this.TaskOutput == input.TaskOutput ||
                    this.TaskOutput != null &&
                    this.TaskOutput.SequenceEqual(input.TaskOutput)
                ) && 
                (
                    this.TaskInputMessage == input.TaskInputMessage ||
                    (this.TaskInputMessage != null &&
                    this.TaskInputMessage.Equals(input.TaskInputMessage))
                ) && 
                (
                    this.TaskOutputMessage == input.TaskOutputMessage ||
                    (this.TaskOutputMessage != null &&
                    this.TaskOutputMessage.Equals(input.TaskOutputMessage))
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
                if (this.TaskInput != null)
                    hashCode = hashCode * 59 + this.TaskInput.GetHashCode();
                if (this.TaskOutput != null)
                    hashCode = hashCode * 59 + this.TaskOutput.GetHashCode();
                if (this.TaskInputMessage != null)
                    hashCode = hashCode * 59 + this.TaskInputMessage.GetHashCode();
                if (this.TaskOutputMessage != null)
                    hashCode = hashCode * 59 + this.TaskOutputMessage.GetHashCode();
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
