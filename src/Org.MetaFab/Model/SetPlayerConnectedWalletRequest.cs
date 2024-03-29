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
    /// SetPlayerConnectedWalletRequest
    /// </summary>
    [DataContract]
    public partial class SetPlayerConnectedWalletRequest :  IEquatable<SetPlayerConnectedWalletRequest>, IValidatableObject
    {
        /// <summary>
        /// The blockchain you want to support this wallet connection on. If you need to support multiple blockchains, make multiple requests using different &#x60;chain&#x60; arguments. Support for new blockchains are added over time.
        /// </summary>
        /// <value>The blockchain you want to support this wallet connection on. If you need to support multiple blockchains, make multiple requests using different &#x60;chain&#x60; arguments. Support for new blockchains are added over time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum ARBITRUM for value: ARBITRUM
            /// </summary>
            [EnumMember(Value = "ARBITRUM")]
            ARBITRUM = 1,

            /// <summary>
            /// Enum ARBITRUMGOERLI for value: ARBITRUMGOERLI
            /// </summary>
            [EnumMember(Value = "ARBITRUMGOERLI")]
            ARBITRUMGOERLI = 2,

            /// <summary>
            /// Enum ARBITRUMNOVA for value: ARBITRUMNOVA
            /// </summary>
            [EnumMember(Value = "ARBITRUMNOVA")]
            ARBITRUMNOVA = 3,

            /// <summary>
            /// Enum AVALANCHE for value: AVALANCHE
            /// </summary>
            [EnumMember(Value = "AVALANCHE")]
            AVALANCHE = 4,

            /// <summary>
            /// Enum AVALANCHEFUJI for value: AVALANCHEFUJI
            /// </summary>
            [EnumMember(Value = "AVALANCHEFUJI")]
            AVALANCHEFUJI = 5,

            /// <summary>
            /// Enum ETHEREUM for value: ETHEREUM
            /// </summary>
            [EnumMember(Value = "ETHEREUM")]
            ETHEREUM = 6,

            /// <summary>
            /// Enum FANTOM for value: FANTOM
            /// </summary>
            [EnumMember(Value = "FANTOM")]
            FANTOM = 7,

            /// <summary>
            /// Enum FANTOMTEST for value: FANTOMTEST
            /// </summary>
            [EnumMember(Value = "FANTOMTEST")]
            FANTOMTEST = 8,

            /// <summary>
            /// Enum GOERLI for value: GOERLI
            /// </summary>
            [EnumMember(Value = "GOERLI")]
            GOERLI = 9,

            /// <summary>
            /// Enum MATIC for value: MATIC
            /// </summary>
            [EnumMember(Value = "MATIC")]
            MATIC = 10,

            /// <summary>
            /// Enum MATICMUMBAI for value: MATICMUMBAI
            /// </summary>
            [EnumMember(Value = "MATICMUMBAI")]
            MATICMUMBAI = 11,

            /// <summary>
            /// Enum THUNDERCORE for value: THUNDERCORE
            /// </summary>
            [EnumMember(Value = "THUNDERCORE")]
            THUNDERCORE = 12,

            /// <summary>
            /// Enum THUNDERCORETESTNET for value: THUNDERCORETESTNET
            /// </summary>
            [EnumMember(Value = "THUNDERCORETESTNET")]
            THUNDERCORETESTNET = 13

        }

        /// <summary>
        /// The blockchain you want to support this wallet connection on. If you need to support multiple blockchains, make multiple requests using different &#x60;chain&#x60; arguments. Support for new blockchains are added over time.
        /// </summary>
        /// <value>The blockchain you want to support this wallet connection on. If you need to support multiple blockchains, make multiple requests using different &#x60;chain&#x60; arguments. Support for new blockchains are added over time.</value>
        [DataMember(Name="chain", EmitDefaultValue=true)]
        public ChainEnum Chain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPlayerConnectedWalletRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetPlayerConnectedWalletRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPlayerConnectedWalletRequest" /> class.
        /// </summary>
        /// <param name="address">The address of the external wallet to connect to the player. (required).</param>
        /// <param name="nonce">Any positive integer that hasn&#39;t been used previously to connect or disconnect this external wallet. Must be the same nonce used to generate the &#x60;signature&#x60;. (required).</param>
        /// <param name="signature">A signature string generated by signing a keccak256 hash generated with abiCoder encode arguments of &#x60;[ &#39;bytes32&#39;, &#39;address&#39;, &#39;bool&#39;, &#39;address&#39;, &#39;uint256&#39; ]&#x60; and &#x60;[ keccak256(gameId), delegate wallet approved (player&#39;s custodial wallet address), true, external wallet address, any unused nonce number ]&#x60;. (required).</param>
        /// <param name="chain">The blockchain you want to support this wallet connection on. If you need to support multiple blockchains, make multiple requests using different &#x60;chain&#x60; arguments. Support for new blockchains are added over time. (required).</param>
        public SetPlayerConnectedWalletRequest(string address = default(string), int nonce = default(int), string signature = default(string), ChainEnum chain = default(ChainEnum))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for SetPlayerConnectedWalletRequest and cannot be null");
            }
            else
            {
                this.Address = address;
            }

            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new InvalidDataException("nonce is a required property for SetPlayerConnectedWalletRequest and cannot be null");
            }
            else
            {
                this.Nonce = nonce;
            }

            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new InvalidDataException("signature is a required property for SetPlayerConnectedWalletRequest and cannot be null");
            }
            else
            {
                this.Signature = signature;
            }

            // to ensure "chain" is required (not null)
            if (chain == null)
            {
                throw new InvalidDataException("chain is a required property for SetPlayerConnectedWalletRequest and cannot be null");
            }
            else
            {
                this.Chain = chain;
            }

        }

        /// <summary>
        /// The address of the external wallet to connect to the player.
        /// </summary>
        /// <value>The address of the external wallet to connect to the player.</value>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// Any positive integer that hasn&#39;t been used previously to connect or disconnect this external wallet. Must be the same nonce used to generate the &#x60;signature&#x60;.
        /// </summary>
        /// <value>Any positive integer that hasn&#39;t been used previously to connect or disconnect this external wallet. Must be the same nonce used to generate the &#x60;signature&#x60;.</value>
        [DataMember(Name="nonce", EmitDefaultValue=true)]
        public int Nonce { get; set; }

        /// <summary>
        /// A signature string generated by signing a keccak256 hash generated with abiCoder encode arguments of &#x60;[ &#39;bytes32&#39;, &#39;address&#39;, &#39;bool&#39;, &#39;address&#39;, &#39;uint256&#39; ]&#x60; and &#x60;[ keccak256(gameId), delegate wallet approved (player&#39;s custodial wallet address), true, external wallet address, any unused nonce number ]&#x60;.
        /// </summary>
        /// <value>A signature string generated by signing a keccak256 hash generated with abiCoder encode arguments of &#x60;[ &#39;bytes32&#39;, &#39;address&#39;, &#39;bool&#39;, &#39;address&#39;, &#39;uint256&#39; ]&#x60; and &#x60;[ keccak256(gameId), delegate wallet approved (player&#39;s custodial wallet address), true, external wallet address, any unused nonce number ]&#x60;.</value>
        [DataMember(Name="signature", EmitDefaultValue=true)]
        public string Signature { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPlayerConnectedWalletRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as SetPlayerConnectedWalletRequest);
        }

        /// <summary>
        /// Returns true if SetPlayerConnectedWalletRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetPlayerConnectedWalletRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPlayerConnectedWalletRequest input)
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
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
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
