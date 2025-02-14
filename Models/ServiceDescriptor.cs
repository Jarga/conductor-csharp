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
    /// ServiceDescriptor
    /// </summary>
    [DataContract]
    public partial class ServiceDescriptor :  IEquatable<ServiceDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDescriptor" /> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="_file">_file.</param>
        /// <param name="methods">methods.</param>
        /// <param name="options">options.</param>
        /// <param name="name">name.</param>
        public ServiceDescriptor(int? index = default(int?), string fullName = default(string), FileDescriptor _file = default(FileDescriptor), List<MethodDescriptor> methods = default(List<MethodDescriptor>), ServiceOptions options = default(ServiceOptions), string name = default(string))
        {
            this.Index = index;
            this.FullName = fullName;
            this._File = _file;
            this.Methods = methods;
            this.Options = options;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets _File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public FileDescriptor _File { get; set; }

        /// <summary>
        /// Gets or Sets Methods
        /// </summary>
        [DataMember(Name="methods", EmitDefaultValue=false)]
        public List<MethodDescriptor> Methods { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public ServiceOptions Options { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceDescriptor {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  _File: ").Append(_File).Append("\n");
            sb.Append("  Methods: ").Append(Methods).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ServiceDescriptor);
        }

        /// <summary>
        /// Returns true if ServiceDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this._File == input._File ||
                    (this._File != null &&
                    this._File.Equals(input._File))
                ) && 
                (
                    this.Methods == input.Methods ||
                    this.Methods != null &&
                    this.Methods.SequenceEqual(input.Methods)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this._File != null)
                    hashCode = hashCode * 59 + this._File.GetHashCode();
                if (this.Methods != null)
                    hashCode = hashCode * 59 + this.Methods.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
