
# Org.MetaFab.Model.SetCurrencyFeesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipientAddress** | **string** | The recipient address of currency transaction fees. | 
**BasisPoints** | **decimal** | A percentage fee for every transaction represented in basis points. To set a 1.5% fee, you would use a value of 150. This value can be 0, denoting no percentage fees. | 
**FixedAmount** | **decimal** | A fixed fee for every transaction. A value of 0.5 would mean 0.5 of the currency of a transaction is always taken as a fee. This value can be 0, denoting no fixed fees. | 
**CapAmount** | **decimal** | The maximum fee amount for any single transaction. The total fee of a transaction is calculated as the sum of the basis points (percentage) fee, and fixed fee. If a calculated fee is greater than this maximum fee value, the maximum fee will be used instead. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

