
# Org.MetaFab.Model.ShopOffer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of this offer. | [optional] 
**InputCollection** | **string** | The address of the ERC1155 or MetaFab game items contract for input items required by this offer. | [optional] 
**InputCollectionItemIds** | **List&lt;int&gt;** | An array of item ids from the input collection that are required for this offer. | [optional] 
**InputCollectionItemAmounts** | **List&lt;int&gt;** | An array of amounts for each item id for the input collection that are required to use this offer. | [optional] 
**InputCurrency** | **string** | The address of the ERC20 or MetaFab game currency for the currency required by this offer. | [optional] 
**InputCurrencyAmount** | **decimal** | The amount of currency required by this offer. | [optional] 
**OutputCollection** | **string** | The address of the ERC1155 or MetaFab game items contract for output items given by this offer. | [optional] 
**OutputCollectionItemIds** | **List&lt;int&gt;** | An array of item ids from the output collection that are given for this offer. | [optional] 
**OutputCollectionItemAmounts** | **List&lt;int&gt;** | An array of amounts for each item id for the output collection that are given by this offer. | [optional] 
**OutputCurrency** | **string** | The address of the ERC20 or MetaFab game currency for the output currency given by this offer. | [optional] 
**OutputCurrencyAmount** | **decimal** | The amount of currency given by this offer. | [optional] 
**Uses** | **int** | The number of times this offer has been used. | [optional] 
**MaxUses** | **int** | The maximum number of times this offer can be used. A value of &#x60;0&#x60; means there is no limit on how many times this offer can be used. | [optional] 
**LastUpdatedAt** | **int** | A unix timestamp in seconds that represents the last time this offer was set or updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

