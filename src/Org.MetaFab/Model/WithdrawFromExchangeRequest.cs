/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// WithdrawFromExchangeRequest
    /// </summary>
    [DataContract]
    public partial class WithdrawFromExchangeRequest :  IEquatable<WithdrawFromExchangeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawFromExchangeRequest" /> class.
        /// </summary>
        /// <param name="address">A valid EVM based address to withdraw to. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;..</param>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem to withdraw to..</param>
        /// <param name="currencyAddress">The address of the currency (ERC20) token to withdraw from the exchange. If no currencyAddress or currencyId, and no collectionAddress or collectionId are provided, the native token held by the exchange will be withdrawn..</param>
        /// <param name="currencyId">A valid MetaFab currency id that represents the currency token to withdraw from the exchange. &#x60;currencyAddress&#x60; or &#x60;currencyId&#x60; can be provided when withdrawing currency..</param>
        /// <param name="collectionAddress">The address of the collection (ERC1155) for the items to withdraw from the exchange. If no currencyAddress and no collectionAddress is provided, the native token held by the exchange will be withdrawn..</param>
        /// <param name="collectionId">A valid MetaFab collection id that represents the collection for the items to withdraw from the exchange. &#x60;collectionAddress&#x60; or &#x60;collectionId&#x60; can be provided when withdrawing items..</param>
        /// <param name="itemIds">The specific itemIds of the provided collection to withdraw from the exchange..</param>
        public WithdrawFromExchangeRequest(string address = default(string), string walletId = default(string), string currencyAddress = default(string), string currencyId = default(string), string collectionAddress = default(string), string collectionId = default(string), List<decimal> itemIds = default(List<decimal>))
        {
            this.Address = address;
            this.WalletId = walletId;
            this.CurrencyAddress = currencyAddress;
            this.CurrencyId = currencyId;
            this.CollectionAddress = collectionAddress;
            this.CollectionId = collectionId;
            this.ItemIds = itemIds;
        }

        /// <summary>
        /// A valid EVM based address to withdraw to. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.
        /// </summary>
        /// <value>A valid EVM based address to withdraw to. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Any wallet id within the MetaFab ecosystem to withdraw to.
        /// </summary>
        /// <value>Any wallet id within the MetaFab ecosystem to withdraw to.</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// The address of the currency (ERC20) token to withdraw from the exchange. If no currencyAddress or currencyId, and no collectionAddress or collectionId are provided, the native token held by the exchange will be withdrawn.
        /// </summary>
        /// <value>The address of the currency (ERC20) token to withdraw from the exchange. If no currencyAddress or currencyId, and no collectionAddress or collectionId are provided, the native token held by the exchange will be withdrawn.</value>
        [DataMember(Name="currencyAddress", EmitDefaultValue=false)]
        public string CurrencyAddress { get; set; }

        /// <summary>
        /// A valid MetaFab currency id that represents the currency token to withdraw from the exchange. &#x60;currencyAddress&#x60; or &#x60;currencyId&#x60; can be provided when withdrawing currency.
        /// </summary>
        /// <value>A valid MetaFab currency id that represents the currency token to withdraw from the exchange. &#x60;currencyAddress&#x60; or &#x60;currencyId&#x60; can be provided when withdrawing currency.</value>
        [DataMember(Name="currencyId", EmitDefaultValue=false)]
        public string CurrencyId { get; set; }

        /// <summary>
        /// The address of the collection (ERC1155) for the items to withdraw from the exchange. If no currencyAddress and no collectionAddress is provided, the native token held by the exchange will be withdrawn.
        /// </summary>
        /// <value>The address of the collection (ERC1155) for the items to withdraw from the exchange. If no currencyAddress and no collectionAddress is provided, the native token held by the exchange will be withdrawn.</value>
        [DataMember(Name="collectionAddress", EmitDefaultValue=false)]
        public string CollectionAddress { get; set; }

        /// <summary>
        /// A valid MetaFab collection id that represents the collection for the items to withdraw from the exchange. &#x60;collectionAddress&#x60; or &#x60;collectionId&#x60; can be provided when withdrawing items.
        /// </summary>
        /// <value>A valid MetaFab collection id that represents the collection for the items to withdraw from the exchange. &#x60;collectionAddress&#x60; or &#x60;collectionId&#x60; can be provided when withdrawing items.</value>
        [DataMember(Name="collectionId", EmitDefaultValue=false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// The specific itemIds of the provided collection to withdraw from the exchange.
        /// </summary>
        /// <value>The specific itemIds of the provided collection to withdraw from the exchange.</value>
        [DataMember(Name="itemIds", EmitDefaultValue=false)]
        public List<decimal> ItemIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WithdrawFromExchangeRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  CurrencyAddress: ").Append(CurrencyAddress).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CollectionAddress: ").Append(CollectionAddress).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
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
            return this.Equals(input as WithdrawFromExchangeRequest);
        }

        /// <summary>
        /// Returns true if WithdrawFromExchangeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WithdrawFromExchangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithdrawFromExchangeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.CurrencyAddress == input.CurrencyAddress ||
                    (this.CurrencyAddress != null &&
                    this.CurrencyAddress.Equals(input.CurrencyAddress))
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    (this.CurrencyId != null &&
                    this.CurrencyId.Equals(input.CurrencyId))
                ) && 
                (
                    this.CollectionAddress == input.CollectionAddress ||
                    (this.CollectionAddress != null &&
                    this.CollectionAddress.Equals(input.CollectionAddress))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.CurrencyAddress != null)
                    hashCode = hashCode * 59 + this.CurrencyAddress.GetHashCode();
                if (this.CurrencyId != null)
                    hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.CollectionAddress != null)
                    hashCode = hashCode * 59 + this.CollectionAddress.GetHashCode();
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.ItemIds != null)
                    hashCode = hashCode * 59 + this.ItemIds.GetHashCode();
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
