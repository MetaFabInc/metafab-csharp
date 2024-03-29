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
    /// ShopOffer
    /// </summary>
    [DataContract]
    public partial class ShopOffer :  IEquatable<ShopOffer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopOffer" /> class.
        /// </summary>
        /// <param name="id">The id of this offer..</param>
        /// <param name="inputCollection">The address of the ERC1155 or MetaFab game items contract for input items required by this offer..</param>
        /// <param name="inputCollectionItemIds">An array of item ids from the input collection that are required for this offer..</param>
        /// <param name="inputCollectionItemAmounts">An array of amounts for each item id for the input collection that are required to use this offer..</param>
        /// <param name="inputCurrency">The address of the ERC20 or MetaFab game currency for the currency required by this offer..</param>
        /// <param name="inputCurrencyAmount">The amount of currency required by this offer..</param>
        /// <param name="outputCollection">The address of the ERC1155 or MetaFab game items contract for output items given by this offer..</param>
        /// <param name="outputCollectionItemIds">An array of item ids from the output collection that are given for this offer..</param>
        /// <param name="outputCollectionItemAmounts">An array of amounts for each item id for the output collection that are given by this offer..</param>
        /// <param name="outputCurrency">The address of the ERC20 or MetaFab game currency for the output currency given by this offer..</param>
        /// <param name="outputCurrencyAmount">The amount of currency given by this offer..</param>
        /// <param name="uses">The number of times this offer has been used..</param>
        /// <param name="maxUses">The maximum number of times this offer can be used. A value of &#x60;0&#x60; means there is no limit on how many times this offer can be used..</param>
        /// <param name="lastUpdatedAt">A unix timestamp in seconds that represents the last time this offer was set or updated..</param>
        public ShopOffer(int id = default(int), string inputCollection = default(string), List<int> inputCollectionItemIds = default(List<int>), List<int> inputCollectionItemAmounts = default(List<int>), string inputCurrency = default(string), decimal inputCurrencyAmount = default(decimal), string outputCollection = default(string), List<int> outputCollectionItemIds = default(List<int>), List<int> outputCollectionItemAmounts = default(List<int>), string outputCurrency = default(string), decimal outputCurrencyAmount = default(decimal), int uses = default(int), int maxUses = default(int), int lastUpdatedAt = default(int))
        {
            this.Id = id;
            this.InputCollection = inputCollection;
            this.InputCollectionItemIds = inputCollectionItemIds;
            this.InputCollectionItemAmounts = inputCollectionItemAmounts;
            this.InputCurrency = inputCurrency;
            this.InputCurrencyAmount = inputCurrencyAmount;
            this.OutputCollection = outputCollection;
            this.OutputCollectionItemIds = outputCollectionItemIds;
            this.OutputCollectionItemAmounts = outputCollectionItemAmounts;
            this.OutputCurrency = outputCurrency;
            this.OutputCurrencyAmount = outputCurrencyAmount;
            this.Uses = uses;
            this.MaxUses = maxUses;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// The id of this offer.
        /// </summary>
        /// <value>The id of this offer.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The address of the ERC1155 or MetaFab game items contract for input items required by this offer.
        /// </summary>
        /// <value>The address of the ERC1155 or MetaFab game items contract for input items required by this offer.</value>
        [DataMember(Name="inputCollection", EmitDefaultValue=false)]
        public string InputCollection { get; set; }

        /// <summary>
        /// An array of item ids from the input collection that are required for this offer.
        /// </summary>
        /// <value>An array of item ids from the input collection that are required for this offer.</value>
        [DataMember(Name="inputCollectionItemIds", EmitDefaultValue=false)]
        public List<int> InputCollectionItemIds { get; set; }

        /// <summary>
        /// An array of amounts for each item id for the input collection that are required to use this offer.
        /// </summary>
        /// <value>An array of amounts for each item id for the input collection that are required to use this offer.</value>
        [DataMember(Name="inputCollectionItemAmounts", EmitDefaultValue=false)]
        public List<int> InputCollectionItemAmounts { get; set; }

        /// <summary>
        /// The address of the ERC20 or MetaFab game currency for the currency required by this offer.
        /// </summary>
        /// <value>The address of the ERC20 or MetaFab game currency for the currency required by this offer.</value>
        [DataMember(Name="inputCurrency", EmitDefaultValue=false)]
        public string InputCurrency { get; set; }

        /// <summary>
        /// The amount of currency required by this offer.
        /// </summary>
        /// <value>The amount of currency required by this offer.</value>
        [DataMember(Name="inputCurrencyAmount", EmitDefaultValue=false)]
        public decimal InputCurrencyAmount { get; set; }

        /// <summary>
        /// The address of the ERC1155 or MetaFab game items contract for output items given by this offer.
        /// </summary>
        /// <value>The address of the ERC1155 or MetaFab game items contract for output items given by this offer.</value>
        [DataMember(Name="outputCollection", EmitDefaultValue=false)]
        public string OutputCollection { get; set; }

        /// <summary>
        /// An array of item ids from the output collection that are given for this offer.
        /// </summary>
        /// <value>An array of item ids from the output collection that are given for this offer.</value>
        [DataMember(Name="outputCollectionItemIds", EmitDefaultValue=false)]
        public List<int> OutputCollectionItemIds { get; set; }

        /// <summary>
        /// An array of amounts for each item id for the output collection that are given by this offer.
        /// </summary>
        /// <value>An array of amounts for each item id for the output collection that are given by this offer.</value>
        [DataMember(Name="outputCollectionItemAmounts", EmitDefaultValue=false)]
        public List<int> OutputCollectionItemAmounts { get; set; }

        /// <summary>
        /// The address of the ERC20 or MetaFab game currency for the output currency given by this offer.
        /// </summary>
        /// <value>The address of the ERC20 or MetaFab game currency for the output currency given by this offer.</value>
        [DataMember(Name="outputCurrency", EmitDefaultValue=false)]
        public string OutputCurrency { get; set; }

        /// <summary>
        /// The amount of currency given by this offer.
        /// </summary>
        /// <value>The amount of currency given by this offer.</value>
        [DataMember(Name="outputCurrencyAmount", EmitDefaultValue=false)]
        public decimal OutputCurrencyAmount { get; set; }

        /// <summary>
        /// The number of times this offer has been used.
        /// </summary>
        /// <value>The number of times this offer has been used.</value>
        [DataMember(Name="uses", EmitDefaultValue=false)]
        public int Uses { get; set; }

        /// <summary>
        /// The maximum number of times this offer can be used. A value of &#x60;0&#x60; means there is no limit on how many times this offer can be used.
        /// </summary>
        /// <value>The maximum number of times this offer can be used. A value of &#x60;0&#x60; means there is no limit on how many times this offer can be used.</value>
        [DataMember(Name="maxUses", EmitDefaultValue=false)]
        public int MaxUses { get; set; }

        /// <summary>
        /// A unix timestamp in seconds that represents the last time this offer was set or updated.
        /// </summary>
        /// <value>A unix timestamp in seconds that represents the last time this offer was set or updated.</value>
        [DataMember(Name="lastUpdatedAt", EmitDefaultValue=false)]
        public int LastUpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopOffer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InputCollection: ").Append(InputCollection).Append("\n");
            sb.Append("  InputCollectionItemIds: ").Append(InputCollectionItemIds).Append("\n");
            sb.Append("  InputCollectionItemAmounts: ").Append(InputCollectionItemAmounts).Append("\n");
            sb.Append("  InputCurrency: ").Append(InputCurrency).Append("\n");
            sb.Append("  InputCurrencyAmount: ").Append(InputCurrencyAmount).Append("\n");
            sb.Append("  OutputCollection: ").Append(OutputCollection).Append("\n");
            sb.Append("  OutputCollectionItemIds: ").Append(OutputCollectionItemIds).Append("\n");
            sb.Append("  OutputCollectionItemAmounts: ").Append(OutputCollectionItemAmounts).Append("\n");
            sb.Append("  OutputCurrency: ").Append(OutputCurrency).Append("\n");
            sb.Append("  OutputCurrencyAmount: ").Append(OutputCurrencyAmount).Append("\n");
            sb.Append("  Uses: ").Append(Uses).Append("\n");
            sb.Append("  MaxUses: ").Append(MaxUses).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
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
            return this.Equals(input as ShopOffer);
        }

        /// <summary>
        /// Returns true if ShopOffer instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopOffer input)
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
                    this.InputCollection == input.InputCollection ||
                    (this.InputCollection != null &&
                    this.InputCollection.Equals(input.InputCollection))
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
                    this.InputCurrency == input.InputCurrency ||
                    (this.InputCurrency != null &&
                    this.InputCurrency.Equals(input.InputCurrency))
                ) && 
                (
                    this.InputCurrencyAmount == input.InputCurrencyAmount ||
                    (this.InputCurrencyAmount != null &&
                    this.InputCurrencyAmount.Equals(input.InputCurrencyAmount))
                ) && 
                (
                    this.OutputCollection == input.OutputCollection ||
                    (this.OutputCollection != null &&
                    this.OutputCollection.Equals(input.OutputCollection))
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
                    this.OutputCurrency == input.OutputCurrency ||
                    (this.OutputCurrency != null &&
                    this.OutputCurrency.Equals(input.OutputCurrency))
                ) && 
                (
                    this.OutputCurrencyAmount == input.OutputCurrencyAmount ||
                    (this.OutputCurrencyAmount != null &&
                    this.OutputCurrencyAmount.Equals(input.OutputCurrencyAmount))
                ) && 
                (
                    this.Uses == input.Uses ||
                    (this.Uses != null &&
                    this.Uses.Equals(input.Uses))
                ) && 
                (
                    this.MaxUses == input.MaxUses ||
                    (this.MaxUses != null &&
                    this.MaxUses.Equals(input.MaxUses))
                ) && 
                (
                    this.LastUpdatedAt == input.LastUpdatedAt ||
                    (this.LastUpdatedAt != null &&
                    this.LastUpdatedAt.Equals(input.LastUpdatedAt))
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
                if (this.InputCollection != null)
                    hashCode = hashCode * 59 + this.InputCollection.GetHashCode();
                if (this.InputCollectionItemIds != null)
                    hashCode = hashCode * 59 + this.InputCollectionItemIds.GetHashCode();
                if (this.InputCollectionItemAmounts != null)
                    hashCode = hashCode * 59 + this.InputCollectionItemAmounts.GetHashCode();
                if (this.InputCurrency != null)
                    hashCode = hashCode * 59 + this.InputCurrency.GetHashCode();
                if (this.InputCurrencyAmount != null)
                    hashCode = hashCode * 59 + this.InputCurrencyAmount.GetHashCode();
                if (this.OutputCollection != null)
                    hashCode = hashCode * 59 + this.OutputCollection.GetHashCode();
                if (this.OutputCollectionItemIds != null)
                    hashCode = hashCode * 59 + this.OutputCollectionItemIds.GetHashCode();
                if (this.OutputCollectionItemAmounts != null)
                    hashCode = hashCode * 59 + this.OutputCollectionItemAmounts.GetHashCode();
                if (this.OutputCurrency != null)
                    hashCode = hashCode * 59 + this.OutputCurrency.GetHashCode();
                if (this.OutputCurrencyAmount != null)
                    hashCode = hashCode * 59 + this.OutputCurrencyAmount.GetHashCode();
                if (this.Uses != null)
                    hashCode = hashCode * 59 + this.Uses.GetHashCode();
                if (this.MaxUses != null)
                    hashCode = hashCode * 59 + this.MaxUses.GetHashCode();
                if (this.LastUpdatedAt != null)
                    hashCode = hashCode * 59 + this.LastUpdatedAt.GetHashCode();
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
