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
    /// BurnCollectionItemRequest
    /// </summary>
    [DataContract]
    public partial class BurnCollectionItemRequest :  IEquatable<BurnCollectionItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BurnCollectionItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BurnCollectionItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BurnCollectionItemRequest" /> class.
        /// </summary>
        /// <param name="quantity">The quantity of the collectionItemId to burn. (required).</param>
        public BurnCollectionItemRequest(decimal quantity = default(decimal))
        {
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for BurnCollectionItemRequest and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }

        }

        /// <summary>
        /// The quantity of the collectionItemId to burn.
        /// </summary>
        /// <value>The quantity of the collectionItemId to burn.</value>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BurnCollectionItemRequest {\n");
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
            return this.Equals(input as BurnCollectionItemRequest);
        }

        /// <summary>
        /// Returns true if BurnCollectionItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BurnCollectionItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BurnCollectionItemRequest input)
        {
            if (input == null)
                return false;

            return 
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
