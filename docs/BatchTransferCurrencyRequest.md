
# Org.MetaFab.Model.BatchTransferCurrencyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addresses** | **List&lt;string&gt;** | An array of valid EVM based addresses to transfer currency to. | [optional] 
**WalletIds** | **List&lt;string&gt;** | An array of wallet ids within the MetaFab ecosystem to transfer currency to. | [optional] 
**Amounts** | **List&lt;decimal&gt;** | An array of currency amounts to transfer. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; and/or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order. | 
**References** | **List&lt;decimal&gt;** | An optional array of uint256 numbers to reference each transfer in the batch. Ordering corresponds to the ordering of provided &#x60;addresses&#x60; or &#x60;walletIds&#x60;. If both &#x60;addresses&#x60; and &#x60;walletIds&#x60; are provided, &#x60;addresses&#x60; are first in the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

