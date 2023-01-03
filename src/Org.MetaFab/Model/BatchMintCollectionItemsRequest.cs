/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.4.1
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
    /// BatchMintCollectionItemsRequest
    /// </summary>
    [DataContract]
    public partial class BatchMintCollectionItemsRequest :  IEquatable<BatchMintCollectionItemsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMintCollectionItemsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchMintCollectionItemsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchMintCollectionItemsRequest" /> class.
        /// </summary>
        /// <param name="address">A valid EVM based address to create (mint) the items for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;..</param>
        /// <param name="itemIds">An array of unique itemIds to create (mint). (required).</param>
        /// <param name="quantities">An array of the quantities of each of the unique itemIds provided to create (mint). The quantity of each itemId in itemIds should be at the same index as the specific itemId in the itemIds array. For example, quantities[2] defines the quantity to mint for itemIds[2], etc. (required).</param>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem to create (mint) the items for..</param>
        public BatchMintCollectionItemsRequest(string address = default(string), List<int> itemIds = default(List<int>), List<int> quantities = default(List<int>), string walletId = default(string))
        {
            // to ensure "itemIds" is required (not null)
            if (itemIds == null)
            {
                throw new InvalidDataException("itemIds is a required property for BatchMintCollectionItemsRequest and cannot be null");
            }
            else
            {
                this.ItemIds = itemIds;
            }

            // to ensure "quantities" is required (not null)
            if (quantities == null)
            {
                throw new InvalidDataException("quantities is a required property for BatchMintCollectionItemsRequest and cannot be null");
            }
            else
            {
                this.Quantities = quantities;
            }

            this.Address = address;
            this.WalletId = walletId;
        }

        /// <summary>
        /// A valid EVM based address to create (mint) the items for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.
        /// </summary>
        /// <value>A valid EVM based address to create (mint) the items for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// An array of unique itemIds to create (mint).
        /// </summary>
        /// <value>An array of unique itemIds to create (mint).</value>
        [DataMember(Name="itemIds", EmitDefaultValue=true)]
        public List<int> ItemIds { get; set; }

        /// <summary>
        /// An array of the quantities of each of the unique itemIds provided to create (mint). The quantity of each itemId in itemIds should be at the same index as the specific itemId in the itemIds array. For example, quantities[2] defines the quantity to mint for itemIds[2], etc.
        /// </summary>
        /// <value>An array of the quantities of each of the unique itemIds provided to create (mint). The quantity of each itemId in itemIds should be at the same index as the specific itemId in the itemIds array. For example, quantities[2] defines the quantity to mint for itemIds[2], etc.</value>
        [DataMember(Name="quantities", EmitDefaultValue=true)]
        public List<int> Quantities { get; set; }

        /// <summary>
        /// Any wallet id within the MetaFab ecosystem to create (mint) the items for.
        /// </summary>
        /// <value>Any wallet id within the MetaFab ecosystem to create (mint) the items for.</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchMintCollectionItemsRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  Quantities: ").Append(Quantities).Append("\n");
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
            return this.Equals(input as BatchMintCollectionItemsRequest);
        }

        /// <summary>
        /// Returns true if BatchMintCollectionItemsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchMintCollectionItemsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchMintCollectionItemsRequest input)
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
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
                ) && 
                (
                    this.Quantities == input.Quantities ||
                    this.Quantities != null &&
                    input.Quantities != null &&
                    this.Quantities.SequenceEqual(input.Quantities)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ItemIds != null)
                    hashCode = hashCode * 59 + this.ItemIds.GetHashCode();
                if (this.Quantities != null)
                    hashCode = hashCode * 59 + this.Quantities.GetHashCode();
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
