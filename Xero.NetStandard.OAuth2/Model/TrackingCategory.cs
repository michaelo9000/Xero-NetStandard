/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.9
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model
{
    /// <summary>
    /// TrackingCategory
    /// </summary>
    [DataContract]
    public partial class TrackingCategory :  IEquatable<TrackingCategory>, IValidatableObject
    {
        /// <summary>
        /// The status of a tracking category
        /// </summary>
        /// <value>The status of a tracking category</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 2,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 3

        }

        /// <summary>
        /// The status of a tracking category
        /// </summary>
        /// <value>The status of a tracking category</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// The Xero identifier for a tracking category e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9
        /// </summary>
        /// <value>The Xero identifier for a tracking category e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9</value>
        [DataMember(Name="TrackingCategoryID", EmitDefaultValue=false)]
        public Guid? TrackingCategoryID { get; set; }

        /// <summary>
        /// The Xero identifier for a tracking option e.g. dc54c220-0140-495a-b925-3246adc0075f
        /// </summary>
        /// <value>The Xero identifier for a tracking option e.g. dc54c220-0140-495a-b925-3246adc0075f</value>
        [DataMember(Name="TrackingOptionID", EmitDefaultValue=false)]
        public Guid? TrackingOptionID { get; set; }

        /// <summary>
        /// The name of the tracking category e.g. Department, Region (max length &#x3D; 100)
        /// </summary>
        /// <value>The name of the tracking category e.g. Department, Region (max length &#x3D; 100)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The option name of the tracking option e.g. East, West (max length &#x3D; 100)
        /// </summary>
        /// <value>The option name of the tracking option e.g. East, West (max length &#x3D; 100)</value>
        [DataMember(Name="Option", EmitDefaultValue=false)]
        public string Option { get; set; }

        /// <summary>
        /// See Tracking Options
        /// </summary>
        /// <value>See Tracking Options</value>
        [DataMember(Name="Options", EmitDefaultValue=false)]
        public List<TrackingOption> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingCategory {\n");
            sb.Append("  TrackingCategoryID: ").Append(TrackingCategoryID).Append("\n");
            sb.Append("  TrackingOptionID: ").Append(TrackingOptionID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as TrackingCategory);
        }

        /// <summary>
        /// Returns true if TrackingCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackingCategoryID == input.TrackingCategoryID ||
                    (this.TrackingCategoryID != null &&
                    this.TrackingCategoryID.Equals(input.TrackingCategoryID))
                ) && 
                (
                    this.TrackingOptionID == input.TrackingOptionID ||
                    (this.TrackingOptionID != null &&
                    this.TrackingOptionID.Equals(input.TrackingOptionID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.TrackingCategoryID != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryID.GetHashCode();
                if (this.TrackingOptionID != null)
                    hashCode = hashCode * 59 + this.TrackingOptionID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Option (string) maxLength
            if(this.Option != null && this.Option.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Option, length must be less than 100.", new [] { "Option" });
            }

            yield break;
        }
    }

}
