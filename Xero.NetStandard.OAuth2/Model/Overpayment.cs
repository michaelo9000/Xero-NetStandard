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
    /// Overpayment
    /// </summary>
    [DataContract]
    public partial class Overpayment :  IEquatable<Overpayment>, IValidatableObject
    {
        /// <summary>
        /// See Overpayment Types
        /// </summary>
        /// <value>See Overpayment Types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum RECEIVEOVERPAYMENT for value: RECEIVE-OVERPAYMENT
            /// </summary>
            [EnumMember(Value = "RECEIVE-OVERPAYMENT")]
            RECEIVEOVERPAYMENT = 1,

            /// <summary>
            /// Enum SPENDOVERPAYMENT for value: SPEND-OVERPAYMENT
            /// </summary>
            [EnumMember(Value = "SPEND-OVERPAYMENT")]
            SPENDOVERPAYMENT = 2,

            /// <summary>
            /// Enum AROVERPAYMENT for value: AROVERPAYMENT
            /// </summary>
            [EnumMember(Value = "AROVERPAYMENT")]
            AROVERPAYMENT = 3

        }

        /// <summary>
        /// See Overpayment Types
        /// </summary>
        /// <value>See Overpayment Types</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// See Overpayment Status Codes
        /// </summary>
        /// <value>See Overpayment Status Codes</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 1,

            /// <summary>
            /// Enum PAID for value: PAID
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID = 2,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 3

        }

        /// <summary>
        /// See Overpayment Status Codes
        /// </summary>
        /// <value>See Overpayment Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Gets or Sets LineAmountTypes
        /// </summary>
        [DataMember(Name="LineAmountTypes", EmitDefaultValue=false)]
        public LineAmountTypes LineAmountTypes { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The date the overpayment is created YYYY-MM-DD
        /// </summary>
        /// <value>The date the overpayment is created YYYY-MM-DD</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// See Overpayment Line Items
        /// </summary>
        /// <value>See Overpayment Line Items</value>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// The subtotal of the overpayment excluding taxes
        /// </summary>
        /// <value>The subtotal of the overpayment excluding taxes</value>
        [DataMember(Name="SubTotal", EmitDefaultValue=false)]
        public double? SubTotal { get; set; }

        /// <summary>
        /// The total tax on the overpayment
        /// </summary>
        /// <value>The total tax on the overpayment</value>
        [DataMember(Name="TotalTax", EmitDefaultValue=false)]
        public double? TotalTax { get; set; }

        /// <summary>
        /// The total of the overpayment (subtotal + total tax)
        /// </summary>
        /// <value>The total of the overpayment (subtotal + total tax)</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public double? Total { get; set; }

        /// <summary>
        /// UTC timestamp of last update to the overpayment
        /// </summary>
        /// <value>UTC timestamp of last update to the overpayment</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Xero generated unique identifier
        /// </summary>
        /// <value>Xero generated unique identifier</value>
        [DataMember(Name="OverpaymentID", EmitDefaultValue=false)]
        public Guid? OverpaymentID { get; set; }

        /// <summary>
        /// The currency rate for a multicurrency overpayment. If no rate is specified, the XE.com day rate is used
        /// </summary>
        /// <value>The currency rate for a multicurrency overpayment. If no rate is specified, the XE.com day rate is used</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public double? CurrencyRate { get; set; }

        /// <summary>
        /// The remaining credit balance on the overpayment
        /// </summary>
        /// <value>The remaining credit balance on the overpayment</value>
        [DataMember(Name="RemainingCredit", EmitDefaultValue=false)]
        public double? RemainingCredit { get; set; }

        /// <summary>
        /// See Allocations
        /// </summary>
        /// <value>See Allocations</value>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<Allocation> Allocations { get; set; }

        /// <summary>
        /// The amount of applied to an invoice
        /// </summary>
        /// <value>The amount of applied to an invoice</value>
        [DataMember(Name="AppliedAmount", EmitDefaultValue=false)]
        public double? AppliedAmount { get; set; }

        /// <summary>
        /// See Payments
        /// </summary>
        /// <value>See Payments</value>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// boolean to indicate if a overpayment has an attachment
        /// </summary>
        /// <value>boolean to indicate if a overpayment has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; private set; }

        /// <summary>
        /// See Attachments
        /// </summary>
        /// <value>See Attachments</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Overpayment {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LineAmountTypes: ").Append(LineAmountTypes).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  OverpaymentID: ").Append(OverpaymentID).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  RemainingCredit: ").Append(RemainingCredit).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  AppliedAmount: ").Append(AppliedAmount).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as Overpayment);
        }

        /// <summary>
        /// Returns true if Overpayment instances are equal
        /// </summary>
        /// <param name="input">Instance of Overpayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Overpayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.LineAmountTypes == input.LineAmountTypes ||
                    this.LineAmountTypes.Equals(input.LineAmountTypes)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    this.SubTotal.Equals(input.SubTotal)
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    this.TotalTax.Equals(input.TotalTax)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.OverpaymentID == input.OverpaymentID ||
                    (this.OverpaymentID != null &&
                    this.OverpaymentID.Equals(input.OverpaymentID))
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    this.CurrencyRate.Equals(input.CurrencyRate)
                ) && 
                (
                    this.RemainingCredit == input.RemainingCredit ||
                    this.RemainingCredit.Equals(input.RemainingCredit)
                ) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    input.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && 
                (
                    this.AppliedAmount == input.AppliedAmount ||
                    this.AppliedAmount.Equals(input.AppliedAmount)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    this.HasAttachments.Equals(input.HasAttachments)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmountTypes.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                hashCode = hashCode * 59 + this.TotalTax.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.OverpaymentID != null)
                    hashCode = hashCode * 59 + this.OverpaymentID.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                hashCode = hashCode * 59 + this.RemainingCredit.GetHashCode();
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                hashCode = hashCode * 59 + this.AppliedAmount.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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
