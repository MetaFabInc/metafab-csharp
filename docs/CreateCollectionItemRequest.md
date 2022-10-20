
# Org.MetaFab.Model.CreateCollectionItemRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal** | A unique itemId to use for this item within the collection. If an existing itemId is used, the current metadata will be overriden. Any number may be used.  The terms &#x60;itemId&#x60; and &#x60;collectionItemId&#x60; are used interchangeably and equivalent to one another throughout MetaFab documentation. | 
**Name** | **string** | The name of this item. | 
**Description** | **string** | A text description of this item. This is a great spot to include lore, game mechanics and more related to this item. | 
**ImageBase64** | **byte[]** | A base64 string of the image for this item. Either &#x60;imageBase64&#x60; or &#x60;imageUrl&#x60; must be provided. Supported image formats are &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;png&#x60;, &#x60;gif&#x60;. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels. | [optional] 
**ImageUrl** | **string** | An external url that resolves to an image to use for this item. This can also be set to an ipfs:// uri. Recommended size of 1:1 aspect ratio and no more than 1500x1500 pixels. | [optional] 
**ExternalUrl** | **string** | An optional URL where players can go to learn more about this item specifically, or your game, or any other link. | [optional] 
**Attributes** | [**List&lt;CreateCollectionItemRequestAttributesInner&gt;**](CreateCollectionItemRequestAttributesInner.md) | An array of objects that conform with metadata standard. | [optional] 
**Data** | **Object** | An arbitrary object of data attached to the top level metadata object. This is useful for including data or resource URLs specific to your game. Such as URLs that point to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

