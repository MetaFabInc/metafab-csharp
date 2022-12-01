# Org.MetaFab.Api.LootboxesApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateLootboxManager**](LootboxesApi.md#createlootboxmanager) | **POST** /v1/lootboxManagers | Create lootbox manager
[**GetLootboxManagerLootbox**](LootboxesApi.md#getlootboxmanagerlootbox) | **GET** /v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId} | Get lootbox manager lootbox
[**GetLootboxManagerLootboxes**](LootboxesApi.md#getlootboxmanagerlootboxes) | **GET** /v1/lootboxManagers/{lootboxManagerId}/lootboxes | Get lootbox manager lootboxes
[**GetLootboxManagers**](LootboxesApi.md#getlootboxmanagers) | **GET** /v1/lootboxManagers | Get lootbox managers
[**OpenLootboxManagerLootbox**](LootboxesApi.md#openlootboxmanagerlootbox) | **POST** /v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId}/opens | Open lootbox manager lootbox
[**RemoveLootboxManagerLootbox**](LootboxesApi.md#removelootboxmanagerlootbox) | **DELETE** /v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId} | Remove lootbox manager lootbox
[**SetLootboxManagerLootbox**](LootboxesApi.md#setlootboxmanagerlootbox) | **POST** /v1/lootboxManagers/{lootboxManagerId}/lootboxes | Set lootbox manager lootbox



## CreateLootboxManager

> CreateLootboxManager200Response CreateLootboxManager (string xAuthorization, string xPassword, CreateLootboxManagerRequest createLootboxManagerRequest)

Create lootbox manager

Creates a new game lootbox manager and deploys a lootbox manager contract on behalf of the authenticating game's primary wallet. The deployed lootbox manager contract allows you to create lootbox behavior for existing items. For example, you can define item id(s) from one of your item collections as the requirement(s) to open a \"lootbox\". The required item(s) would be burned from the interacting player's wallet and the player would receive item(s) from a weighted randomized set of possible items the lootbox can contain.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateLootboxManagerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new LootboxesApi(Configuration.Default);
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var createLootboxManagerRequest = new CreateLootboxManagerRequest(); // CreateLootboxManagerRequest | 

            try
            {
                // Create lootbox manager
                CreateLootboxManager200Response result = apiInstance.CreateLootboxManager(xAuthorization, xPassword, createLootboxManagerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LootboxesApi.CreateLootboxManager: " + e.Message );
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
 **createLootboxManagerRequest** | [**CreateLootboxManagerRequest**](CreateLootboxManagerRequest.md)|  | 

### Return type

[**CreateLootboxManager200Response**](CreateLootboxManager200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a new lootbox manager and deployed its contract on the chain specified. Returns a lootbox manager object containing a contract property with the deployment transaction. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLootboxManagerLootbox

> LootboxManagerLootbox GetLootboxManagerLootbox (string lootboxManagerId, string lootboxManagerLootboxId)

Get lootbox manager lootbox

Returns a lootbox manager lootbox object for the provided lootboxManagerLootboxId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetLootboxManagerLootboxExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new LootboxesApi(Configuration.Default);
            var lootboxManagerId = "lootboxManagerId_example";  // string | Any lootbox manager id within the MetaFab ecosystem.
            var lootboxManagerLootboxId = "lootboxManagerLootboxId_example";  // string | Any lootbox manager lootbox id within the MetaFab ecosystem.

            try
            {
                // Get lootbox manager lootbox
                LootboxManagerLootbox result = apiInstance.GetLootboxManagerLootbox(lootboxManagerId, lootboxManagerLootboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LootboxesApi.GetLootboxManagerLootbox: " + e.Message );
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
 **lootboxManagerId** | **string**| Any lootbox manager id within the MetaFab ecosystem. | 
 **lootboxManagerLootboxId** | **string**| Any lootbox manager lootbox id within the MetaFab ecosystem. | 

### Return type

[**LootboxManagerLootbox**](LootboxManagerLootbox.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved lootbox manager lootbox. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLootboxManagerLootboxes

> List&lt;LootboxManagerLootbox&gt; GetLootboxManagerLootboxes (string lootboxManagerId)

Get lootbox manager lootboxes

Returns all lootbox manager lootboxes as an array of lootbox objects.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetLootboxManagerLootboxesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new LootboxesApi(Configuration.Default);
            var lootboxManagerId = "lootboxManagerId_example";  // string | Any lootbox manager id within the MetaFab ecosystem.

            try
            {
                // Get lootbox manager lootboxes
                List<LootboxManagerLootbox> result = apiInstance.GetLootboxManagerLootboxes(lootboxManagerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LootboxesApi.GetLootboxManagerLootboxes: " + e.Message );
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
 **lootboxManagerId** | **string**| Any lootbox manager id within the MetaFab ecosystem. | 

### Return type

[**List&lt;LootboxManagerLootbox&gt;**](LootboxManagerLootbox.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved lootbox manager lootboxes. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLootboxManagers

> List&lt;GetLootboxManagers200ResponseInner&gt; GetLootboxManagers (string xGameKey)

Get lootbox managers

Returns an array of active lootbox managers for the game associated with the provided `X-Game-Key`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetLootboxManagersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new LootboxesApi(Configuration.Default);
            var xGameKey = game_pk_4SOqpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific game. This can be shared or included in game clients, websites, etc.

            try
            {
                // Get lootbox managers
                List<GetLootboxManagers200ResponseInner> result = apiInstance.GetLootboxManagers(xGameKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LootboxesApi.GetLootboxManagers: " + e.Message );
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

[**List&lt;GetLootboxManagers200ResponseInner&gt;**](GetLootboxManagers200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved an array of lootbox managers for the game associated with the provided &#x60;X-Game-Key&#x60; |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OpenLootboxManagerLootbox

> List&lt;TransactionModel&gt; OpenLootboxManagerLootbox (string lootboxManagerId, string lootboxManagerLootboxId, string xAuthorization, string xPassword)

Open lootbox manager lootbox

Opens a lootbox manager lootbox. The required input item(s) are burned from the wallet or player wallet opening the lootbox. The given output item(s) are given to the wallet or player wallet opening the lootbox.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class OpenLootboxManagerLootboxExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new LootboxesApi(Configuration.Default);
            var lootboxManagerId = "lootboxManagerId_example";  // string | Any lootbox manager id within the MetaFab ecosystem.
            var lootboxManagerLootboxId = "lootboxManagerLootboxId_example";  // string | Any lootbox manager lootbox id within the MetaFab ecosystem.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.

            try
            {
                // Open lootbox manager lootbox
                List<TransactionModel> result = apiInstance.OpenLootboxManagerLootbox(lootboxManagerId, lootboxManagerLootboxId, xAuthorization, xPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LootboxesApi.OpenLootboxManagerLootbox: " + e.Message );
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
 **lootboxManagerId** | **string**| Any lootbox manager id within the MetaFab ecosystem. | 
 **lootboxManagerLootboxId** | **string**| Any lootbox manager lootbox id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 

### Return type

[**List&lt;TransactionModel&gt;**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully opened provided lootbox manager lootbox. Returns an array of transaction objects. The first transaction object being for the lootbox opening, the second for claiming its contents. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveLootboxManagerLootbox

> TransactionModel RemoveLootboxManagerLootbox (string lootboxManagerId, string lootboxManagerLootboxId, string xAuthorization, string xPassword)

Remove lootbox manager lootbox

Removes the provided lootbox by lootboxId from the provided lootbox manager. Removed lootboxes can no longer be used.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class RemoveLootboxManagerLootboxExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new LootboxesApi(Configuration.Default);
            var lootboxManagerId = "lootboxManagerId_example";  // string | Any lootbox manager id within the MetaFab ecosystem.
            var lootboxManagerLootboxId = "lootboxManagerLootboxId_example";  // string | Any lootbox manager lootbox id within the MetaFab ecosystem.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.

            try
            {
                // Remove lootbox manager lootbox
                TransactionModel result = apiInstance.RemoveLootboxManagerLootbox(lootboxManagerId, lootboxManagerLootboxId, xAuthorization, xPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LootboxesApi.RemoveLootboxManagerLootbox: " + e.Message );
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
 **lootboxManagerId** | **string**| Any lootbox manager id within the MetaFab ecosystem. | 
 **lootboxManagerLootboxId** | **string**| Any lootbox manager lootbox id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 

### Return type

[**TransactionModel**](TransactionModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully removed the provided lootbox from the provided lootbox manager. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetLootboxManagerLootbox

> TransactionModel SetLootboxManagerLootbox (string lootboxManagerId, string xAuthorization, string xPassword, SetLootboxManagerLootboxRequest setLootboxManagerLootboxRequest)

Set lootbox manager lootbox

Sets a new lootbox manager lootbox or updates an existing one for the provided id. Lootboxes allow item(s) to be burned to receive a random set of possible item(s) based on probability weight.  Lootboxes can require any number of unique types of items and quantities to open a created lootbox type within the system. A common pattern with lootboxes is to create a lootbox item type within an item collection, and require it as the input item type.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class SetLootboxManagerLootboxExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new LootboxesApi(Configuration.Default);
            var lootboxManagerId = "lootboxManagerId_example";  // string | Any lootbox manager id within the MetaFab ecosystem.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var setLootboxManagerLootboxRequest = new SetLootboxManagerLootboxRequest(); // SetLootboxManagerLootboxRequest | 

            try
            {
                // Set lootbox manager lootbox
                TransactionModel result = apiInstance.SetLootboxManagerLootbox(lootboxManagerId, xAuthorization, xPassword, setLootboxManagerLootboxRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LootboxesApi.SetLootboxManagerLootbox: " + e.Message );
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
 **lootboxManagerId** | **string**| Any lootbox manager id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **setLootboxManagerLootboxRequest** | [**SetLootboxManagerLootboxRequest**](SetLootboxManagerLootboxRequest.md)|  | 

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
| **200** | Successfully created or updated an lootbox manager lootbox for the provided lootbox id. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

