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
    /// StartWorkflowRequest
    /// </summary>
    [DataContract]
    public partial class StartWorkflowRequest :  IEquatable<StartWorkflowRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartWorkflowRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartWorkflowRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartWorkflowRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="version">version.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="input">input.</param>
        /// <param name="taskToDomain">taskToDomain.</param>
        /// <param name="workflowDef">workflowDef.</param>
        /// <param name="externalInputPayloadStoragePath">externalInputPayloadStoragePath.</param>
        /// <param name="priority">priority.</param>
        public StartWorkflowRequest(string name = default(string), int? version = default(int?), string correlationId = default(string), Dictionary<string, Object> input = default(Dictionary<string, Object>), Dictionary<string, string> taskToDomain = default(Dictionary<string, string>), WorkflowDef workflowDef = default(WorkflowDef), string externalInputPayloadStoragePath = default(string), int? priority = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for StartWorkflowRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Version = version;
            this.CorrelationId = correlationId;
            this.Input = input;
            this.TaskToDomain = taskToDomain;
            this.WorkflowDef = workflowDef;
            this.ExternalInputPayloadStoragePath = externalInputPayloadStoragePath;
            this.Priority = priority;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public Dictionary<string, Object> Input { get; set; }

        /// <summary>
        /// Gets or Sets TaskToDomain
        /// </summary>
        [DataMember(Name="taskToDomain", EmitDefaultValue=false)]
        public Dictionary<string, string> TaskToDomain { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowDef
        /// </summary>
        [DataMember(Name="workflowDef", EmitDefaultValue=false)]
        public WorkflowDef WorkflowDef { get; set; }

        /// <summary>
        /// Gets or Sets ExternalInputPayloadStoragePath
        /// </summary>
        [DataMember(Name="externalInputPayloadStoragePath", EmitDefaultValue=false)]
        public string ExternalInputPayloadStoragePath { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartWorkflowRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  TaskToDomain: ").Append(TaskToDomain).Append("\n");
            sb.Append("  WorkflowDef: ").Append(WorkflowDef).Append("\n");
            sb.Append("  ExternalInputPayloadStoragePath: ").Append(ExternalInputPayloadStoragePath).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as StartWorkflowRequest);
        }

        /// <summary>
        /// Returns true if StartWorkflowRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartWorkflowRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartWorkflowRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.Input == input.Input ||
                    this.Input != null &&
                    this.Input.SequenceEqual(input.Input)
                ) && 
                (
                    this.TaskToDomain == input.TaskToDomain ||
                    this.TaskToDomain != null &&
                    this.TaskToDomain.SequenceEqual(input.TaskToDomain)
                ) && 
                (
                    this.WorkflowDef == input.WorkflowDef ||
                    (this.WorkflowDef != null &&
                    this.WorkflowDef.Equals(input.WorkflowDef))
                ) && 
                (
                    this.ExternalInputPayloadStoragePath == input.ExternalInputPayloadStoragePath ||
                    (this.ExternalInputPayloadStoragePath != null &&
                    this.ExternalInputPayloadStoragePath.Equals(input.ExternalInputPayloadStoragePath))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CorrelationId != null)
                    hashCode = hashCode * 59 + this.CorrelationId.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.TaskToDomain != null)
                    hashCode = hashCode * 59 + this.TaskToDomain.GetHashCode();
                if (this.WorkflowDef != null)
                    hashCode = hashCode * 59 + this.WorkflowDef.GetHashCode();
                if (this.ExternalInputPayloadStoragePath != null)
                    hashCode = hashCode * 59 + this.ExternalInputPayloadStoragePath.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
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
            // Priority (int?) maximum
            if(this.Priority > (int?)99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Priority, must be a value less than or equal to 99.", new [] { "Priority" });
            }

            // Priority (int?) minimum
            if(this.Priority < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Priority, must be a value greater than or equal to 0.", new [] { "Priority" });
            }

            yield break;
        }
    }

}
