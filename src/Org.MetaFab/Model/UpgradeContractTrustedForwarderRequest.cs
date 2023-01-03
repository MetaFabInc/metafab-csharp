/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.4.0
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
    /// UpgradeContractTrustedForwarderRequest
    /// </summary>
    [DataContract]
    public partial class UpgradeContractTrustedForwarderRequest :  IEquatable<UpgradeContractTrustedForwarderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeContractTrustedForwarderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpgradeContractTrustedForwarderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeContractTrustedForwarderRequest" /> class.
        /// </summary>
        /// <param name="forwarderAddress">A ERC2771 forwarder smart contract address to assign as the new trusted forwarder of the target smart contract. (required).</param>
        public UpgradeContractTrustedForwarderRequest(string forwarderAddress = default(string))
        {
            // to ensure "forwarderAddress" is required (not null)
            if (forwarderAddress == null)
            {
                throw new InvalidDataException("forwarderAddress is a required property for UpgradeContractTrustedForwarderRequest and cannot be null");
            }
            else
            {
                this.ForwarderAddress = forwarderAddress;
            }

        }

        /// <summary>
        /// A ERC2771 forwarder smart contract address to assign as the new trusted forwarder of the target smart contract.
        /// </summary>
        /// <value>A ERC2771 forwarder smart contract address to assign as the new trusted forwarder of the target smart contract.</value>
        [DataMember(Name="forwarderAddress", EmitDefaultValue=true)]
        public string ForwarderAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeContractTrustedForwarderRequest {\n");
            sb.Append("  ForwarderAddress: ").Append(ForwarderAddress).Append("\n");
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
            return this.Equals(input as UpgradeContractTrustedForwarderRequest);
        }

        /// <summary>
        /// Returns true if UpgradeContractTrustedForwarderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpgradeContractTrustedForwarderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpgradeContractTrustedForwarderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForwarderAddress == input.ForwarderAddress ||
                    (this.ForwarderAddress != null &&
                    this.ForwarderAddress.Equals(input.ForwarderAddress))
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
                if (this.ForwarderAddress != null)
                    hashCode = hashCode * 59 + this.ForwarderAddress.GetHashCode();
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
