/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.2.1
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
    /// CreateGameRequest
    /// </summary>
    [DataContract]
    public partial class CreateGameRequest :  IEquatable<CreateGameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGameRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGameRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGameRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the game you&#39;re creating. (required).</param>
        /// <param name="email">The email address associated with this game and used to login/authenticate as the game. (required).</param>
        /// <param name="password">The password to authenticate as the game. Additionally, this password is used to encrypt/decrypt your game&#39;s primary wallet and must be provided anytime this game makes blockchain interactions through various endpoints. (required).</param>
        public CreateGameRequest(string name = default(string), string email = default(string), string password = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateGameRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for CreateGameRequest and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for CreateGameRequest and cannot be null");
            }
            else
            {
                this.Password = password;
            }

        }

        /// <summary>
        /// The name of the game you&#39;re creating.
        /// </summary>
        /// <value>The name of the game you&#39;re creating.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The email address associated with this game and used to login/authenticate as the game.
        /// </summary>
        /// <value>The email address associated with this game and used to login/authenticate as the game.</value>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// The password to authenticate as the game. Additionally, this password is used to encrypt/decrypt your game&#39;s primary wallet and must be provided anytime this game makes blockchain interactions through various endpoints.
        /// </summary>
        /// <value>The password to authenticate as the game. Additionally, this password is used to encrypt/decrypt your game&#39;s primary wallet and must be provided anytime this game makes blockchain interactions through various endpoints.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGameRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as CreateGameRequest);
        }

        /// <summary>
        /// Returns true if CreateGameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGameRequest input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
