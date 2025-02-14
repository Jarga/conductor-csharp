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
    /// Workflow
    /// </summary>
    [DataContract]
    public partial class Workflow :  IEquatable<Workflow>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING = 1,
            
            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 2,
            
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 3,
            
            /// <summary>
            /// Enum TIMEDOUT for value: TIMED_OUT
            /// </summary>
            [EnumMember(Value = "TIMED_OUT")]
            TIMEDOUT = 4,
            
            /// <summary>
            /// Enum TERMINATED for value: TERMINATED
            /// </summary>
            [EnumMember(Value = "TERMINATED")]
            TERMINATED = 5,
            
            /// <summary>
            /// Enum PAUSED for value: PAUSED
            /// </summary>
            [EnumMember(Value = "PAUSED")]
            PAUSED = 6
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        /// <param name="ownerApp">ownerApp.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="status">status.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="workflowId">workflowId.</param>
        /// <param name="parentWorkflowId">parentWorkflowId.</param>
        /// <param name="parentWorkflowTaskId">parentWorkflowTaskId.</param>
        /// <param name="tasks">tasks.</param>
        /// <param name="input">input.</param>
        /// <param name="output">output.</param>
        /// <param name="workflowType">workflowType.</param>
        /// <param name="version">version.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="reRunFromWorkflowId">reRunFromWorkflowId.</param>
        /// <param name="reasonForIncompletion">reasonForIncompletion.</param>
        /// <param name="schemaVersion">schemaVersion.</param>
        /// <param name="_event">_event.</param>
        /// <param name="taskToDomain">taskToDomain.</param>
        /// <param name="failedReferenceTaskNames">failedReferenceTaskNames.</param>
        /// <param name="workflowDefinition">workflowDefinition.</param>
        /// <param name="externalInputPayloadStoragePath">externalInputPayloadStoragePath.</param>
        /// <param name="externalOutputPayloadStoragePath">externalOutputPayloadStoragePath.</param>
        /// <param name="priority">priority.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="workflowName">workflowName.</param>
        /// <param name="workflowVersion">workflowVersion.</param>
        public Workflow(string ownerApp = default(string), long? createTime = default(long?), long? updateTime = default(long?), string createdBy = default(string), string updatedBy = default(string), StatusEnum? status = default(StatusEnum?), long? endTime = default(long?), string workflowId = default(string), string parentWorkflowId = default(string), string parentWorkflowTaskId = default(string), List<Task> tasks = default(List<Task>), Dictionary<string, Object> input = default(Dictionary<string, Object>), Dictionary<string, Object> output = default(Dictionary<string, Object>), string workflowType = default(string), int? version = default(int?), string correlationId = default(string), string reRunFromWorkflowId = default(string), string reasonForIncompletion = default(string), int? schemaVersion = default(int?), string _event = default(string), Dictionary<string, string> taskToDomain = default(Dictionary<string, string>), List<string> failedReferenceTaskNames = default(List<string>), WorkflowDef workflowDefinition = default(WorkflowDef), string externalInputPayloadStoragePath = default(string), string externalOutputPayloadStoragePath = default(string), int? priority = default(int?), long? startTime = default(long?), string workflowName = default(string), int? workflowVersion = default(int?))
        {
            this.OwnerApp = ownerApp;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
            this.Status = status;
            this.EndTime = endTime;
            this.WorkflowId = workflowId;
            this.ParentWorkflowId = parentWorkflowId;
            this.ParentWorkflowTaskId = parentWorkflowTaskId;
            this.Tasks = tasks;
            this.Input = input;
            this.Output = output;
            this.WorkflowType = workflowType;
            this.Version = version;
            this.CorrelationId = correlationId;
            this.ReRunFromWorkflowId = reRunFromWorkflowId;
            this.ReasonForIncompletion = reasonForIncompletion;
            this.SchemaVersion = schemaVersion;
            this.Event = _event;
            this.TaskToDomain = taskToDomain;
            this.FailedReferenceTaskNames = failedReferenceTaskNames;
            this.WorkflowDefinition = workflowDefinition;
            this.ExternalInputPayloadStoragePath = externalInputPayloadStoragePath;
            this.ExternalOutputPayloadStoragePath = externalOutputPayloadStoragePath;
            this.Priority = priority;
            this.StartTime = startTime;
            this.WorkflowName = workflowName;
            this.WorkflowVersion = workflowVersion;
        }
        
        /// <summary>
        /// Gets or Sets OwnerApp
        /// </summary>
        [DataMember(Name="ownerApp", EmitDefaultValue=false)]
        public string OwnerApp { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name="updateTime", EmitDefaultValue=false)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="updatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }


        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets ParentWorkflowId
        /// </summary>
        [DataMember(Name="parentWorkflowId", EmitDefaultValue=false)]
        public string ParentWorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets ParentWorkflowTaskId
        /// </summary>
        [DataMember(Name="parentWorkflowTaskId", EmitDefaultValue=false)]
        public string ParentWorkflowTaskId { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name="tasks", EmitDefaultValue=false)]
        public List<Task> Tasks { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public Dictionary<string, Object> Input { get; set; }

        /// <summary>
        /// Gets or Sets Output
        /// </summary>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public Dictionary<string, Object> Output { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowType
        /// </summary>
        [DataMember(Name="workflowType", EmitDefaultValue=false)]
        public string WorkflowType { get; set; }

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
        /// Gets or Sets ReRunFromWorkflowId
        /// </summary>
        [DataMember(Name="reRunFromWorkflowId", EmitDefaultValue=false)]
        public string ReRunFromWorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets ReasonForIncompletion
        /// </summary>
        [DataMember(Name="reasonForIncompletion", EmitDefaultValue=false)]
        public string ReasonForIncompletion { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name="schemaVersion", EmitDefaultValue=false)]
        public int? SchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Event { get; set; }

        /// <summary>
        /// Gets or Sets TaskToDomain
        /// </summary>
        [DataMember(Name="taskToDomain", EmitDefaultValue=false)]
        public Dictionary<string, string> TaskToDomain { get; set; }

        /// <summary>
        /// Gets or Sets FailedReferenceTaskNames
        /// </summary>
        [DataMember(Name="failedReferenceTaskNames", EmitDefaultValue=false)]
        public List<string> FailedReferenceTaskNames { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowDefinition
        /// </summary>
        [DataMember(Name="workflowDefinition", EmitDefaultValue=false)]
        public WorkflowDef WorkflowDefinition { get; set; }

        /// <summary>
        /// Gets or Sets ExternalInputPayloadStoragePath
        /// </summary>
        [DataMember(Name="externalInputPayloadStoragePath", EmitDefaultValue=false)]
        public string ExternalInputPayloadStoragePath { get; set; }

        /// <summary>
        /// Gets or Sets ExternalOutputPayloadStoragePath
        /// </summary>
        [DataMember(Name="externalOutputPayloadStoragePath", EmitDefaultValue=false)]
        public string ExternalOutputPayloadStoragePath { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowName
        /// </summary>
        [DataMember(Name="workflowName", EmitDefaultValue=false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowVersion
        /// </summary>
        [DataMember(Name="workflowVersion", EmitDefaultValue=false)]
        public int? WorkflowVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workflow {\n");
            sb.Append("  OwnerApp: ").Append(OwnerApp).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  ParentWorkflowId: ").Append(ParentWorkflowId).Append("\n");
            sb.Append("  ParentWorkflowTaskId: ").Append(ParentWorkflowTaskId).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  WorkflowType: ").Append(WorkflowType).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ReRunFromWorkflowId: ").Append(ReRunFromWorkflowId).Append("\n");
            sb.Append("  ReasonForIncompletion: ").Append(ReasonForIncompletion).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  TaskToDomain: ").Append(TaskToDomain).Append("\n");
            sb.Append("  FailedReferenceTaskNames: ").Append(FailedReferenceTaskNames).Append("\n");
            sb.Append("  WorkflowDefinition: ").Append(WorkflowDefinition).Append("\n");
            sb.Append("  ExternalInputPayloadStoragePath: ").Append(ExternalInputPayloadStoragePath).Append("\n");
            sb.Append("  ExternalOutputPayloadStoragePath: ").Append(ExternalOutputPayloadStoragePath).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  WorkflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("  WorkflowVersion: ").Append(WorkflowVersion).Append("\n");
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
            return this.Equals(input as Workflow);
        }

        /// <summary>
        /// Returns true if Workflow instances are equal
        /// </summary>
        /// <param name="input">Instance of Workflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Workflow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerApp == input.OwnerApp ||
                    (this.OwnerApp != null &&
                    this.OwnerApp.Equals(input.OwnerApp))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.ParentWorkflowId == input.ParentWorkflowId ||
                    (this.ParentWorkflowId != null &&
                    this.ParentWorkflowId.Equals(input.ParentWorkflowId))
                ) && 
                (
                    this.ParentWorkflowTaskId == input.ParentWorkflowTaskId ||
                    (this.ParentWorkflowTaskId != null &&
                    this.ParentWorkflowTaskId.Equals(input.ParentWorkflowTaskId))
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) && 
                (
                    this.Input == input.Input ||
                    this.Input != null &&
                    this.Input.SequenceEqual(input.Input)
                ) && 
                (
                    this.Output == input.Output ||
                    this.Output != null &&
                    this.Output.SequenceEqual(input.Output)
                ) && 
                (
                    this.WorkflowType == input.WorkflowType ||
                    (this.WorkflowType != null &&
                    this.WorkflowType.Equals(input.WorkflowType))
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
                    this.ReRunFromWorkflowId == input.ReRunFromWorkflowId ||
                    (this.ReRunFromWorkflowId != null &&
                    this.ReRunFromWorkflowId.Equals(input.ReRunFromWorkflowId))
                ) && 
                (
                    this.ReasonForIncompletion == input.ReasonForIncompletion ||
                    (this.ReasonForIncompletion != null &&
                    this.ReasonForIncompletion.Equals(input.ReasonForIncompletion))
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    (this.SchemaVersion != null &&
                    this.SchemaVersion.Equals(input.SchemaVersion))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.TaskToDomain == input.TaskToDomain ||
                    this.TaskToDomain != null &&
                    this.TaskToDomain.SequenceEqual(input.TaskToDomain)
                ) && 
                (
                    this.FailedReferenceTaskNames == input.FailedReferenceTaskNames ||
                    this.FailedReferenceTaskNames != null &&
                    this.FailedReferenceTaskNames.SequenceEqual(input.FailedReferenceTaskNames)
                ) && 
                (
                    this.WorkflowDefinition == input.WorkflowDefinition ||
                    (this.WorkflowDefinition != null &&
                    this.WorkflowDefinition.Equals(input.WorkflowDefinition))
                ) && 
                (
                    this.ExternalInputPayloadStoragePath == input.ExternalInputPayloadStoragePath ||
                    (this.ExternalInputPayloadStoragePath != null &&
                    this.ExternalInputPayloadStoragePath.Equals(input.ExternalInputPayloadStoragePath))
                ) && 
                (
                    this.ExternalOutputPayloadStoragePath == input.ExternalOutputPayloadStoragePath ||
                    (this.ExternalOutputPayloadStoragePath != null &&
                    this.ExternalOutputPayloadStoragePath.Equals(input.ExternalOutputPayloadStoragePath))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
                ) && 
                (
                    this.WorkflowVersion == input.WorkflowVersion ||
                    (this.WorkflowVersion != null &&
                    this.WorkflowVersion.Equals(input.WorkflowVersion))
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
                if (this.OwnerApp != null)
                    hashCode = hashCode * 59 + this.OwnerApp.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.ParentWorkflowId != null)
                    hashCode = hashCode * 59 + this.ParentWorkflowId.GetHashCode();
                if (this.ParentWorkflowTaskId != null)
                    hashCode = hashCode * 59 + this.ParentWorkflowTaskId.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
                if (this.WorkflowType != null)
                    hashCode = hashCode * 59 + this.WorkflowType.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CorrelationId != null)
                    hashCode = hashCode * 59 + this.CorrelationId.GetHashCode();
                if (this.ReRunFromWorkflowId != null)
                    hashCode = hashCode * 59 + this.ReRunFromWorkflowId.GetHashCode();
                if (this.ReasonForIncompletion != null)
                    hashCode = hashCode * 59 + this.ReasonForIncompletion.GetHashCode();
                if (this.SchemaVersion != null)
                    hashCode = hashCode * 59 + this.SchemaVersion.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.TaskToDomain != null)
                    hashCode = hashCode * 59 + this.TaskToDomain.GetHashCode();
                if (this.FailedReferenceTaskNames != null)
                    hashCode = hashCode * 59 + this.FailedReferenceTaskNames.GetHashCode();
                if (this.WorkflowDefinition != null)
                    hashCode = hashCode * 59 + this.WorkflowDefinition.GetHashCode();
                if (this.ExternalInputPayloadStoragePath != null)
                    hashCode = hashCode * 59 + this.ExternalInputPayloadStoragePath.GetHashCode();
                if (this.ExternalOutputPayloadStoragePath != null)
                    hashCode = hashCode * 59 + this.ExternalOutputPayloadStoragePath.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.WorkflowName != null)
                    hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                if (this.WorkflowVersion != null)
                    hashCode = hashCode * 59 + this.WorkflowVersion.GetHashCode();
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
