/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.3.0
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
    /// CreateCollection200ResponseAllOfContract
    /// </summary>
    [DataContract]
    public partial class CreateCollection200ResponseAllOfContract :  IEquatable<CreateCollection200ResponseAllOfContract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollection200ResponseAllOfContract" /> class.
        /// </summary>
        /// <param name="id">This field has not had a description added..</param>
        /// <param name="gameId">This field has not had a description added..</param>
        /// <param name="chain">This field has not had a description added..</param>
        /// <param name="abi">This field has not had a description added..</param>
        /// <param name="type">This field has not had a description added..</param>
        /// <param name="address">This field has not had a description added..</param>
        /// <param name="updatedAt">This field has not had a description added..</param>
        /// <param name="createdAt">This field has not had a description added..</param>
        /// <param name="transactions">transactions.</param>
        public CreateCollection200ResponseAllOfContract(string id = default(string), string gameId = default(string), string chain = default(string), Object abi = default(Object), string type = default(string), string address = default(string), string updatedAt = default(string), string createdAt = default(string), List<TransactionModel> transactions = default(List<TransactionModel>))
        {
            this.Id = id;
            this.GameId = gameId;
            this.Chain = chain;
            this.Abi = abi;
            this.Type = type;
            this.Address = address;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Transactions = transactions;
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
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public string GameId { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="chain", EmitDefaultValue=false)]
        public string Chain { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="abi", EmitDefaultValue=false)]
        public Object Abi { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

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
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<TransactionModel> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCollection200ResponseAllOfContract {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Abi: ").Append(Abi).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as CreateCollection200ResponseAllOfContract);
        }

        /// <summary>
        /// Returns true if CreateCollection200ResponseAllOfContract instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollection200ResponseAllOfContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollection200ResponseAllOfContract input)
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
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.Abi == input.Abi ||
                    (this.Abi != null &&
                    this.Abi.Equals(input.Abi))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.Chain != null)
                    hashCode = hashCode * 59 + this.Chain.GetHashCode();
                if (this.Abi != null)
                    hashCode = hashCode * 59 + this.Abi.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
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
