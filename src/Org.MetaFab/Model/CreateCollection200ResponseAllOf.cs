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
    /// CreateCollection200ResponseAllOf
    /// </summary>
    [DataContract]
    public partial class CreateCollection200ResponseAllOf :  IEquatable<CreateCollection200ResponseAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollection200ResponseAllOf" /> class.
        /// </summary>
        /// <param name="contract">contract.</param>
        public CreateCollection200ResponseAllOf(CreateCollection200ResponseAllOfContract contract = default(CreateCollection200ResponseAllOfContract))
        {
            this.Contract = contract;
        }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public CreateCollection200ResponseAllOfContract Contract { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCollection200ResponseAllOf {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
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
            return this.Equals(input as CreateCollection200ResponseAllOf);
        }

        /// <summary>
        /// Returns true if CreateCollection200ResponseAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollection200ResponseAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollection200ResponseAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
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
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
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