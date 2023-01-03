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
    /// WriteContractRequest
    /// </summary>
    [DataContract]
    public partial class WriteContractRequest :  IEquatable<WriteContractRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteContractRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WriteContractRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteContractRequest" /> class.
        /// </summary>
        /// <param name="func">A contract function name. This can be any valid function from the the ABI of the contract you are interacting with. For example, &#x60;mint&#x60;. (required).</param>
        /// <param name="args">An array of args. This is optional and only necessary if the function being invoked requires arguments per the contract ABI. For example, &#x60;[123, \&quot;Hello\&quot;, false]&#x60;..</param>
        public WriteContractRequest(string func = default(string), List<WriteContractRequestArgsInner> args = default(List<WriteContractRequestArgsInner>))
        {
            // to ensure "func" is required (not null)
            if (func == null)
            {
                throw new InvalidDataException("func is a required property for WriteContractRequest and cannot be null");
            }
            else
            {
                this.Func = func;
            }

            this.Args = args;
        }

        /// <summary>
        /// A contract function name. This can be any valid function from the the ABI of the contract you are interacting with. For example, &#x60;mint&#x60;.
        /// </summary>
        /// <value>A contract function name. This can be any valid function from the the ABI of the contract you are interacting with. For example, &#x60;mint&#x60;.</value>
        [DataMember(Name="func", EmitDefaultValue=true)]
        public string Func { get; set; }

        /// <summary>
        /// An array of args. This is optional and only necessary if the function being invoked requires arguments per the contract ABI. For example, &#x60;[123, \&quot;Hello\&quot;, false]&#x60;.
        /// </summary>
        /// <value>An array of args. This is optional and only necessary if the function being invoked requires arguments per the contract ABI. For example, &#x60;[123, \&quot;Hello\&quot;, false]&#x60;.</value>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<WriteContractRequestArgsInner> Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WriteContractRequest {\n");
            sb.Append("  Func: ").Append(Func).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
            return this.Equals(input as WriteContractRequest);
        }

        /// <summary>
        /// Returns true if WriteContractRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteContractRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteContractRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Func == input.Func ||
                    (this.Func != null &&
                    this.Func.Equals(input.Func))
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
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
                if (this.Func != null)
                    hashCode = hashCode * 59 + this.Func.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
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
