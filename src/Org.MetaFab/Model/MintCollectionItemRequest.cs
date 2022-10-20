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
    /// MintCollectionItemRequest
    /// </summary>
    [DataContract]
    public partial class MintCollectionItemRequest :  IEquatable<MintCollectionItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MintCollectionItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MintCollectionItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintCollectionItemRequest" /> class.
        /// </summary>
        /// <param name="address">A valid EVM based address to create (mint) the item(s) for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;..</param>
        /// <param name="quantity">The quantity of the specified item id to create (mint). (required).</param>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem to create (mint) the item(s) for..</param>
        public MintCollectionItemRequest(string address = default(string), decimal quantity = default(decimal), string walletId = default(string))
        {
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for MintCollectionItemRequest and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }

            this.Address = address;
            this.WalletId = walletId;
        }

        /// <summary>
        /// A valid EVM based address to create (mint) the item(s) for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.
        /// </summary>
        /// <value>A valid EVM based address to create (mint) the item(s) for. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The quantity of the specified item id to create (mint).
        /// </summary>
        /// <value>The quantity of the specified item id to create (mint).</value>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Any wallet id within the MetaFab ecosystem to create (mint) the item(s) for.
        /// </summary>
        /// <value>Any wallet id within the MetaFab ecosystem to create (mint) the item(s) for.</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MintCollectionItemRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as MintCollectionItemRequest);
        }

        /// <summary>
        /// Returns true if MintCollectionItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MintCollectionItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MintCollectionItemRequest input)
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
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
