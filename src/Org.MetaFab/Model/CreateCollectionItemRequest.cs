/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// CreateCollectionItemRequest
    /// </summary>
    [DataContract]
    public partial class CreateCollectionItemRequest :  IEquatable<CreateCollectionItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCollectionItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionItemRequest" /> class.
        /// </summary>
        /// <param name="id">A unique itemId to use for this item within the collection. If an existing itemId is used, the current metadata will be overriden. Any number may be used.  The terms &#x60;itemId&#x60; and &#x60;collectionItemId&#x60; are used interchangeably and equivalent to one another throughout MetaFab documentation. (required).</param>
        /// <param name="name">The name of this item. (required).</param>
        /// <param name="description">A text description of this item. This is a great spot to include lore, game mechanics and more related to this item. (required).</param>
        /// <param name="imageBase64">A base64 string of the image for this item. Either &#x60;imageBase64&#x60; or &#x60;imageUrl&#x60; must be provided. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60;. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels..</param>
        /// <param name="imageUrl">An external url that resolves to an image to use for this item. This can also be set to an ipfs:// uri. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels..</param>
        /// <param name="externalUrl">An optional URL where players can go to learn more about this item specifically, or your game, or any other link..</param>
        /// <param name="attributes">An array of objects that conform with metadata standard..</param>
        /// <param name="data">An arbitrary object of data attached to the top level metadata object. This is useful for including data or resource URLs specific to your game. Such as URLs that point to.</param>
        public CreateCollectionItemRequest(decimal id = default(decimal), string name = default(string), string description = default(string), byte[] imageBase64 = default(byte[]), string imageUrl = default(string), string externalUrl = default(string), List<CreateCollectionItemRequestAttributesInner> attributes = default(List<CreateCollectionItemRequestAttributesInner>), Object data = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreateCollectionItemRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateCollectionItemRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for CreateCollectionItemRequest and cannot be null");
            }
            else
            {
                this.Description = description;
            }

            this.ImageBase64 = imageBase64;
            this.ImageUrl = imageUrl;
            this.ExternalUrl = externalUrl;
            this.Attributes = attributes;
            this.Data = data;
        }

        /// <summary>
        /// A unique itemId to use for this item within the collection. If an existing itemId is used, the current metadata will be overriden. Any number may be used.  The terms &#x60;itemId&#x60; and &#x60;collectionItemId&#x60; are used interchangeably and equivalent to one another throughout MetaFab documentation.
        /// </summary>
        /// <value>A unique itemId to use for this item within the collection. If an existing itemId is used, the current metadata will be overriden. Any number may be used.  The terms &#x60;itemId&#x60; and &#x60;collectionItemId&#x60; are used interchangeably and equivalent to one another throughout MetaFab documentation.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public decimal Id { get; set; }

        /// <summary>
        /// The name of this item.
        /// </summary>
        /// <value>The name of this item.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// A text description of this item. This is a great spot to include lore, game mechanics and more related to this item.
        /// </summary>
        /// <value>A text description of this item. This is a great spot to include lore, game mechanics and more related to this item.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// A base64 string of the image for this item. Either &#x60;imageBase64&#x60; or &#x60;imageUrl&#x60; must be provided. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60;. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels.
        /// </summary>
        /// <value>A base64 string of the image for this item. Either &#x60;imageBase64&#x60; or &#x60;imageUrl&#x60; must be provided. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60;. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels.</value>
        [DataMember(Name="imageBase64", EmitDefaultValue=false)]
        public byte[] ImageBase64 { get; set; }

        /// <summary>
        /// An external url that resolves to an image to use for this item. This can also be set to an ipfs:// uri. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels.
        /// </summary>
        /// <value>An external url that resolves to an image to use for this item. This can also be set to an ipfs:// uri. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels.</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// An optional URL where players can go to learn more about this item specifically, or your game, or any other link.
        /// </summary>
        /// <value>An optional URL where players can go to learn more about this item specifically, or your game, or any other link.</value>
        [DataMember(Name="externalUrl", EmitDefaultValue=false)]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// An array of objects that conform with metadata standard.
        /// </summary>
        /// <value>An array of objects that conform with metadata standard.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<CreateCollectionItemRequestAttributesInner> Attributes { get; set; }

        /// <summary>
        /// An arbitrary object of data attached to the top level metadata object. This is useful for including data or resource URLs specific to your game. Such as URLs that point to
        /// </summary>
        /// <value>An arbitrary object of data attached to the top level metadata object. This is useful for including data or resource URLs specific to your game. Such as URLs that point to</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Object Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCollectionItemRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as CreateCollectionItemRequest);
        }

        /// <summary>
        /// Returns true if CreateCollectionItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollectionItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollectionItemRequest input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageBase64 == input.ImageBase64 ||
                    (this.ImageBase64 != null &&
                    this.ImageBase64.Equals(input.ImageBase64))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.ExternalUrl == input.ExternalUrl ||
                    (this.ExternalUrl != null &&
                    this.ExternalUrl.Equals(input.ExternalUrl))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ImageBase64 != null)
                    hashCode = hashCode * 59 + this.ImageBase64.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ExternalUrl != null)
                    hashCode = hashCode * 59 + this.ExternalUrl.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
