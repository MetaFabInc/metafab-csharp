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
    /// TransactionModel
    /// </summary>
    [DataContract]
    public partial class TransactionModel :  IEquatable<TransactionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionModel" /> class.
        /// </summary>
        /// <param name="id">This field has not had a description added..</param>
        /// <param name="contractId">This field has not had a description added..</param>
        /// <param name="walletId">This field has not had a description added..</param>
        /// <param name="function">This field has not had a description added..</param>
        /// <param name="args">This field has not had a description added..</param>
        /// <param name="hash">This field has not had a description added..</param>
        /// <param name="updatedAt">This field has not had a description added..</param>
        /// <param name="createdAt">This field has not had a description added..</param>
        public TransactionModel(string id = default(string), string contractId = default(string), string walletId = default(string), string function = default(string), Object args = default(Object), string hash = default(string), string updatedAt = default(string), string createdAt = default(string))
        {
            this.Id = id;
            this.ContractId = contractId;
            this.WalletId = walletId;
            this.Function = function;
            this.Args = args;
            this.Hash = hash;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
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
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public string ContractId { get; set; }

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
        [DataMember(Name="function", EmitDefaultValue=false)]
        public string Function { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public Object Args { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as TransactionModel);
        }

        /// <summary>
        /// Returns true if TransactionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionModel input)
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
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.Function == input.Function ||
                    (this.Function != null &&
                    this.Function.Equals(input.Function))
                ) && 
                (
                    this.Args == input.Args ||
                    (this.Args != null &&
                    this.Args.Equals(input.Args))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
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
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
