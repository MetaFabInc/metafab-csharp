/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: metafabproject@gmail.com
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
using OpenAPIDateConverter = Org.MetaFab.Client.OpenAPIDateConverter;

namespace Org.MetaFab.Model
{
    /// <summary>
    /// GetCurrencyFees200Response
    /// </summary>
    [DataContract]
    public partial class GetCurrencyFees200Response :  IEquatable<GetCurrencyFees200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrencyFees200Response" /> class.
        /// </summary>
        /// <param name="recipientAddress">The wallet address that fees from all applicable transactions are automatically sent to..</param>
        /// <param name="basisPoints">The number of fee basis points. 100 basisPoints &#x3D; 1% fee of the total transaction amount deducted from the total received by the recipient..</param>
        /// <param name="fixedAmount">The fixed number of currency as a fee regardless of the total transaction amount. 10 &#x3D; 10 of the currency as a fee for any transaction, deducted from the total received by the recipient..</param>
        /// <param name="capAmount">The maximum combined fee between basisPoints and fixedAmount. If the total transaction fee is over this amount, the capAmount will be used as the transaction fee deducted from the total received by the recipient..</param>
        public GetCurrencyFees200Response(string recipientAddress = default(string), decimal basisPoints = default(decimal), decimal fixedAmount = default(decimal), decimal capAmount = default(decimal))
        {
            this.RecipientAddress = recipientAddress;
            this.BasisPoints = basisPoints;
            this.FixedAmount = fixedAmount;
            this.CapAmount = capAmount;
        }

        /// <summary>
        /// The wallet address that fees from all applicable transactions are automatically sent to.
        /// </summary>
        /// <value>The wallet address that fees from all applicable transactions are automatically sent to.</value>
        [DataMember(Name="recipientAddress", EmitDefaultValue=false)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// The number of fee basis points. 100 basisPoints &#x3D; 1% fee of the total transaction amount deducted from the total received by the recipient.
        /// </summary>
        /// <value>The number of fee basis points. 100 basisPoints &#x3D; 1% fee of the total transaction amount deducted from the total received by the recipient.</value>
        [DataMember(Name="basisPoints", EmitDefaultValue=false)]
        public decimal BasisPoints { get; set; }

        /// <summary>
        /// The fixed number of currency as a fee regardless of the total transaction amount. 10 &#x3D; 10 of the currency as a fee for any transaction, deducted from the total received by the recipient.
        /// </summary>
        /// <value>The fixed number of currency as a fee regardless of the total transaction amount. 10 &#x3D; 10 of the currency as a fee for any transaction, deducted from the total received by the recipient.</value>
        [DataMember(Name="fixedAmount", EmitDefaultValue=false)]
        public decimal FixedAmount { get; set; }

        /// <summary>
        /// The maximum combined fee between basisPoints and fixedAmount. If the total transaction fee is over this amount, the capAmount will be used as the transaction fee deducted from the total received by the recipient.
        /// </summary>
        /// <value>The maximum combined fee between basisPoints and fixedAmount. If the total transaction fee is over this amount, the capAmount will be used as the transaction fee deducted from the total received by the recipient.</value>
        [DataMember(Name="capAmount", EmitDefaultValue=false)]
        public decimal CapAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCurrencyFees200Response {\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  BasisPoints: ").Append(BasisPoints).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
            sb.Append("  CapAmount: ").Append(CapAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCurrencyFees200Response);
        }

        /// <summary>
        /// Returns true if GetCurrencyFees200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCurrencyFees200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCurrencyFees200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.BasisPoints == input.BasisPoints ||
                    (this.BasisPoints != null &&
                    this.BasisPoints.Equals(input.BasisPoints))
                ) && 
                (
                    this.FixedAmount == input.FixedAmount ||
                    (this.FixedAmount != null &&
                    this.FixedAmount.Equals(input.FixedAmount))
                ) && 
                (
                    this.CapAmount == input.CapAmount ||
                    (this.CapAmount != null &&
                    this.CapAmount.Equals(input.CapAmount))
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
                if (this.RecipientAddress != null)
                    hashCode = hashCode * 59 + this.RecipientAddress.GetHashCode();
                if (this.BasisPoints != null)
                    hashCode = hashCode * 59 + this.BasisPoints.GetHashCode();
                if (this.FixedAmount != null)
                    hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
                if (this.CapAmount != null)
                    hashCode = hashCode * 59 + this.CapAmount.GetHashCode();
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
