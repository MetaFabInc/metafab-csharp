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
    /// BatchTransferCurrencyRequest
    /// </summary>
    [DataContract]
    public partial class BatchTransferCurrencyRequest :  IEquatable<BatchTransferCurrencyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTransferCurrencyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchTransferCurrencyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTransferCurrencyRequest" /> class.
        /// </summary>
        /// <param name="addresses">An array of valid EVM based addresses to transfer currency to..</param>
        /// <param name="walletIds">An array of wallet ids within the MetaFab ecosystem to transfer currency to..</param>
        /// <param name="amounts">An array of currency amounts to transfer. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; and/or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order. (required).</param>
        /// <param name="references">An optional array of uint256 numbers to reference each transfer in the batch. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order..</param>
        public BatchTransferCurrencyRequest(List<string> addresses = default(List<string>), List<string> walletIds = default(List<string>), List<decimal> amounts = default(List<decimal>), List<decimal> references = default(List<decimal>))
        {
            // to ensure "amounts" is required (not null)
            if (amounts == null)
            {
                throw new InvalidDataException("amounts is a required property for BatchTransferCurrencyRequest and cannot be null");
            }
            else
            {
                this.Amounts = amounts;
            }

            this.Addresses = addresses;
            this.WalletIds = walletIds;
            this.References = references;
        }

        /// <summary>
        /// An array of valid EVM based addresses to transfer currency to.
        /// </summary>
        /// <value>An array of valid EVM based addresses to transfer currency to.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// An array of wallet ids within the MetaFab ecosystem to transfer currency to.
        /// </summary>
        /// <value>An array of wallet ids within the MetaFab ecosystem to transfer currency to.</value>
        [DataMember(Name="walletIds", EmitDefaultValue=false)]
        public List<string> WalletIds { get; set; }

        /// <summary>
        /// An array of currency amounts to transfer. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; and/or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order.
        /// </summary>
        /// <value>An array of currency amounts to transfer. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; and/or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order.</value>
        [DataMember(Name="amounts", EmitDefaultValue=true)]
        public List<decimal> Amounts { get; set; }

        /// <summary>
        /// An optional array of uint256 numbers to reference each transfer in the batch. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order.
        /// </summary>
        /// <value>An optional array of uint256 numbers to reference each transfer in the batch. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order.</value>
        [DataMember(Name="references", EmitDefaultValue=false)]
        public List<decimal> References { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchTransferCurrencyRequest {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  WalletIds: ").Append(WalletIds).Append("\n");
            sb.Append("  Amounts: ").Append(Amounts).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
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
            return this.Equals(input as BatchTransferCurrencyRequest);
        }

        /// <summary>
        /// Returns true if BatchTransferCurrencyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchTransferCurrencyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchTransferCurrencyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.WalletIds == input.WalletIds ||
                    this.WalletIds != null &&
                    input.WalletIds != null &&
                    this.WalletIds.SequenceEqual(input.WalletIds)
                ) && 
                (
                    this.Amounts == input.Amounts ||
                    this.Amounts != null &&
                    input.Amounts != null &&
                    this.Amounts.SequenceEqual(input.Amounts)
                ) && 
                (
                    this.References == input.References ||
                    this.References != null &&
                    input.References != null &&
                    this.References.SequenceEqual(input.References)
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
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.WalletIds != null)
                    hashCode = hashCode * 59 + this.WalletIds.GetHashCode();
                if (this.Amounts != null)
                    hashCode = hashCode * 59 + this.Amounts.GetHashCode();
                if (this.References != null)
                    hashCode = hashCode * 59 + this.References.GetHashCode();
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
