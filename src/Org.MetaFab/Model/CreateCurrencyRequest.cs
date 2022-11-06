/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.1.43
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
    /// CreateCurrencyRequest
    /// </summary>
    [DataContract]
    public partial class CreateCurrencyRequest :  IEquatable<CreateCurrencyRequest>, IValidatableObject
    {
        /// <summary>
        /// The blockchain you want to deploy this currency on. Support for new blockchains are added over time.
        /// </summary>
        /// <value>The blockchain you want to deploy this currency on. Support for new blockchains are added over time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum ETHEREUM for value: ETHEREUM
            /// </summary>
            [EnumMember(Value = "ETHEREUM")]
            ETHEREUM = 1,

            /// <summary>
            /// Enum GOERLI for value: GOERLI
            /// </summary>
            [EnumMember(Value = "GOERLI")]
            GOERLI = 2,

            /// <summary>
            /// Enum MATIC for value: MATIC
            /// </summary>
            [EnumMember(Value = "MATIC")]
            MATIC = 3,

            /// <summary>
            /// Enum MUMBAI for value: MUMBAI
            /// </summary>
            [EnumMember(Value = "MUMBAI")]
            MUMBAI = 4,

            /// <summary>
            /// Enum ARBITRUM for value: ARBITRUM
            /// </summary>
            [EnumMember(Value = "ARBITRUM")]
            ARBITRUM = 5,

            /// <summary>
            /// Enum ARBITRUMGOERLI for value: ARBITRUMGOERLI
            /// </summary>
            [EnumMember(Value = "ARBITRUMGOERLI")]
            ARBITRUMGOERLI = 6

        }

        /// <summary>
        /// The blockchain you want to deploy this currency on. Support for new blockchains are added over time.
        /// </summary>
        /// <value>The blockchain you want to deploy this currency on. Support for new blockchains are added over time.</value>
        [DataMember(Name="chain", EmitDefaultValue=true)]
        public ChainEnum Chain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCurrencyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCurrencyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCurrencyRequest" /> class.
        /// </summary>
        /// <param name="name">The name of this currency. This can be anything, such as &#x60;Bright Gems&#x60;, &#x60;Gold&#x60;, etc. (required).</param>
        /// <param name="symbol">The shorthand symbol to represent this currency. This can be anything, such as &#x60;BGEM&#x60;, &#x60;GLD&#x60;, etc. (required).</param>
        /// <param name="supplyCap">The maximum amount of this currency that can ever exist. Use &#x60;0&#x60; if you do not want this currency to have a maximum supply. (required).</param>
        /// <param name="chain">The blockchain you want to deploy this currency on. Support for new blockchains are added over time. (required).</param>
        public CreateCurrencyRequest(string name = default(string), string symbol = default(string), decimal supplyCap = default(decimal), ChainEnum chain = default(ChainEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateCurrencyRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new InvalidDataException("symbol is a required property for CreateCurrencyRequest and cannot be null");
            }
            else
            {
                this.Symbol = symbol;
            }

            // to ensure "supplyCap" is required (not null)
            if (supplyCap == null)
            {
                throw new InvalidDataException("supplyCap is a required property for CreateCurrencyRequest and cannot be null");
            }
            else
            {
                this.SupplyCap = supplyCap;
            }

            // to ensure "chain" is required (not null)
            if (chain == null)
            {
                throw new InvalidDataException("chain is a required property for CreateCurrencyRequest and cannot be null");
            }
            else
            {
                this.Chain = chain;
            }

        }

        /// <summary>
        /// The name of this currency. This can be anything, such as &#x60;Bright Gems&#x60;, &#x60;Gold&#x60;, etc.
        /// </summary>
        /// <value>The name of this currency. This can be anything, such as &#x60;Bright Gems&#x60;, &#x60;Gold&#x60;, etc.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The shorthand symbol to represent this currency. This can be anything, such as &#x60;BGEM&#x60;, &#x60;GLD&#x60;, etc.
        /// </summary>
        /// <value>The shorthand symbol to represent this currency. This can be anything, such as &#x60;BGEM&#x60;, &#x60;GLD&#x60;, etc.</value>
        [DataMember(Name="symbol", EmitDefaultValue=true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The maximum amount of this currency that can ever exist. Use &#x60;0&#x60; if you do not want this currency to have a maximum supply.
        /// </summary>
        /// <value>The maximum amount of this currency that can ever exist. Use &#x60;0&#x60; if you do not want this currency to have a maximum supply.</value>
        [DataMember(Name="supplyCap", EmitDefaultValue=true)]
        public decimal SupplyCap { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCurrencyRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  SupplyCap: ").Append(SupplyCap).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
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
            return this.Equals(input as CreateCurrencyRequest);
        }

        /// <summary>
        /// Returns true if CreateCurrencyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCurrencyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCurrencyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.SupplyCap == input.SupplyCap ||
                    (this.SupplyCap != null &&
                    this.SupplyCap.Equals(input.SupplyCap))
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.SupplyCap != null)
                    hashCode = hashCode * 59 + this.SupplyCap.GetHashCode();
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
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
