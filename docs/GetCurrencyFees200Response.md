
# Org.MetaFab.Model.GetCurrencyFees200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipientAddress** | **string** | The wallet address that fees from all applicable transactions are automatically sent to. | [optional] 
**BasisPoints** | **decimal** | The number of fee basis points. 100 basisPoints &#x3D; 1% fee of the total transaction amount deducted from the total received by the recipient. | [optional] 
**FixedAmount** | **decimal** | The fixed number of currency as a fee regardless of the total transaction amount. 10 &#x3D; 10 of the currency as a fee for any transaction, deducted from the total received by the recipient. | [optional] 
**CapAmount** | **decimal** | The maximum combined fee between basisPoints and fixedAmount. If the total transaction fee is over this amount, the capAmount will be used as the transaction fee deducted from the total received by the recipient. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

