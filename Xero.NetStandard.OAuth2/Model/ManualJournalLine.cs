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
    /// ManualJournalLine
    /// </summary>
    [DataContract]
    public partial class ManualJournalLine :  IEquatable<ManualJournalLine>, IValidatableObject
    {
        
        /// <summary>
        /// total for line. Debits are positive, credits are negative value
        /// </summary>
        /// <value>total for line. Debits are positive, credits are negative value</value>
        [DataMember(Name="LineAmount", EmitDefaultValue=false)]
        public double? LineAmount { get; set; }

        /// <summary>
        /// See Accounts
        /// </summary>
        /// <value>See Accounts</value>
        [DataMember(Name="AccountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// Description for journal line
        /// </summary>
        /// <value>Description for journal line</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The tax type from TaxRates
        /// </summary>
        /// <value>The tax type from TaxRates</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public string TaxType { get; set; }

        /// <summary>
        /// Optional Tracking Category – see Tracking. Any JournalLine can have a maximum of 2 &lt;TrackingCategory&gt; elements.
        /// </summary>
        /// <value>Optional Tracking Category – see Tracking. Any JournalLine can have a maximum of 2 &lt;TrackingCategory&gt; elements.</value>
        [DataMember(Name="Tracking", EmitDefaultValue=false)]
        public List<TrackingCategory> Tracking { get; set; }

        /// <summary>
        /// The calculated tax amount based on the TaxType and LineAmount
        /// </summary>
        /// <value>The calculated tax amount based on the TaxType and LineAmount</value>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public double? TaxAmount { get; private set; }

        /// <summary>
        /// is the line blank
        /// </summary>
        /// <value>is the line blank</value>
        [DataMember(Name="IsBlank", EmitDefaultValue=false)]
        public bool? IsBlank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualJournalLine {\n");
            sb.Append("  LineAmount: ").Append(LineAmount).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  Tracking: ").Append(Tracking).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  IsBlank: ").Append(IsBlank).Append("\n");
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
            return this.Equals(input as ManualJournalLine);
        }

        /// <summary>
        /// Returns true if ManualJournalLine instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualJournalLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualJournalLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineAmount == input.LineAmount ||
                    this.LineAmount.Equals(input.LineAmount)
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.Tracking == input.Tracking ||
                    this.Tracking != null &&
                    input.Tracking != null &&
                    this.Tracking.SequenceEqual(input.Tracking)
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    this.TaxAmount.Equals(input.TaxAmount)
                ) && 
                (
                    this.IsBlank == input.IsBlank ||
                    this.IsBlank.Equals(input.IsBlank)
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
                hashCode = hashCode * 59 + this.LineAmount.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                if (this.Tracking != null)
                    hashCode = hashCode * 59 + this.Tracking.GetHashCode();
                hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                hashCode = hashCode * 59 + this.IsBlank.GetHashCode();
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
