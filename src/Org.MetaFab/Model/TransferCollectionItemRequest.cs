/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.2.1
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
    /// TransferCollectionItemRequest
    /// </summary>
    [DataContract]
    public partial class TransferCollectionItemRequest :  IEquatable<TransferCollectionItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCollectionItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferCollectionItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCollectionItemRequest" /> class.
        /// </summary>
        /// <param name="address">A valid EVM based addresses to transfer items to..</param>
        /// <param name="walletId">A wallet id within the MetaFab ecosystem to transfer items to..</param>
        /// <param name="quantity">The quantity of the collectionItemId to transfer. (required).</param>
        public TransferCollectionItemRequest(string address = default(string), List<string> walletId = default(List<string>), decimal quantity = default(decimal))
        {
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for TransferCollectionItemRequest and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }

            this.Address = address;
            this.WalletId = walletId;
        }

        /// <summary>
        /// A valid EVM based addresses to transfer items to.
        /// </summary>
        /// <value>A valid EVM based addresses to transfer items to.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// A wallet id within the MetaFab ecosystem to transfer items to.
        /// </summary>
        /// <value>A wallet id within the MetaFab ecosystem to transfer items to.</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public List<string> WalletId { get; set; }

        /// <summary>
        /// The quantity of the collectionItemId to transfer.
        /// </summary>
        /// <value>The quantity of the collectionItemId to transfer.</value>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferCollectionItemRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as TransferCollectionItemRequest);
        }

        /// <summary>
        /// Returns true if TransferCollectionItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferCollectionItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferCollectionItemRequest input)
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
                    this.WalletId != null &&
                    input.WalletId != null &&
                    this.WalletId.SequenceEqual(input.WalletId)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
