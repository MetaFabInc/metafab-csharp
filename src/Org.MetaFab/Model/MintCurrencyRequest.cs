/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.4.0
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
    /// MintCurrencyRequest
    /// </summary>
    [DataContract]
    public partial class MintCurrencyRequest :  IEquatable<MintCurrencyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MintCurrencyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MintCurrencyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintCurrencyRequest" /> class.
        /// </summary>
        /// <param name="amount">The amount of currency to create (mint). (required).</param>
        /// <param name="address">A valid EVM based address to create (mint) currency for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;..</param>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem to create (mint) currency for..</param>
        public MintCurrencyRequest(decimal amount = default(decimal), string address = default(string), string walletId = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for MintCurrencyRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            this.Address = address;
            this.WalletId = walletId;
        }

        /// <summary>
        /// The amount of currency to create (mint).
        /// </summary>
        /// <value>The amount of currency to create (mint).</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// A valid EVM based address to create (mint) currency for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.
        /// </summary>
        /// <value>A valid EVM based address to create (mint) currency for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Any wallet id within the MetaFab ecosystem to create (mint) currency for.
        /// </summary>
        /// <value>Any wallet id within the MetaFab ecosystem to create (mint) currency for.</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MintCurrencyRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
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
            return this.Equals(input as MintCurrencyRequest);
        }

        /// <summary>
        /// Returns true if MintCurrencyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MintCurrencyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MintCurrencyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
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
