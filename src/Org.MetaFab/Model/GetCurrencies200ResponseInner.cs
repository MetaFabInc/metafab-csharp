/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.1.4
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
    /// GetCurrencies200ResponseInner
    /// </summary>
    [DataContract]
    public partial class GetCurrencies200ResponseInner :  IEquatable<GetCurrencies200ResponseInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrencies200ResponseInner" /> class.
        /// </summary>
        /// <param name="id">This field has not had a description added..</param>
        /// <param name="gameId">This field has not had a description added..</param>
        /// <param name="contractId">This field has not had a description added..</param>
        /// <param name="name">This field has not had a description added..</param>
        /// <param name="symbol">This field has not had a description added..</param>
        /// <param name="supplyCap">This field has not had a description added..</param>
        /// <param name="updatedAt">This field has not had a description added..</param>
        /// <param name="createdAt">This field has not had a description added..</param>
        /// <param name="contract">contract.</param>
        public GetCurrencies200ResponseInner(string id = default(string), string gameId = default(string), string contractId = default(string), string name = default(string), string symbol = default(string), int supplyCap = default(int), string updatedAt = default(string), string createdAt = default(string), ContractModel contract = default(ContractModel))
        {
            this.Id = id;
            this.GameId = gameId;
            this.ContractId = contractId;
            this.Name = name;
            this.Symbol = symbol;
            this.SupplyCap = supplyCap;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Contract = contract;
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
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public string ContractId { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// This field has not had a description added.
        /// </summary>
        /// <value>This field has not had a description added.</value>
        [DataMember(Name="supplyCap", EmitDefaultValue=false)]
        public int SupplyCap { get; set; }

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
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public ContractModel Contract { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCurrencies200ResponseInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  SupplyCap: ").Append(SupplyCap).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as GetCurrencies200ResponseInner);
        }

        /// <summary>
        /// Returns true if GetCurrencies200ResponseInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCurrencies200ResponseInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCurrencies200ResponseInner input)
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
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.SupplyCap == input.SupplyCap ||
                    (this.SupplyCap != null &&
                    this.SupplyCap.Equals(input.SupplyCap))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.SupplyCap != null)
                    hashCode = hashCode * 59 + this.SupplyCap.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
