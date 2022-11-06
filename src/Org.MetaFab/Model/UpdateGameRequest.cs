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
        /// <param name="resetPublishedKey">Revokes the game&#39;s previous published key and returns a new one if true..</param>
        /// <param name="resetSecretKey">Revokes the game&#39;s previous secret key and returns a new on if true..</param>
        public UpdateGameRequest(string name = default(string), string email = default(string), string currentPassword = default(string), string newPassword = default(string), Dictionary<string, string> rpcs = default(Dictionary<string, string>), bool resetPublishedKey = default(bool), bool resetSecretKey = default(bool))
        {
            this.Name = name;
            this.Email = email;
            this.CurrentPassword = currentPassword;
            this.NewPassword = newPassword;
            this.Rpcs = rpcs;
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
