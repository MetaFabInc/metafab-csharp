
# Org.MetaFab.Model.WithdrawFromExchangeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | A valid EVM based address to withdraw to. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;. | [optional] 
**WalletId** | **string** | Any wallet id within the MetaFab ecosystem to withdraw to. | [optional] 
**CurrencyAddress** | **string** | The address of the currency (ERC20) token to withdraw from the exchange. If no currencyAddress or currencyId, and no collectionAddress or collectionId are provided, the native token held by the exchange will be withdrawn. | [optional] 
**CurrencyId** | **string** | A valid MetaFab currency id that represents the currency token to withdraw from the exchange. &#x60;currencyAddress&#x60; or &#x60;currencyId&#x60; can be provided when withdrawing currency. | [optional] 
**CollectionAddress** | **string** | The address of the collection (ERC1155) for the items to withdraw from the exchange. If no currencyAddress and no collectionAddress is provided, the native token held by the exchange will be withdrawn. | [optional] 
**CollectionId** | **string** | A valid MetaFab collection id that represents the collection for the items to withdraw from the exchange. &#x60;collectionAddress&#x60; or &#x60;collectionId&#x60; can be provided when withdrawing items. | [optional] 
**ItemIds** | **List&lt;decimal&gt;** | The specific itemIds of the provided collection to withdraw from the exchange. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
