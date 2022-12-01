
# Org.MetaFab.Model.LootboxManagerLootbox

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of this lootbox. | [optional] 
**InputCollection** | **string** | The address of the ERC1155 or MetaFab game items contract for input items required by this lootbox. | [optional] 
**InputCollectionItemIds** | **List&lt;int&gt;** | An array of item ids from the input collection that are required for this lootbox. | [optional] 
**InputCollectionItemAmounts** | **List&lt;int&gt;** | An array of amounts for each item id for the input collection that are required to open this lootbox. | [optional] 
**OutputCollection** | **string** | The address of the ERC1155 of MetaFab game items contract for possible output items given by this lootbox. | [optional] 
**OutputCollectionItemIds** | **List&lt;int&gt;** | An array of item ids from the output collection that are possibly given by this lootbox. | [optional] 
**OutputCollectionItemAmounts** | **List&lt;int&gt;** | An array of amounts for each item id for the output collection that are possibly given by this lootbox. | [optional] 
**OutputCollectionItemWeights** | **List&lt;int&gt;** | An array of weights for each item id for the output collection that are possibly given by this lootbox. | [optional] 
**OutputTotalItems** | **int** | The number of items randomly selected when this lootbox is opened. | [optional] 
**LastUpdatedAt** | **int** | A unix timestamp in seconds that represents the last time this offer was set or updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

