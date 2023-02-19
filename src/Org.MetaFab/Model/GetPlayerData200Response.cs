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
    /// GetPlayerData200Response
    /// </summary>
    [DataContract]
    public partial class GetPlayerData200Response :  IEquatable<GetPlayerData200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPlayerData200Response" /> class.
        /// </summary>
        /// <param name="protectedData">protectedData.</param>
        /// <param name="publicData">publicData.</param>
        public GetPlayerData200Response(Object protectedData = default(Object), Object publicData = default(Object))
        {
            this.ProtectedData = protectedData;
            this.PublicData = publicData;
        }

        /// <summary>
        /// Gets or Sets ProtectedData
        /// </summary>
        [DataMember(Name="protectedData", EmitDefaultValue=false)]
        public Object ProtectedData { get; set; }

        /// <summary>
        /// Gets or Sets PublicData
        /// </summary>
        [DataMember(Name="publicData", EmitDefaultValue=false)]
        public Object PublicData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPlayerData200Response {\n");
            sb.Append("  ProtectedData: ").Append(ProtectedData).Append("\n");
            sb.Append("  PublicData: ").Append(PublicData).Append("\n");
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
            return this.Equals(input as GetPlayerData200Response);
        }

        /// <summary>
        /// Returns true if GetPlayerData200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPlayerData200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPlayerData200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProtectedData == input.ProtectedData ||
                    (this.ProtectedData != null &&
                    this.ProtectedData.Equals(input.ProtectedData))
                ) && 
                (
                    this.PublicData == input.PublicData ||
                    (this.PublicData != null &&
                    this.PublicData.Equals(input.PublicData))
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
                if (this.ProtectedData != null)
                    hashCode = hashCode * 59 + this.ProtectedData.GetHashCode();
                if (this.PublicData != null)
                    hashCode = hashCode * 59 + this.PublicData.GetHashCode();
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
