/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.1.4
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
    /// GrantCollectionRoleRequest
    /// </summary>
    [DataContract]
    public partial class GrantCollectionRoleRequest :  IEquatable<GrantCollectionRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantCollectionRoleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GrantCollectionRoleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantCollectionRoleRequest" /> class.
        /// </summary>
        /// <param name="role">A valid MetaFab role or bytes string representing a role, such as &#x60;minter&#x60; or &#x60;0xc9eb32e43bf5ecbceacf00b32281dfc5d6d700a0db676ea26ccf938a385ac3b7&#x60; (required).</param>
        /// <param name="address">A valid EVM based address grant the role to..</param>
        /// <param name="walletId">A wallet id within the MetaFab ecosystem to grant the role to..</param>
        public GrantCollectionRoleRequest(string role = default(string), string address = default(string), List<string> walletId = default(List<string>))
        {
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for GrantCollectionRoleRequest and cannot be null");
            }
            else
            {
                this.Role = role;
            }

            this.Address = address;
            this.WalletId = walletId;
        }

        /// <summary>
        /// A valid MetaFab role or bytes string representing a role, such as &#x60;minter&#x60; or &#x60;0xc9eb32e43bf5ecbceacf00b32281dfc5d6d700a0db676ea26ccf938a385ac3b7&#x60;
        /// </summary>
        /// <value>A valid MetaFab role or bytes string representing a role, such as &#x60;minter&#x60; or &#x60;0xc9eb32e43bf5ecbceacf00b32281dfc5d6d700a0db676ea26ccf938a385ac3b7&#x60;</value>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public string Role { get; set; }

        /// <summary>
        /// A valid EVM based address grant the role to.
        /// </summary>
        /// <value>A valid EVM based address grant the role to.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// A wallet id within the MetaFab ecosystem to grant the role to.
        /// </summary>
        /// <value>A wallet id within the MetaFab ecosystem to grant the role to.</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public List<string> WalletId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantCollectionRoleRequest {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as GrantCollectionRoleRequest);
        }

        /// <summary>
        /// Returns true if GrantCollectionRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantCollectionRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantCollectionRoleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
