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
    /// SetCollectionItemTimelockRequest
    /// </summary>
    [DataContract]
    public partial class SetCollectionItemTimelockRequest :  IEquatable<SetCollectionItemTimelockRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetCollectionItemTimelockRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetCollectionItemTimelockRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetCollectionItemTimelockRequest" /> class.
        /// </summary>
        /// <param name="timelock">A unix timestamp (in seconds) defining when the set timelock expires. (required).</param>
        public SetCollectionItemTimelockRequest(decimal timelock = default(decimal))
        {
            // to ensure "timelock" is required (not null)
            if (timelock == null)
            {
                throw new InvalidDataException("timelock is a required property for SetCollectionItemTimelockRequest and cannot be null");
            }
            else
            {
                this.Timelock = timelock;
            }

        }

        /// <summary>
        /// A unix timestamp (in seconds) defining when the set timelock expires.
        /// </summary>
        /// <value>A unix timestamp (in seconds) defining when the set timelock expires.</value>
        [DataMember(Name="timelock", EmitDefaultValue=true)]
        public decimal Timelock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetCollectionItemTimelockRequest {\n");
            sb.Append("  Timelock: ").Append(Timelock).Append("\n");
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
            return this.Equals(input as SetCollectionItemTimelockRequest);
        }

        /// <summary>
        /// Returns true if SetCollectionItemTimelockRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetCollectionItemTimelockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetCollectionItemTimelockRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timelock == input.Timelock ||
                    (this.Timelock != null &&
                    this.Timelock.Equals(input.Timelock))
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
                if (this.Timelock != null)
                    hashCode = hashCode * 59 + this.Timelock.GetHashCode();
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
