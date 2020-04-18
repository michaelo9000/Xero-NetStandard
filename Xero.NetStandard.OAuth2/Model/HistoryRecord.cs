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
    /// HistoryRecord
    /// </summary>
    [DataContract]
    public partial class HistoryRecord :  IEquatable<HistoryRecord>, IValidatableObject
    {
        
        /// <summary>
        /// details
        /// </summary>
        /// <value>details</value>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Name of branding theme
        /// </summary>
        /// <value>Name of branding theme</value>
        [DataMember(Name="Changes", EmitDefaultValue=false)]
        public string Changes { get; set; }

        /// <summary>
        /// has a value of 0
        /// </summary>
        /// <value>has a value of 0</value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// UTC timestamp of creation date of branding theme
        /// </summary>
        /// <value>UTC timestamp of creation date of branding theme</value>
        [DataMember(Name="DateUTC", EmitDefaultValue=false)]
        public DateTime? DateUTC { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryRecord {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  DateUTC: ").Append(DateUTC).Append("\n");
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
            return this.Equals(input as HistoryRecord);
        }

        /// <summary>
        /// Returns true if HistoryRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Changes == input.Changes ||
                    (this.Changes != null &&
                    this.Changes.Equals(input.Changes))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.DateUTC == input.DateUTC ||
                    (this.DateUTC != null &&
                    this.DateUTC.Equals(input.DateUTC))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Changes != null)
                    hashCode = hashCode * 59 + this.Changes.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.DateUTC != null)
                    hashCode = hashCode * 59 + this.DateUTC.GetHashCode();
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
