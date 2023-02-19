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
    /// UpdateProfilePlayer200Response
    /// </summary>
    [DataContract]
    public partial class UpdateProfilePlayer200Response :  IEquatable<UpdateProfilePlayer200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProfilePlayer200Response" /> class.
        /// </summary>
        /// <param name="id">This field has not had a description added..</param>
        /// <param name="gameId">This field has not had a description added..</param>
        /// <param name="walletId">This field has not had a description added..</param>
        /// <param name="connectedWalletId">This field has not had a description added..</param>
        /// <param name="profileId">This field has not had a description added..</param>
        /// <param name="username">This field has not had a description added..</param>
        /// <param name="accessToken">This field has not had a description added..</param>
        /// <param name="profilePermissions">This field has not had a description added..</param>
        /// <param name="updatedAt">This field has not had a description added..</param>
        /// <param name="createdAt">This field has not had a description added..</param>
        /// <param name="wallet">wallet.</param>
        /// <param name="custodialWallet">custodialWallet.</param>
        public UpdateProfilePlayer200Response(string id = default(string), string gameId = default(string), string walletId = default(string), string connectedWalletId = default(string), string profileId = default(string), string username = default(string), string accessToken = default(string), Object profilePermissions = default(Object), string updatedAt = default(string), string createdAt = default(string), WalletModel wallet = default(WalletModel), WalletModel custodialWallet = default(WalletModel))
        {
            this.Id = id;
            this.GameId = gameId;
            this.WalletId = walletId;
            this.ConnectedWalletId = connectedWalletId;
            this.ProfileId = profileId;
            this.Username = username;
            this.AccessToken = accessToken;
            this.ProfilePermissions = profilePermissions;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Wallet = wallet;
            this.CustodialWallet = custodialWallet;
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
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public string GameId { get; set; }

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
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public string ProfileId { get; set; }

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
        [DataMember(Name="profilePermissions", EmitDefaultValue=false)]
        public Object ProfilePermissions { get; set; }

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
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=false)]
        public WalletModel Wallet { get; set; }

        /// <summary>
        /// Gets or Sets CustodialWallet
        /// </summary>
        [DataMember(Name="custodialWallet", EmitDefaultValue=false)]
        public WalletModel CustodialWallet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProfilePlayer200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  ConnectedWalletId: ").Append(ConnectedWalletId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ProfilePermissions: ").Append(ProfilePermissions).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  CustodialWallet: ").Append(CustodialWallet).Append("\n");
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
            return this.Equals(input as UpdateProfilePlayer200Response);
        }

        /// <summary>
        /// Returns true if UpdateProfilePlayer200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProfilePlayer200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProfilePlayer200Response input)
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
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
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
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
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
                    this.ProfilePermissions == input.ProfilePermissions ||
                    (this.ProfilePermissions != null &&
                    this.ProfilePermissions.Equals(input.ProfilePermissions))
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
                ) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
                ) && 
                (
                    this.CustodialWallet == input.CustodialWallet ||
                    (this.CustodialWallet != null &&
                    this.CustodialWallet.Equals(input.CustodialWallet))
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
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.ConnectedWalletId != null)
                    hashCode = hashCode * 59 + this.ConnectedWalletId.GetHashCode();
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.ProfilePermissions != null)
                    hashCode = hashCode * 59 + this.ProfilePermissions.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Wallet != null)
                    hashCode = hashCode * 59 + this.Wallet.GetHashCode();
                if (this.CustodialWallet != null)
                    hashCode = hashCode * 59 + this.CustodialWallet.GetHashCode();
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