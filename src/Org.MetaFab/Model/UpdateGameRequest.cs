/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.4.1
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
    /// UpdateGameRequest
    /// </summary>
    [DataContract]
    public partial class UpdateGameRequest :  IEquatable<UpdateGameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGameRequest" /> class.
        /// </summary>
        /// <param name="name">A new name. Replaces the game&#39;s current name..</param>
        /// <param name="email">A new email address. The game&#39;s old email will no longer be valid for account authentication. &#x60;currentPassword&#x60; must also be provided..</param>
        /// <param name="currentPassword">The game&#39;s current password. Must be provided if setting &#x60;newPassword&#x60; or &#x60;email&#x60;..</param>
        /// <param name="newPassword">A new password. The game&#39;s old password will no longer be valid..</param>
        /// <param name="rpcs">Sets a custom RPC for your game to use instead of MetaFab&#39;s default RPCs for the chain(s) you specify.  Expects a JSON object containing key value pairs of supported &#x60;chain&#x60; -&gt; &#x60;rpc url&#x60;. Only the chain names provided as keys in the object will be explicitly overriden. To delete a custom RPC for your game, provide the chain name to delete as a key in the provided object and &#x60;null&#x60; as the value.  Set RPC example, &#x60;{ MATIC: &#39;https://polygon-rpc.com&#39; }&#x60; Delete RPC example, &#x60;{ MATIC: null }&#x60;.</param>
        /// <param name="redirectUris">An array of valid base redirect uris or exact uris that can be used for the redirect uri of various MetaFab features such as player login/registration and wallet connection.  Expects base or exact uris. For example, you could use include a uri of &#x60;https://trymetafab.com&#x60; and it would allow redirection to any valid uri on the domain, such as &#x60;https://trymetafab.com/play/game&#x60;..</param>
        /// <param name="iconImageBase64">A base64 string of the icon image for this game. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60; Recommended size is 512x512 pixels, or 1:1 aspect ratio. This image is used for your auth/connect wallet flow and other MetaFab features for your game..</param>
        /// <param name="coverImageBase64">A base64 string of the cover image for this game. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60;. Recommended size is 1600x1000 pixels, or 16:10 aspect ratio.  This image is used as the background image for your auth/connect wallet flow and other MetaFab features for your game..</param>
        /// <param name="primaryColorHex">A valid hex color code. This color is used for your auth/connect wallet flow to control the color of buttons and other brandable MetaFab features for your game..</param>
        /// <param name="resetPublishedKey">Revokes the game&#39;s previous published key and returns a new one if true..</param>
        /// <param name="resetSecretKey">Revokes the game&#39;s previous secret key and returns a new on if true..</param>
        public UpdateGameRequest(string name = default(string), string email = default(string), string currentPassword = default(string), string newPassword = default(string), Dictionary<string, string> rpcs = default(Dictionary<string, string>), List<string> redirectUris = default(List<string>), string iconImageBase64 = default(string), string coverImageBase64 = default(string), string primaryColorHex = default(string), bool resetPublishedKey = default(bool), bool resetSecretKey = default(bool))
        {
            this.Name = name;
            this.Email = email;
            this.CurrentPassword = currentPassword;
            this.NewPassword = newPassword;
            this.Rpcs = rpcs;
            this.RedirectUris = redirectUris;
            this.IconImageBase64 = iconImageBase64;
            this.CoverImageBase64 = coverImageBase64;
            this.PrimaryColorHex = primaryColorHex;
            this.ResetPublishedKey = resetPublishedKey;
            this.ResetSecretKey = resetSecretKey;
        }

        /// <summary>
        /// A new name. Replaces the game&#39;s current name.
        /// </summary>
        /// <value>A new name. Replaces the game&#39;s current name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A new email address. The game&#39;s old email will no longer be valid for account authentication. &#x60;currentPassword&#x60; must also be provided.
        /// </summary>
        /// <value>A new email address. The game&#39;s old email will no longer be valid for account authentication. &#x60;currentPassword&#x60; must also be provided.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The game&#39;s current password. Must be provided if setting &#x60;newPassword&#x60; or &#x60;email&#x60;.
        /// </summary>
        /// <value>The game&#39;s current password. Must be provided if setting &#x60;newPassword&#x60; or &#x60;email&#x60;.</value>
        [DataMember(Name="currentPassword", EmitDefaultValue=false)]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// A new password. The game&#39;s old password will no longer be valid.
        /// </summary>
        /// <value>A new password. The game&#39;s old password will no longer be valid.</value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Sets a custom RPC for your game to use instead of MetaFab&#39;s default RPCs for the chain(s) you specify.  Expects a JSON object containing key value pairs of supported &#x60;chain&#x60; -&gt; &#x60;rpc url&#x60;. Only the chain names provided as keys in the object will be explicitly overriden. To delete a custom RPC for your game, provide the chain name to delete as a key in the provided object and &#x60;null&#x60; as the value.  Set RPC example, &#x60;{ MATIC: &#39;https://polygon-rpc.com&#39; }&#x60; Delete RPC example, &#x60;{ MATIC: null }&#x60;
        /// </summary>
        /// <value>Sets a custom RPC for your game to use instead of MetaFab&#39;s default RPCs for the chain(s) you specify.  Expects a JSON object containing key value pairs of supported &#x60;chain&#x60; -&gt; &#x60;rpc url&#x60;. Only the chain names provided as keys in the object will be explicitly overriden. To delete a custom RPC for your game, provide the chain name to delete as a key in the provided object and &#x60;null&#x60; as the value.  Set RPC example, &#x60;{ MATIC: &#39;https://polygon-rpc.com&#39; }&#x60; Delete RPC example, &#x60;{ MATIC: null }&#x60;</value>
        [DataMember(Name="rpcs", EmitDefaultValue=false)]
        public Dictionary<string, string> Rpcs { get; set; }

        /// <summary>
        /// An array of valid base redirect uris or exact uris that can be used for the redirect uri of various MetaFab features such as player login/registration and wallet connection.  Expects base or exact uris. For example, you could use include a uri of &#x60;https://trymetafab.com&#x60; and it would allow redirection to any valid uri on the domain, such as &#x60;https://trymetafab.com/play/game&#x60;.
        /// </summary>
        /// <value>An array of valid base redirect uris or exact uris that can be used for the redirect uri of various MetaFab features such as player login/registration and wallet connection.  Expects base or exact uris. For example, you could use include a uri of &#x60;https://trymetafab.com&#x60; and it would allow redirection to any valid uri on the domain, such as &#x60;https://trymetafab.com/play/game&#x60;.</value>
        [DataMember(Name="redirectUris", EmitDefaultValue=false)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// A base64 string of the icon image for this game. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60; Recommended size is 512x512 pixels, or 1:1 aspect ratio. This image is used for your auth/connect wallet flow and other MetaFab features for your game.
        /// </summary>
        /// <value>A base64 string of the icon image for this game. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60; Recommended size is 512x512 pixels, or 1:1 aspect ratio. This image is used for your auth/connect wallet flow and other MetaFab features for your game.</value>
        [DataMember(Name="iconImageBase64", EmitDefaultValue=false)]
        public string IconImageBase64 { get; set; }

        /// <summary>
        /// A base64 string of the cover image for this game. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60;. Recommended size is 1600x1000 pixels, or 16:10 aspect ratio.  This image is used as the background image for your auth/connect wallet flow and other MetaFab features for your game.
        /// </summary>
        /// <value>A base64 string of the cover image for this game. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60;. Recommended size is 1600x1000 pixels, or 16:10 aspect ratio.  This image is used as the background image for your auth/connect wallet flow and other MetaFab features for your game.</value>
        [DataMember(Name="coverImageBase64", EmitDefaultValue=false)]
        public string CoverImageBase64 { get; set; }

        /// <summary>
        /// A valid hex color code. This color is used for your auth/connect wallet flow to control the color of buttons and other brandable MetaFab features for your game.
        /// </summary>
        /// <value>A valid hex color code. This color is used for your auth/connect wallet flow to control the color of buttons and other brandable MetaFab features for your game.</value>
        [DataMember(Name="primaryColorHex", EmitDefaultValue=false)]
        public string PrimaryColorHex { get; set; }

        /// <summary>
        /// Revokes the game&#39;s previous published key and returns a new one if true.
        /// </summary>
        /// <value>Revokes the game&#39;s previous published key and returns a new one if true.</value>
        [DataMember(Name="resetPublishedKey", EmitDefaultValue=false)]
        public bool ResetPublishedKey { get; set; }

        /// <summary>
        /// Revokes the game&#39;s previous secret key and returns a new on if true.
        /// </summary>
        /// <value>Revokes the game&#39;s previous secret key and returns a new on if true.</value>
        [DataMember(Name="resetSecretKey", EmitDefaultValue=false)]
        public bool ResetSecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateGameRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CurrentPassword: ").Append(CurrentPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  Rpcs: ").Append(Rpcs).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("  IconImageBase64: ").Append(IconImageBase64).Append("\n");
            sb.Append("  CoverImageBase64: ").Append(CoverImageBase64).Append("\n");
            sb.Append("  PrimaryColorHex: ").Append(PrimaryColorHex).Append("\n");
            sb.Append("  ResetPublishedKey: ").Append(ResetPublishedKey).Append("\n");
            sb.Append("  ResetSecretKey: ").Append(ResetSecretKey).Append("\n");
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
            return this.Equals(input as UpdateGameRequest);
        }

        /// <summary>
        /// Returns true if UpdateGameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateGameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateGameRequest input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CurrentPassword == input.CurrentPassword ||
                    (this.CurrentPassword != null &&
                    this.CurrentPassword.Equals(input.CurrentPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.Rpcs == input.Rpcs ||
                    this.Rpcs != null &&
                    input.Rpcs != null &&
                    this.Rpcs.SequenceEqual(input.Rpcs)
                ) && 
                (
                    this.RedirectUris == input.RedirectUris ||
                    this.RedirectUris != null &&
                    input.RedirectUris != null &&
                    this.RedirectUris.SequenceEqual(input.RedirectUris)
                ) && 
                (
                    this.IconImageBase64 == input.IconImageBase64 ||
                    (this.IconImageBase64 != null &&
                    this.IconImageBase64.Equals(input.IconImageBase64))
                ) && 
                (
                    this.CoverImageBase64 == input.CoverImageBase64 ||
                    (this.CoverImageBase64 != null &&
                    this.CoverImageBase64.Equals(input.CoverImageBase64))
                ) && 
                (
                    this.PrimaryColorHex == input.PrimaryColorHex ||
                    (this.PrimaryColorHex != null &&
                    this.PrimaryColorHex.Equals(input.PrimaryColorHex))
                ) && 
                (
                    this.ResetPublishedKey == input.ResetPublishedKey ||
                    (this.ResetPublishedKey != null &&
                    this.ResetPublishedKey.Equals(input.ResetPublishedKey))
                ) && 
                (
                    this.ResetSecretKey == input.ResetSecretKey ||
                    (this.ResetSecretKey != null &&
                    this.ResetSecretKey.Equals(input.ResetSecretKey))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CurrentPassword != null)
                    hashCode = hashCode * 59 + this.CurrentPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.Rpcs != null)
                    hashCode = hashCode * 59 + this.Rpcs.GetHashCode();
                if (this.RedirectUris != null)
                    hashCode = hashCode * 59 + this.RedirectUris.GetHashCode();
                if (this.IconImageBase64 != null)
                    hashCode = hashCode * 59 + this.IconImageBase64.GetHashCode();
                if (this.CoverImageBase64 != null)
                    hashCode = hashCode * 59 + this.CoverImageBase64.GetHashCode();
                if (this.PrimaryColorHex != null)
                    hashCode = hashCode * 59 + this.PrimaryColorHex.GetHashCode();
                if (this.ResetPublishedKey != null)
                    hashCode = hashCode * 59 + this.ResetPublishedKey.GetHashCode();
                if (this.ResetSecretKey != null)
                    hashCode = hashCode * 59 + this.ResetSecretKey.GetHashCode();
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
