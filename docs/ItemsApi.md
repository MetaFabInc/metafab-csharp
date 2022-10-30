# Org.MetaFab.Api.ItemsApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchMintCollectionItems**](ItemsApi.md#batchmintcollectionitems) | **POST** /v1/collections/{collectionId}/batchMints | Batch mint collection items
[**BatchTransferCollectionItems**](ItemsApi.md#batchtransfercollectionitems) | **POST** /v1/collections/{collectionId}/batchTransfers | Batch transfer collection items
[**BurnCollectionItem**](ItemsApi.md#burncollectionitem) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/burns | Burn collection item
[**CreateCollection**](ItemsApi.md#createcollection) | **POST** /v1/collections | Create collection
[**CreateCollectionItem**](ItemsApi.md#createcollectionitem) | **POST** /v1/collections/{collectionId}/items | Create collection item
[**GetCollectionApproval**](ItemsApi.md#getcollectionapproval) | **GET** /v1/collections/{collectionId}/approvals | Get collection approval
[**GetCollectionItem**](ItemsApi.md#getcollectionitem) | **GET** /v1/collections/{collectionId}/items/{collectionItemId} | Get collection item
[**GetCollectionItemBalance**](ItemsApi.md#getcollectionitembalance) | **GET** /v1/collections/{collectionId}/items/{collectionItemId}/balances | Get collection item balance
[**GetCollectionItemBalances**](ItemsApi.md#getcollectionitembalances) | **GET** /v1/collections/{collectionId}/balances | Get collection item balances
[**GetCollectionItemSupplies**](ItemsApi.md#getcollectionitemsupplies) | **GET** /v1/collections/{collectionId}/supplies | Get collection item supplies
[**GetCollectionItemSupply**](ItemsApi.md#getcollectionitemsupply) | **GET** /v1/collections/{collectionId}/items/{collectionItemId}/supplies | Get collection item supply
[**GetCollectionItemTimelock**](ItemsApi.md#getcollectionitemtimelock) | **GET** /v1/collections/{collectionId}/items/{collectionItemId}/timelocks | Get collection item timelock
[**GetCollectionItems**](ItemsApi.md#getcollectionitems) | **GET** /v1/collections/{collectionId}/items | Get collection items
[**GetCollectionRole**](ItemsApi.md#getcollectionrole) | **GET** /v1/collections/{collectionId}/roles | Get collection role
[**GetCollections**](ItemsApi.md#getcollections) | **GET** /v1/collections | Get collections
[**GrantCollectionRole**](ItemsApi.md#grantcollectionrole) | **POST** /v1/collections/{collectionId}/roles | Grant collection role
[**MintCollectionItem**](ItemsApi.md#mintcollectionitem) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/mints | Mint collection item
[**RevokeCollectionRole**](ItemsApi.md#revokecollectionrole) | **DELETE** /v1/collections/{collectionId}/roles | Revoke collection role
[**SetCollectionApproval**](ItemsApi.md#setcollectionapproval) | **POST** /v1/collections/{collectionId}/approvals | Set collection approval
[**SetCollectionItemTimelock**](ItemsApi.md#setcollectionitemtimelock) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/timelocks | Set collection item timelock
[**TransferCollectionItem**](ItemsApi.md#transfercollectionitem) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/transfers | Transfer collection item



## BatchMintCollectionItems

> TransactionModel BatchMintCollectionItems (string collectionId, string xAuthorization, string xPassword, BatchMintCollectionItemsRequest batchMintCollectionItemsRequest)

Batch mint collection items

Creates (mints) the provided itemIds of the specified quantities to the provided wallet address or wallet address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class BatchMintCollectionItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var batchMintCollectionItemsRequest = new BatchMintCollectionItemsRequest(); // BatchMintCollectionItemsRequest | 

            try
            {
                // Batch mint collection items
                TransactionModel result = apiInstance.BatchMintCollectionItems(collectionId, xAuthorization, xPassword, batchMintCollectionItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.BatchMintCollectionItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **batchMintCollectionItemsRequest** | [**BatchMintCollectionItemsRequest**](BatchMintCollectionItemsRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created (minted) the provided items of the provided quantities to the provided wallet address or wallet address of the provided walletId. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BatchTransferCollectionItems

> TransactionModel BatchTransferCollectionItems (string collectionId, string xAuthorization, string xPassword, BatchTransferCollectionItemsRequest batchTransferCollectionItemsRequest)

Batch transfer collection items

Transfers one or multiple items of specified quantities to the provided wallet addresses or wallet addresses associated with the provided walletIds. You may also provide a combination of addresses and walletIds in one request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class BatchTransferCollectionItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.
            var batchTransferCollectionItemsRequest = new BatchTransferCollectionItemsRequest(); // BatchTransferCollectionItemsRequest | 

            try
            {
                // Batch transfer collection items
                TransactionModel result = apiInstance.BatchTransferCollectionItems(collectionId, xAuthorization, xPassword, batchTransferCollectionItemsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.BatchTransferCollectionItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 
 **batchTransferCollectionItemsRequest** | [**BatchTransferCollectionItemsRequest**](BatchTransferCollectionItemsRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully transferred the itemIds of the provided quantities to each of the provided wallet addresses and/or wallet addresses of the provided walletIds. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BurnCollectionItem

> TransactionModel BurnCollectionItem (string collectionId, decimal collectionItemId, string xAuthorization, string xPassword, BurnCollectionItemRequest burnCollectionItemRequest)

Burn collection item

Removes (burns) the provided quantity of the collectionItemId from the authenticating game or players wallet. The quantity is permanently removed from the circulating supply of the item.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class BurnCollectionItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.
            var burnCollectionItemRequest = new BurnCollectionItemRequest(); // BurnCollectionItemRequest | 

            try
            {
                // Burn collection item
                TransactionModel result = apiInstance.BurnCollectionItem(collectionId, collectionItemId, xAuthorization, xPassword, burnCollectionItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.BurnCollectionItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 
 **burnCollectionItemRequest** | [**BurnCollectionItemRequest**](BurnCollectionItemRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully removed (burned) the quantity of the collectionItemId from the authenticating game or player&#39;s wallet. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateCollection

> CreateCollection200Response CreateCollection (string xAuthorization, string xPassword, CreateCollectionRequest createCollectionRequest)

Create collection

Creates a new game item collection and deploys an extended functionality ERC1155 contract on behalf of the authenticating game's primary wallet. The deployed ERC1155 contract is preconfigured to fully support creating unique item types, item transfer timelocks, custom metadata per item, gasless transactions from player managed wallets, and much more.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var createCollectionRequest = new CreateCollectionRequest(); // CreateCollectionRequest | 

            try
            {
                // Create collection
                CreateCollection200Response result = apiInstance.CreateCollection(xAuthorization, xPassword, createCollectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.CreateCollection: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **createCollectionRequest** | [**CreateCollectionRequest**](CreateCollectionRequest.md)|  | 

### Return type

[**CreateCollection200Response**](CreateCollection200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a new item collection and deployed its associated ERC1155 contract on the chain specified. Returns a collection object containing a contract property with the deployment transaction. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateCollectionItem

> TransactionModel CreateCollectionItem (string collectionId, string xAuthorization, string xPassword, CreateCollectionItemRequest createCollectionItemRequest)

Create collection item

Creates a new item type. Item type creation associates all of the relevant item data to a specific itemId. Such as item name, image, description, attributes, any arbitrary data such as 2D or 3D model resolver URLs, and more. It is recommended, but not required, that you create a new item type through this endpoint before minting any quantity of the related itemId.  Any itemId provided will have its existing item type overriden if it already exists.  Item type data is uploaded to, and resolved through IPFS for decentralized persistence.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateCollectionItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var createCollectionItemRequest = new CreateCollectionItemRequest(); // CreateCollectionItemRequest | 

            try
            {
                // Create collection item
                TransactionModel result = apiInstance.CreateCollectionItem(collectionId, xAuthorization, xPassword, createCollectionItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.CreateCollectionItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **createCollectionItemRequest** | [**CreateCollectionItemRequest**](CreateCollectionItemRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a new item type and assigned it to the provided item &#x60;id&#x60;. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionApproval

> bool GetCollectionApproval (string collectionId, string operatorAddress, string address = null, string walletId = null)

Get collection approval

Returns a boolean (true/false) representing if the provided operatorAddress has approval to transfer and burn items from the current collection owned by the address or address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionApprovalExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var operatorAddress = 0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D;  // string | A valid EVM based address. For example, `0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D`.
            var address = 0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D;  // string | A valid EVM based address. For example, `0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D`. (optional) 
            var walletId = "walletId_example";  // string | Any wallet id within the MetaFab ecosystem. (optional) 

            try
            {
                // Get collection approval
                bool result = apiInstance.GetCollectionApproval(collectionId, operatorAddress, address, walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionApproval: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **operatorAddress** | **string**| A valid EVM based address. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;. | 
 **address** | **string**| A valid EVM based address. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;. | [optional] 
 **walletId** | **string**| Any wallet id within the MetaFab ecosystem. | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the boolean value representing if the provided operatorAddress can transfer and burn owned items by the provided address or walletId. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionItem

> List&lt;Object&gt; GetCollectionItem (string collectionId, decimal collectionItemId)

Get collection item

Returns a metadata object for the provided collectionItemId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.

            try
            {
                // Get collection item
                List<Object> result = apiInstance.GetCollectionItem(collectionId, collectionItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved collection item metadata. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionItemBalance

> decimal GetCollectionItemBalance (string collectionId, decimal collectionItemId, string address = null, string walletId = null)

Get collection item balance

Returns the current collection item balance of the provided collectionItemId for the provided wallet address or the wallet address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionItemBalanceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.
            var address = 0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D;  // string | A valid EVM based address. For example, `0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D`. (optional) 
            var walletId = "walletId_example";  // string | Any wallet id within the MetaFab ecosystem. (optional) 

            try
            {
                // Get collection item balance
                decimal result = apiInstance.GetCollectionItemBalance(collectionId, collectionItemId, address, walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionItemBalance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 
 **address** | **string**| A valid EVM based address. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;. | [optional] 
 **walletId** | **string**| Any wallet id within the MetaFab ecosystem. | [optional] 

### Return type

**decimal**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved collection item balance of the provided collectionItemId for address or walletId. Balance is returned as a string to handle uint256 numbers. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionItemBalances

> Dictionary&lt;string, decimal&gt; GetCollectionItemBalances (string collectionId, string address = null, string walletId = null)

Get collection item balances

Returns the current collection item balances of all collection items for the provided wallet address or the wallet address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionItemBalancesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var address = 0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D;  // string | A valid EVM based address. For example, `0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D`. (optional) 
            var walletId = "walletId_example";  // string | Any wallet id within the MetaFab ecosystem. (optional) 

            try
            {
                // Get collection item balances
                Dictionary<string, decimal> result = apiInstance.GetCollectionItemBalances(collectionId, address, walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionItemBalances: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **address** | **string**| A valid EVM based address. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;. | [optional] 
 **walletId** | **string**| Any wallet id within the MetaFab ecosystem. | [optional] 

### Return type

**Dictionary<string, decimal>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved currency balances of all collection items owned by the provided address or walletId. Balances are returned as a an object, mapping key value pairs as itemId -&gt; balance (string to handle uint256 numbers). |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionItemSupplies

> Dictionary&lt;string, decimal&gt; GetCollectionItemSupplies (string collectionId)

Get collection item supplies

Returns the currency circulating supply of all collection items.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionItemSuppliesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.

            try
            {
                // Get collection item supplies
                Dictionary<string, decimal> result = apiInstance.GetCollectionItemSupplies(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionItemSupplies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 

### Return type

**Dictionary<string, decimal>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the circulating supply of all collection items. Supplies are returned as a an object, mapping key value pairs as itemId -&gt; balance (string to handle uint256 numbers). |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionItemSupply

> decimal GetCollectionItemSupply (string collectionId, decimal collectionItemId, string address = null, string walletId = null)

Get collection item supply

Returns the current circulating supply of the provided collectionItemId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionItemSupplyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.
            var address = 0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D;  // string | A valid EVM based address. For example, `0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D`. (optional) 
            var walletId = "walletId_example";  // string | Any wallet id within the MetaFab ecosystem. (optional) 

            try
            {
                // Get collection item supply
                decimal result = apiInstance.GetCollectionItemSupply(collectionId, collectionItemId, address, walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionItemSupply: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 
 **address** | **string**| A valid EVM based address. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;. | [optional] 
 **walletId** | **string**| Any wallet id within the MetaFab ecosystem. | [optional] 

### Return type

**decimal**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved collection item supply. Supply is returned as a string to handle uint256 numbers. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionItemTimelock

> decimal GetCollectionItemTimelock (string collectionId, decimal collectionItemId)

Get collection item timelock

Returns a timestamp (in seconds) for when the provided collectionItemId's transfer timelock expires. A value of 0 means the provided collectionItemId does not have a timelock set. Timelocks prevent items of a specific collectionItemId from being transferred until the set timelock timestamp has been surpassed.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionItemTimelockExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.

            try
            {
                // Get collection item timelock
                decimal result = apiInstance.GetCollectionItemTimelock(collectionId, collectionItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionItemTimelock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 

### Return type

**decimal**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the collectionItemId&#39;s timelock. The timelock is returned as a unix timestamp in seconds. A return value of 0 means the collectionItemId does not have a timelock set. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionItems

> List&lt;Object&gt; GetCollectionItems (string collectionId)

Get collection items

Returns all collection items as an array of metadata objects.  Please note that ONLY items that have had at least 1 quantity minted will be returned. If you've created an item that has not been minted yet, it will not be returned in the array response.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.

            try
            {
                // Get collection items
                List<Object> result = apiInstance.GetCollectionItems(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionItems: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved collection items metadata. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollectionRole

> bool GetCollectionRole (string collectionId, string role, string address = null, string walletId = null)

Get collection role

Returns a boolean (true/false) representing if the provided role for this collection has been granted to the provided address or address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var role = minter;  // string | A valid MetaFab role or bytes string representing a role, such as `0xc9eb32e43bf5ecbceacf00b32281dfc5d6d700a0db676ea26ccf938a385ac3b7`
            var address = 0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D;  // string | A valid EVM based address. For example, `0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D`. (optional) 
            var walletId = "walletId_example";  // string | Any wallet id within the MetaFab ecosystem. (optional) 

            try
            {
                // Get collection role
                bool result = apiInstance.GetCollectionRole(collectionId, role, address, walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollectionRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **role** | **string**| A valid MetaFab role or bytes string representing a role, such as &#x60;0xc9eb32e43bf5ecbceacf00b32281dfc5d6d700a0db676ea26ccf938a385ac3b7&#x60; | 
 **address** | **string**| A valid EVM based address. For example, &#x60;0x39cb70F972E0EE920088AeF97Dbe5c6251a9c25D&#x60;. | [optional] 
 **walletId** | **string**| Any wallet id within the MetaFab ecosystem. | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the boolean value representing if the provided role has been granted to the provided address or walletId. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCollections

> List&lt;GetCollections200ResponseInner&gt; GetCollections (string xGameKey)

Get collections

Returns an array of active item collections for the game associated with the provided `X-Game-Key`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetCollectionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var xGameKey = game_pk_4SOqpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific game. This can be shared or included in game clients, websites, etc.

            try
            {
                // Get collections
                List<GetCollections200ResponseInner> result = apiInstance.GetCollections(xGameKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GetCollections: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xGameKey** | **string**| The &#x60;publishedKey&#x60; of a specific game. This can be shared or included in game clients, websites, etc. | 

### Return type

[**List&lt;GetCollections200ResponseInner&gt;**](GetCollections200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved an array of item collections for the game associated with the provided &#x60;X-Game-Key&#x60; |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GrantCollectionRole

> TransactionModel GrantCollectionRole (string collectionId, string xAuthorization, string xPassword, GrantCollectionRoleRequest grantCollectionRoleRequest)

Grant collection role

Grants the provided role for the collection to the provided address or address associated with the provided walletId. Granted roles give different types of authority on behalf of the collection for specific players, addresses, or contracts to perform different types of permissioned collection operations.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GrantCollectionRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.
            var grantCollectionRoleRequest = new GrantCollectionRoleRequest(); // GrantCollectionRoleRequest | 

            try
            {
                // Grant collection role
                TransactionModel result = apiInstance.GrantCollectionRole(collectionId, xAuthorization, xPassword, grantCollectionRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.GrantCollectionRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 
 **grantCollectionRoleRequest** | [**GrantCollectionRoleRequest**](GrantCollectionRoleRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully granted the provided role to the provided address or address associated with the provided walletId. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MintCollectionItem

> TransactionModel MintCollectionItem (string collectionId, decimal collectionItemId, string xAuthorization, string xPassword, MintCollectionItemRequest mintCollectionItemRequest)

Mint collection item

Creates (mints) the specified quantity of the provided collectionItemId to the provided wallet address or wallet address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class MintCollectionItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var mintCollectionItemRequest = new MintCollectionItemRequest(); // MintCollectionItemRequest | 

            try
            {
                // Mint collection item
                TransactionModel result = apiInstance.MintCollectionItem(collectionId, collectionItemId, xAuthorization, xPassword, mintCollectionItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.MintCollectionItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **mintCollectionItemRequest** | [**MintCollectionItemRequest**](MintCollectionItemRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created (minted) the item(s) to the provided wallet address or wallet address of the provided walletId. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RevokeCollectionRole

> TransactionModel RevokeCollectionRole (string collectionId, string xAuthorization, string xPassword, RevokeCollectionRoleRequest revokeCollectionRoleRequest)

Revoke collection role

Revokes the provided role for the collection to the provided address or address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class RevokeCollectionRoleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.
            var revokeCollectionRoleRequest = new RevokeCollectionRoleRequest(); // RevokeCollectionRoleRequest | 

            try
            {
                // Revoke collection role
                TransactionModel result = apiInstance.RevokeCollectionRole(collectionId, xAuthorization, xPassword, revokeCollectionRoleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.RevokeCollectionRole: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 
 **revokeCollectionRoleRequest** | [**RevokeCollectionRoleRequest**](RevokeCollectionRoleRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully revoked the provided role from the provided address or address associated with the provided walletId. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetCollectionApproval

> TransactionModel SetCollectionApproval (string collectionId, string xAuthorization, string xPassword, SetCollectionApprovalRequest setCollectionApprovalRequest)

Set collection approval

Sets approval for the provided address or wallet address associated with the provided walletId to operate on behalf of the authenticating game or player's owned items for this collection. Setting an approved value of `true` allows the provided address or address associated with the provided walletId to transfer and burn items from this collection on behalf of the authenticated game or player's wallet address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class SetCollectionApprovalExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.
            var setCollectionApprovalRequest = new SetCollectionApprovalRequest(); // SetCollectionApprovalRequest | 

            try
            {
                // Set collection approval
                TransactionModel result = apiInstance.SetCollectionApproval(collectionId, xAuthorization, xPassword, setCollectionApprovalRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.SetCollectionApproval: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 
 **setCollectionApprovalRequest** | [**SetCollectionApprovalRequest**](SetCollectionApprovalRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully set approval for the provided address or address associated with the provided walletId to transfer and burn items from this collection on behalf of the authenticated game or player&#39;s wallet. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetCollectionItemTimelock

> TransactionModel SetCollectionItemTimelock (string collectionId, decimal collectionItemId, string xAuthorization, string xPassword, SetCollectionItemTimelockRequest setCollectionItemTimelockRequest)

Set collection item timelock

Sets the item timelock for the provided collection itemId. The timelock is a unix timestamp (in seconds) that defines a period in time of when an item may be transferred by players. Until the timelock timestamp has passed, the itemId for the given timelock may not be transferred, sold, traded, etc. A timelock of 0 (default) means that there is no timelock set on the itemId and it can be freely transferred, traded, etc.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class SetCollectionItemTimelockExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var setCollectionItemTimelockRequest = new SetCollectionItemTimelockRequest(); // SetCollectionItemTimelockRequest | 

            try
            {
                // Set collection item timelock
                TransactionModel result = apiInstance.SetCollectionItemTimelock(collectionId, collectionItemId, xAuthorization, xPassword, setCollectionItemTimelockRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.SetCollectionItemTimelock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **setCollectionItemTimelockRequest** | [**SetCollectionItemTimelockRequest**](SetCollectionItemTimelockRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully set the provided timelock for the provided itemId. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TransferCollectionItem

> TransactionModel TransferCollectionItem (string collectionId, decimal collectionItemId, string xAuthorization, string xPassword, TransferCollectionItemRequest transferCollectionItemRequest)

Transfer collection item

Transfers specified quantity of itemId to the provided wallet address or wallet address associated with the provided walletId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class TransferCollectionItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ItemsApi(Configuration.Default);
            var collectionId = "collectionId_example";  // string | Any collection id within the MetaFab ecosystem.
            var collectionItemId = 8.14D;  // decimal | Any item id for the collection. Zero, or a positive integer.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.
            var transferCollectionItemRequest = new TransferCollectionItemRequest(); // TransferCollectionItemRequest | 

            try
            {
                // Transfer collection item
                TransactionModel result = apiInstance.TransferCollectionItem(collectionId, collectionItemId, xAuthorization, xPassword, transferCollectionItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ItemsApi.TransferCollectionItem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| Any collection id within the MetaFab ecosystem. | 
 **collectionItemId** | **decimal**| Any item id for the collection. Zero, or a positive integer. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 
 **transferCollectionItemRequest** | [**TransferCollectionItemRequest**](TransferCollectionItemRequest.md)|  | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully transferred the provided quantity of the collectionItemId to the provided wallet address or wallet address of the provided walletId. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

