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
    /// CreateContractRequest
    /// </summary>
    [DataContract]
    public partial class CreateContractRequest :  IEquatable<CreateContractRequest>, IValidatableObject
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
            MUMBAI = 4

        }

        /// <summary>
        /// The blockchain you want to deploy this currency on. Support for new blockchains are added over time.
        /// </summary>
        /// <value>The blockchain you want to deploy this currency on. Support for new blockchains are added over time.</value>
        [DataMember(Name="chain", EmitDefaultValue=true)]
        public ChainEnum Chain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContractRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateContractRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContractRequest" /> class.
        /// </summary>
        /// <param name="address">The address of the existing contract. (required).</param>
        /// <param name="abi">JSON of the abi. (required).</param>
        /// <param name="chain">The blockchain you want to deploy this currency on. Support for new blockchains are added over time. (required).</param>
        public CreateContractRequest(string address = default(string), string abi = default(string), ChainEnum chain = default(ChainEnum))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for CreateContractRequest and cannot be null");
            }
            else
            {
                this.Address = address;
            }

            // to ensure "abi" is required (not null)
            if (abi == null)
            {
                throw new InvalidDataException("abi is a required property for CreateContractRequest and cannot be null");
            }
            else
            {
                this.Abi = abi;
            }

            // to ensure "chain" is required (not null)
            if (chain == null)
            {
                throw new InvalidDataException("chain is a required property for CreateContractRequest and cannot be null");
            }
            else
            {
                this.Chain = chain;
            }

        }

        /// <summary>
        /// The address of the existing contract.
        /// </summary>
        /// <value>The address of the existing contract.</value>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// JSON of the abi.
        /// </summary>
        /// <value>JSON of the abi.</value>
        [DataMember(Name="abi", EmitDefaultValue=true)]
        public string Abi { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateContractRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Abi: ").Append(Abi).Append("\n");
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
            return this.Equals(input as CreateContractRequest);
        }

        /// <summary>
        /// Returns true if CreateContractRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateContractRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContractRequest input)
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
                    this.Abi == input.Abi ||
                    (this.Abi != null &&
                    this.Abi.Equals(input.Abi))
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
                if (this.Abi != null)
                    hashCode = hashCode * 59 + this.Abi.GetHashCode();
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
