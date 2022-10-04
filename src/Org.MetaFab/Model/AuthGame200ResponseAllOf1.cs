/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// AuthGame200ResponseAllOf1
    /// </summary>
    [DataContract]
    public partial class AuthGame200ResponseAllOf1 :  IEquatable<AuthGame200ResponseAllOf1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthGame200ResponseAllOf1" /> class.
        /// </summary>
        /// <param name="fundingWallet">fundingWallet.</param>
        public AuthGame200ResponseAllOf1(WalletModel fundingWallet = default(WalletModel))
        {
            this.FundingWallet = fundingWallet;
        }

        /// <summary>
        /// Gets or Sets FundingWallet
        /// </summary>
        [DataMember(Name="fundingWallet", EmitDefaultValue=false)]
        public WalletModel FundingWallet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthGame200ResponseAllOf1 {\n");
            sb.Append("  FundingWallet: ").Append(FundingWallet).Append("\n");
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
            return this.Equals(input as AuthGame200ResponseAllOf1);
        }

        /// <summary>
        /// Returns true if AuthGame200ResponseAllOf1 instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthGame200ResponseAllOf1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthGame200ResponseAllOf1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FundingWallet == input.FundingWallet ||
                    (this.FundingWallet != null &&
                    this.FundingWallet.Equals(input.FundingWallet))
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
                if (this.FundingWallet != null)
                    hashCode = hashCode * 59 + this.FundingWallet.GetHashCode();
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