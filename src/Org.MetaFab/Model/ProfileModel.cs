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
    /// ProfileModel
    /// </summary>
    [DataContract]
    public partial class ProfileModel :  IEquatable<ProfileModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileModel" /> class.
        /// </summary>
        /// <param name="id">This field has not had a description added..</param>
        /// <param name="ecosystemId">This field has not had a description added..</param>
        /// <param name="walletId">This field has not had a description added..</param>
        /// <param name="connectedWalletId">This field has not had a description added..</param>
        /// <param name="username">This field has not had a description added..</param>
        /// <param name="accessToken">This field has not had a description added..</param>
        /// <param name="updatedAt">This field has not had a description added..</param>
        /// <param name="createdAt">This field has not had a description added..</param>
        public ProfileModel(string id = default(string), string ecosystemId = default(string), string walletId = default(string), string connectedWalletId = default(string), string username = default(string), string accessToken = default(string), string updatedAt = default(string), string createdAt = default(string))
        {
            this.Id = id;
            this.EcosystemId = ecosystemId;
            this.WalletId = walletId;
            this.ConnectedWalletId = connectedWalletId;
            this.Username = username;
            this.AccessToken = accessToken;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="ecosystemId", EmitDefaultValue=false)]
        public string EcosystemId { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="walletId", EmitDefaultValue=false)]
        public string WalletId { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="connectedWalletId", EmitDefaultValue=false)]
        public string ConnectedWalletId { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EcosystemId: ").Append(EcosystemId).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  ConnectedWalletId: ").Append(ConnectedWalletId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as ProfileModel);
        }

        /// <summary>
        /// Returns true if ProfileModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EcosystemId == input.EcosystemId ||
                    (this.EcosystemId != null &&
                    this.EcosystemId.Equals(input.EcosystemId))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.ConnectedWalletId == input.ConnectedWalletId ||
                    (this.ConnectedWalletId != null &&
                    this.ConnectedWalletId.Equals(input.ConnectedWalletId))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EcosystemId != null)
                    hashCode = hashCode * 59 + this.EcosystemId.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.ConnectedWalletId != null)
                    hashCode = hashCode * 59 + this.ConnectedWalletId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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