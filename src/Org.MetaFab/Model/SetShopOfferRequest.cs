/*
 * MetaFab API
 *
 * Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.5.1
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
    /// SetShopOfferRequest
    /// </summary>
    [DataContract]
    public partial class SetShopOfferRequest :  IEquatable<SetShopOfferRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetShopOfferRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetShopOfferRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetShopOfferRequest" /> class.
        /// </summary>
        /// <param name="id">A unique offer id to use for this offer for the shop. If an existing offer id is used, the current offer will be updated but the existing number of uses will be kept. If you want to reset the number of uses for an existing offer, first remove it using the remove offer endpoint, then set it. (required).</param>
        /// <param name="inputCollectionAddress">A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for input items required by this offer. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided..</param>
        /// <param name="inputCollectionId">A valid MetaFab collection id that represents the collection for input items required by this offer. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided..</param>
        /// <param name="inputCollectionItemIds">An array of item ids from the provided input collection that are required to use this offer. Input items are transferred from the wallet to the shop contract upon using an offer..</param>
        /// <param name="inputCollectionItemAmounts">An array of amounts for each item id from the provided input collection that are required to use this offer. Item amounts array indices are reflective of the amount required for a given item id at the same index..</param>
        /// <param name="inputCurrencyAddress">A valid EVM based ERC20 or MetaFab game currency contract address that for the currency required by this offer..</param>
        /// <param name="inputCurrencyId">A valid MetaFab currency id that represents the currency required by this offer..</param>
        /// <param name="inputCurrencyAmount">The amount of currency required by this offer. If an inputCurrencyAmount is provided without in input currency address or id, the native chain currency is used as the required currency..</param>
        /// <param name="outputCollectionAddress">A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for output items given by this offer. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided..</param>
        /// <param name="outputCollectionId">A valid MetaFab collection id that represents the collection for output items given by this offer. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided..</param>
        /// <param name="outputCollectionItemIds">An array of item ids from the provided output collection that are given by this offer. Output items are automatically minted if the shop contract has the &#x60;minter&#x60; role for the output collection contract. Otherwise, they are transferred from the item balance held by the shop contract..</param>
        /// <param name="outputCollectionItemAmounts">An array of amounts for each item id from the provided output collection that are given by this offer. Item amounts array indices are reflective of the amount required for a given item id at the same index..</param>
        /// <param name="outputCurrencyAddress">A valid EVM based ERC20 or MetaFab game currency contract address that for the currency given by this offer. The output currency amount is automatically minted if the shop contract has the &#x60;minter&#x60; role for the output currency contract. Otherwise, they are transferred from the currency balance held by the shop contract..</param>
        /// <param name="outputCurrencyId">A valid MetaFab currency id for the currency given by this offer..</param>
        /// <param name="outputCurrencyAmount">The amount of currency given by this offer. If an outputCurrencyAmount is provided without an output currency address or id, the native chain currency is used as the given currency..</param>
        /// <param name="maxUses">The maximum number of times this offer can be used in total. maxUses is collective across all uses of the offer. If 5 unique players use an offer, that counts as 5 offer uses. Exclude this or use 0 to allow unlimited uses..</param>
        public SetShopOfferRequest(int id = default(int), string inputCollectionAddress = default(string), string inputCollectionId = default(string), List<int> inputCollectionItemIds = default(List<int>), List<int> inputCollectionItemAmounts = default(List<int>), string inputCurrencyAddress = default(string), string inputCurrencyId = default(string), decimal inputCurrencyAmount = default(decimal), string outputCollectionAddress = default(string), string outputCollectionId = default(string), List<int> outputCollectionItemIds = default(List<int>), List<int> outputCollectionItemAmounts = default(List<int>), string outputCurrencyAddress = default(string), string outputCurrencyId = default(string), decimal outputCurrencyAmount = default(decimal), int maxUses = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SetShopOfferRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            this.InputCollectionAddress = inputCollectionAddress;
            this.InputCollectionId = inputCollectionId;
            this.InputCollectionItemIds = inputCollectionItemIds;
            this.InputCollectionItemAmounts = inputCollectionItemAmounts;
            this.InputCurrencyAddress = inputCurrencyAddress;
            this.InputCurrencyId = inputCurrencyId;
            this.InputCurrencyAmount = inputCurrencyAmount;
            this.OutputCollectionAddress = outputCollectionAddress;
            this.OutputCollectionId = outputCollectionId;
            this.OutputCollectionItemIds = outputCollectionItemIds;
            this.OutputCollectionItemAmounts = outputCollectionItemAmounts;
            this.OutputCurrencyAddress = outputCurrencyAddress;
            this.OutputCurrencyId = outputCurrencyId;
            this.OutputCurrencyAmount = outputCurrencyAmount;
            this.MaxUses = maxUses;
        }

        /// <summary>
        /// A unique offer id to use for this offer for the shop. If an existing offer id is used, the current offer will be updated but the existing number of uses will be kept. If you want to reset the number of uses for an existing offer, first remove it using the remove offer endpoint, then set it.
        /// </summary>
        /// <value>A unique offer id to use for this offer for the shop. If an existing offer id is used, the current offer will be updated but the existing number of uses will be kept. If you want to reset the number of uses for an existing offer, first remove it using the remove offer endpoint, then set it.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for input items required by this offer. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided.
        /// </summary>
        /// <value>A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for input items required by this offer. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided.</value>
        [DataMember(Name="inputCollectionAddress", EmitDefaultValue=false)]
        public string InputCollectionAddress { get; set; }

        /// <summary>
        /// A valid MetaFab collection id that represents the collection for input items required by this offer. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided.
        /// </summary>
        /// <value>A valid MetaFab collection id that represents the collection for input items required by this offer. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided.</value>
        [DataMember(Name="inputCollectionId", EmitDefaultValue=false)]
        public string InputCollectionId { get; set; }

        /// <summary>
        /// An array of item ids from the provided input collection that are required to use this offer. Input items are transferred from the wallet to the shop contract upon using an offer.
        /// </summary>
        /// <value>An array of item ids from the provided input collection that are required to use this offer. Input items are transferred from the wallet to the shop contract upon using an offer.</value>
        [DataMember(Name="inputCollectionItemIds", EmitDefaultValue=false)]
        public List<int> InputCollectionItemIds { get; set; }

        /// <summary>
        /// An array of amounts for each item id from the provided input collection that are required to use this offer. Item amounts array indices are reflective of the amount required for a given item id at the same index.
        /// </summary>
        /// <value>An array of amounts for each item id from the provided input collection that are required to use this offer. Item amounts array indices are reflective of the amount required for a given item id at the same index.</value>
        [DataMember(Name="inputCollectionItemAmounts", EmitDefaultValue=false)]
        public List<int> InputCollectionItemAmounts { get; set; }

        /// <summary>
        /// A valid EVM based ERC20 or MetaFab game currency contract address that for the currency required by this offer.
        /// </summary>
        /// <value>A valid EVM based ERC20 or MetaFab game currency contract address that for the currency required by this offer.</value>
        [DataMember(Name="inputCurrencyAddress", EmitDefaultValue=false)]
        public string InputCurrencyAddress { get; set; }

        /// <summary>
        /// A valid MetaFab currency id that represents the currency required by this offer.
        /// </summary>
        /// <value>A valid MetaFab currency id that represents the currency required by this offer.</value>
        [DataMember(Name="inputCurrencyId", EmitDefaultValue=false)]
        public string InputCurrencyId { get; set; }

        /// <summary>
        /// The amount of currency required by this offer. If an inputCurrencyAmount is provided without in input currency address or id, the native chain currency is used as the required currency.
        /// </summary>
        /// <value>The amount of currency required by this offer. If an inputCurrencyAmount is provided without in input currency address or id, the native chain currency is used as the required currency.</value>
        [DataMember(Name="inputCurrencyAmount", EmitDefaultValue=false)]
        public decimal InputCurrencyAmount { get; set; }

        /// <summary>
        /// A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for output items given by this offer. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided.
        /// </summary>
        /// <value>A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for output items given by this offer. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided.</value>
        [DataMember(Name="outputCollectionAddress", EmitDefaultValue=false)]
        public string OutputCollectionAddress { get; set; }

        /// <summary>
        /// A valid MetaFab collection id that represents the collection for output items given by this offer. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided.
        /// </summary>
        /// <value>A valid MetaFab collection id that represents the collection for output items given by this offer. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided.</value>
        [DataMember(Name="outputCollectionId", EmitDefaultValue=false)]
        public string OutputCollectionId { get; set; }

        /// <summary>
        /// An array of item ids from the provided output collection that are given by this offer. Output items are automatically minted if the shop contract has the &#x60;minter&#x60; role for the output collection contract. Otherwise, they are transferred from the item balance held by the shop contract.
        /// </summary>
        /// <value>An array of item ids from the provided output collection that are given by this offer. Output items are automatically minted if the shop contract has the &#x60;minter&#x60; role for the output collection contract. Otherwise, they are transferred from the item balance held by the shop contract.</value>
        [DataMember(Name="outputCollectionItemIds", EmitDefaultValue=false)]
        public List<int> OutputCollectionItemIds { get; set; }

        /// <summary>
        /// An array of amounts for each item id from the provided output collection that are given by this offer. Item amounts array indices are reflective of the amount required for a given item id at the same index.
        /// </summary>
        /// <value>An array of amounts for each item id from the provided output collection that are given by this offer. Item amounts array indices are reflective of the amount required for a given item id at the same index.</value>
        [DataMember(Name="outputCollectionItemAmounts", EmitDefaultValue=false)]
        public List<int> OutputCollectionItemAmounts { get; set; }

        /// <summary>
        /// A valid EVM based ERC20 or MetaFab game currency contract address that for the currency given by this offer. The output currency amount is automatically minted if the shop contract has the &#x60;minter&#x60; role for the output currency contract. Otherwise, they are transferred from the currency balance held by the shop contract.
        /// </summary>
        /// <value>A valid EVM based ERC20 or MetaFab game currency contract address that for the currency given by this offer. The output currency amount is automatically minted if the shop contract has the &#x60;minter&#x60; role for the output currency contract. Otherwise, they are transferred from the currency balance held by the shop contract.</value>
        [DataMember(Name="outputCurrencyAddress", EmitDefaultValue=false)]
        public string OutputCurrencyAddress { get; set; }

        /// <summary>
        /// A valid MetaFab currency id for the currency given by this offer.
        /// </summary>
        /// <value>A valid MetaFab currency id for the currency given by this offer.</value>
        [DataMember(Name="outputCurrencyId", EmitDefaultValue=false)]
        public string OutputCurrencyId { get; set; }

        /// <summary>
        /// The amount of currency given by this offer. If an outputCurrencyAmount is provided without an output currency address or id, the native chain currency is used as the given currency.
        /// </summary>
        /// <value>The amount of currency given by this offer. If an outputCurrencyAmount is provided without an output currency address or id, the native chain currency is used as the given currency.</value>
        [DataMember(Name="outputCurrencyAmount", EmitDefaultValue=false)]
        public decimal OutputCurrencyAmount { get; set; }

        /// <summary>
        /// The maximum number of times this offer can be used in total. maxUses is collective across all uses of the offer. If 5 unique players use an offer, that counts as 5 offer uses. Exclude this or use 0 to allow unlimited uses.
        /// </summary>
        /// <value>The maximum number of times this offer can be used in total. maxUses is collective across all uses of the offer. If 5 unique players use an offer, that counts as 5 offer uses. Exclude this or use 0 to allow unlimited uses.</value>
        [DataMember(Name="maxUses", EmitDefaultValue=false)]
        public int MaxUses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetShopOfferRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InputCollectionAddress: ").Append(InputCollectionAddress).Append("\n");
            sb.Append("  InputCollectionId: ").Append(InputCollectionId).Append("\n");
            sb.Append("  InputCollectionItemIds: ").Append(InputCollectionItemIds).Append("\n");
            sb.Append("  InputCollectionItemAmounts: ").Append(InputCollectionItemAmounts).Append("\n");
            sb.Append("  InputCurrencyAddress: ").Append(InputCurrencyAddress).Append("\n");
            sb.Append("  InputCurrencyId: ").Append(InputCurrencyId).Append("\n");
            sb.Append("  InputCurrencyAmount: ").Append(InputCurrencyAmount).Append("\n");
            sb.Append("  OutputCollectionAddress: ").Append(OutputCollectionAddress).Append("\n");
            sb.Append("  OutputCollectionId: ").Append(OutputCollectionId).Append("\n");
            sb.Append("  OutputCollectionItemIds: ").Append(OutputCollectionItemIds).Append("\n");
            sb.Append("  OutputCollectionItemAmounts: ").Append(OutputCollectionItemAmounts).Append("\n");
            sb.Append("  OutputCurrencyAddress: ").Append(OutputCurrencyAddress).Append("\n");
            sb.Append("  OutputCurrencyId: ").Append(OutputCurrencyId).Append("\n");
            sb.Append("  OutputCurrencyAmount: ").Append(OutputCurrencyAmount).Append("\n");
            sb.Append("  MaxUses: ").Append(MaxUses).Append("\n");
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
            return this.Equals(input as SetShopOfferRequest);
        }

        /// <summary>
        /// Returns true if SetShopOfferRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetShopOfferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetShopOfferRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InputCollectionAddress == input.InputCollectionAddress ||
                    (this.InputCollectionAddress != null &&
                    this.InputCollectionAddress.Equals(input.InputCollectionAddress))
                ) && 
                (
                    this.InputCollectionId == input.InputCollectionId ||
                    (this.InputCollectionId != null &&
                    this.InputCollectionId.Equals(input.InputCollectionId))
                ) && 
                (
                    this.InputCollectionItemIds == input.InputCollectionItemIds ||
                    this.InputCollectionItemIds != null &&
                    input.InputCollectionItemIds != null &&
                    this.InputCollectionItemIds.SequenceEqual(input.InputCollectionItemIds)
                ) && 
                (
                    this.InputCollectionItemAmounts == input.InputCollectionItemAmounts ||
                    this.InputCollectionItemAmounts != null &&
                    input.InputCollectionItemAmounts != null &&
                    this.InputCollectionItemAmounts.SequenceEqual(input.InputCollectionItemAmounts)
                ) && 
                (
                    this.InputCurrencyAddress == input.InputCurrencyAddress ||
                    (this.InputCurrencyAddress != null &&
                    this.InputCurrencyAddress.Equals(input.InputCurrencyAddress))
                ) && 
                (
                    this.InputCurrencyId == input.InputCurrencyId ||
                    (this.InputCurrencyId != null &&
                    this.InputCurrencyId.Equals(input.InputCurrencyId))
                ) && 
                (
                    this.InputCurrencyAmount == input.InputCurrencyAmount ||
                    (this.InputCurrencyAmount != null &&
                    this.InputCurrencyAmount.Equals(input.InputCurrencyAmount))
                ) && 
                (
                    this.OutputCollectionAddress == input.OutputCollectionAddress ||
                    (this.OutputCollectionAddress != null &&
                    this.OutputCollectionAddress.Equals(input.OutputCollectionAddress))
                ) && 
                (
                    this.OutputCollectionId == input.OutputCollectionId ||
                    (this.OutputCollectionId != null &&
                    this.OutputCollectionId.Equals(input.OutputCollectionId))
                ) && 
                (
                    this.OutputCollectionItemIds == input.OutputCollectionItemIds ||
                    this.OutputCollectionItemIds != null &&
                    input.OutputCollectionItemIds != null &&
                    this.OutputCollectionItemIds.SequenceEqual(input.OutputCollectionItemIds)
                ) && 
                (
                    this.OutputCollectionItemAmounts == input.OutputCollectionItemAmounts ||
                    this.OutputCollectionItemAmounts != null &&
                    input.OutputCollectionItemAmounts != null &&
                    this.OutputCollectionItemAmounts.SequenceEqual(input.OutputCollectionItemAmounts)
                ) && 
                (
                    this.OutputCurrencyAddress == input.OutputCurrencyAddress ||
                    (this.OutputCurrencyAddress != null &&
                    this.OutputCurrencyAddress.Equals(input.OutputCurrencyAddress))
                ) && 
                (
                    this.OutputCurrencyId == input.OutputCurrencyId ||
                    (this.OutputCurrencyId != null &&
                    this.OutputCurrencyId.Equals(input.OutputCurrencyId))
                ) && 
                (
                    this.OutputCurrencyAmount == input.OutputCurrencyAmount ||
                    (this.OutputCurrencyAmount != null &&
                    this.OutputCurrencyAmount.Equals(input.OutputCurrencyAmount))
                ) && 
                (
                    this.MaxUses == input.MaxUses ||
                    (this.MaxUses != null &&
                    this.MaxUses.Equals(input.MaxUses))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InputCollectionAddress != null)
                    hashCode = hashCode * 59 + this.InputCollectionAddress.GetHashCode();
                if (this.InputCollectionId != null)
                    hashCode = hashCode * 59 + this.InputCollectionId.GetHashCode();
                if (this.InputCollectionItemIds != null)
                    hashCode = hashCode * 59 + this.InputCollectionItemIds.GetHashCode();
                if (this.InputCollectionItemAmounts != null)
                    hashCode = hashCode * 59 + this.InputCollectionItemAmounts.GetHashCode();
                if (this.InputCurrencyAddress != null)
                    hashCode = hashCode * 59 + this.InputCurrencyAddress.GetHashCode();
                if (this.InputCurrencyId != null)
                    hashCode = hashCode * 59 + this.InputCurrencyId.GetHashCode();
                if (this.InputCurrencyAmount != null)
                    hashCode = hashCode * 59 + this.InputCurrencyAmount.GetHashCode();
                if (this.OutputCollectionAddress != null)
                    hashCode = hashCode * 59 + this.OutputCollectionAddress.GetHashCode();
                if (this.OutputCollectionId != null)
                    hashCode = hashCode * 59 + this.OutputCollectionId.GetHashCode();
                if (this.OutputCollectionItemIds != null)
                    hashCode = hashCode * 59 + this.OutputCollectionItemIds.GetHashCode();
                if (this.OutputCollectionItemAmounts != null)
                    hashCode = hashCode * 59 + this.OutputCollectionItemAmounts.GetHashCode();
                if (this.OutputCurrencyAddress != null)
                    hashCode = hashCode * 59 + this.OutputCurrencyAddress.GetHashCode();
                if (this.OutputCurrencyId != null)
                    hashCode = hashCode * 59 + this.OutputCurrencyId.GetHashCode();
                if (this.OutputCurrencyAmount != null)
                    hashCode = hashCode * 59 + this.OutputCurrencyAmount.GetHashCode();
                if (this.MaxUses != null)
                    hashCode = hashCode * 59 + this.MaxUses.GetHashCode();
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
