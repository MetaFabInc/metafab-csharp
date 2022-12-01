
# Org.MetaFab.Model.SetLootboxManagerLootboxRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | A unique lootbox id to use for this lootbox for the lootbox manager. If an existing lootbox id is used, the current lootbox will be updated but the existing number of opens will be kept. If you want to reset the number of opens for an existing lootbox, first remove it using the remove lootbox endpoint, then set it. | 
**InputCollectionAddress** | **string** | A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for input items required by this lootbox. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided. | [optional] 
**InputCollectionId** | **string** | A valid MetaFab collection id that represents the collection for input items required by this lootbox. &#x60;inputCollectionAddress&#x60; or &#x60;inputCollectionId&#x60; can optionally be provided. | [optional] 
**InputCollectionItemIds** | **List&lt;int&gt;** | An array of item ids from the provided input collection that are required to open this lootbox. Input items are burn upon opening a lootbox. | [optional] 
**InputCollectionItemAmounts** | **List&lt;int&gt;** | An array of amounts for each item id from the provided input collection that are required to open this lootbox. Item amounts array indices are reflective of the amount required for a given item id at the same index. | [optional] 
**OutputCollectionAddress** | **string** | A valid EVM based ERC1155 or MetaFab game items contract address that represents the collection for possible output items given by this lootbox. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided. | [optional] 
**OutputCollectionId** | **string** | A valid MetaFab collection id that represents the collection for possible output items given by this lootbox. &#x60;outputCollectionAddress&#x60; or &#x60;outputCollectionId&#x60; can optionally be provided. | [optional] 
**OutputCollectionItemIds** | **List&lt;int&gt;** | An array of item ids from the provided output collection that are possibly given by this lootbox. Randomly selected output items are automatically minted if the lootbox manager contract has the &#x60;minter&#x60; role for the output collection contract. Otherwise, they are transferred from the item balance held by the lootbox manager contract. | [optional] 
**OutputCollectionItemAmounts** | **List&lt;int&gt;** | An array of amounts for each item id that can be randomly selected from the provided output collection that are given by this lootbox. Item amounts array indices are reflective of the amount required for a given item id at the same index. | [optional] 
**OutputCollectionItemWeights** | **List&lt;int&gt;** | An array of weights for each item id that can be randomly selected from the provided output collection that are given by this lootbox. Any positive integer for an item&#39;s weight can be provided. The weight for an item relative to the sum of all possible item weights determines the probability that an item will be picked upon a lootbox being opened. Item weights array indices are reflective of the probability weight for a given item id at the same index. | [optional] 
**OutputTotalItems** | **int** | The number of items randomly selected from the possible output items when this lootbox is open. If you provide a value greater than 1, it is possible for the same item to be selected more than once, giving the opener more than one of that item&#39;s output from the lootbox. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

