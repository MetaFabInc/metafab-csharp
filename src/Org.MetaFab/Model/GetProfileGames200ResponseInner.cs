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
    /// GetProfileGames200ResponseInner
    /// </summary>
    [DataContract]
    public partial class GetProfileGames200ResponseInner :  IEquatable<GetProfileGames200ResponseInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileGames200ResponseInner" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="publishedKey">publishedKey.</param>
        /// <param name="iconImageUrl">iconImageUrl.</param>
        /// <param name="coverImageUrl">coverImageUrl.</param>
        /// <param name="primaryColorHex">primaryColorHex.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="players">players.</param>
        public GetProfileGames200ResponseInner(string id = default(string), string name = default(string), string publishedKey = default(string), string iconImageUrl = default(string), string coverImageUrl = default(string), string primaryColorHex = default(string), string createdAt = default(string), List<PublicPlayer> players = default(List<PublicPlayer>))
        {
            this.Id = id;
            this.Name = name;
            this.PublishedKey = publishedKey;
            this.IconImageUrl = iconImageUrl;
            this.CoverImageUrl = coverImageUrl;
            this.PrimaryColorHex = primaryColorHex;
            this.CreatedAt = createdAt;
            this.Players = players;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PublishedKey
        /// </summary>
        [DataMember(Name="publishedKey", EmitDefaultValue=false)]
        public string PublishedKey { get; set; }

        /// <summary>
        /// Gets or Sets IconImageUrl
        /// </summary>
        [DataMember(Name="iconImageUrl", EmitDefaultValue=false)]
        public string IconImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CoverImageUrl
        /// </summary>
        [DataMember(Name="coverImageUrl", EmitDefaultValue=false)]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryColorHex
        /// </summary>
        [DataMember(Name="primaryColorHex", EmitDefaultValue=false)]
        public string PrimaryColorHex { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [DataMember(Name="players", EmitDefaultValue=false)]
        public List<PublicPlayer> Players { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProfileGames200ResponseInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PublishedKey: ").Append(PublishedKey).Append("\n");
            sb.Append("  IconImageUrl: ").Append(IconImageUrl).Append("\n");
            sb.Append("  CoverImageUrl: ").Append(CoverImageUrl).Append("\n");
            sb.Append("  PrimaryColorHex: ").Append(PrimaryColorHex).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
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
            return this.Equals(input as GetProfileGames200ResponseInner);
        }

        /// <summary>
        /// Returns true if GetProfileGames200ResponseInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProfileGames200ResponseInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProfileGames200ResponseInner input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublishedKey == input.PublishedKey ||
                    (this.PublishedKey != null &&
                    this.PublishedKey.Equals(input.PublishedKey))
                ) && 
                (
                    this.IconImageUrl == input.IconImageUrl ||
                    (this.IconImageUrl != null &&
                    this.IconImageUrl.Equals(input.IconImageUrl))
                ) && 
                (
                    this.CoverImageUrl == input.CoverImageUrl ||
                    (this.CoverImageUrl != null &&
                    this.CoverImageUrl.Equals(input.CoverImageUrl))
                ) && 
                (
                    this.PrimaryColorHex == input.PrimaryColorHex ||
                    (this.PrimaryColorHex != null &&
                    this.PrimaryColorHex.Equals(input.PrimaryColorHex))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Players == input.Players ||
                    this.Players != null &&
                    input.Players != null &&
                    this.Players.SequenceEqual(input.Players)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PublishedKey != null)
                    hashCode = hashCode * 59 + this.PublishedKey.GetHashCode();
                if (this.IconImageUrl != null)
                    hashCode = hashCode * 59 + this.IconImageUrl.GetHashCode();
                if (this.CoverImageUrl != null)
                    hashCode = hashCode * 59 + this.CoverImageUrl.GetHashCode();
                if (this.PrimaryColorHex != null)
                    hashCode = hashCode * 59 + this.PrimaryColorHex.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Players != null)
                    hashCode = hashCode * 59 + this.Players.GetHashCode();
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