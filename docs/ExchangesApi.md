# Org.MetaFab.Api.ExchangesApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateExchange**](ExchangesApi.md#createexchange) | **POST** /v1/exchanges | Create exchange
[**GetExchangeOffer**](ExchangesApi.md#getexchangeoffer) | **GET** /v1/exchanges/{exchangeId}/items/{exchangeOfferId} | Get exchange offer
[**GetExchangeOffers**](ExchangesApi.md#getexchangeoffers) | **GET** /v1/exchanges/{exchangeId}/offers | Get exchange offers
[**GetExchanges**](ExchangesApi.md#getexchanges) | **GET** /v1/exchanges | Get exchanges
[**RemoveExchangeOffer**](ExchangesApi.md#removeexchangeoffer) | **DELETE** /v1/exchanges/{exchangeId}/offers/{exchangeOfferId} | Remove exchange offer
[**SetExchangeOffer**](ExchangesApi.md#setexchangeoffer) | **POST** /v1/exchanges/{exchangeId}/offers | Set exchange offer
[**UseExchangeOffer**](ExchangesApi.md#useexchangeoffer) | **POST** /v1/exchanges/{exchangeId}/offers/{exchangeOfferId}/uses | Use exchange offer
[**WithdrawFromExchange**](ExchangesApi.md#withdrawfromexchange) | **POST** /v1/exchanges/{exchangeId}/withdrawals | Withdraw from exchange



## CreateExchange

> CreateExchange200Response CreateExchange (string xAuthorization, string xPassword, CreateExchangeRequest createExchangeRequest)

Create exchange

Creates a new game exchange and deploys a exchange contract on behalf of the authenticating game's primary wallet. The deployed exchange contract allows you to create fixed price rates for players to buy specific items from any item collection or ERC1155 contract. Additionally, an exchange allows you to create exchange offers for some set of item(s) to another set of item(s) or any mix of currency. Exchanges completely supports gasless player transactions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateExchangeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var createExchangeRequest = new CreateExchangeRequest(); // CreateExchangeRequest | 

            try
            {
                // Create exchange
                CreateExchange200Response result = apiInstance.CreateExchange(xAuthorization, xPassword, createExchangeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.CreateExchange: " + e.Message );
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
 **createExchangeRequest** | [**CreateExchangeRequest**](CreateExchangeRequest.md)|  | 

### Return type

[**CreateExchange200Response**](CreateExchange200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a new exchange and deployed its contract on the chain specified. Returns a exchange object containing a contract property with the deployment transaction. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetExchangeOffer

> ExchangeOffer GetExchangeOffer (string exchangeId, string exchangeOfferId)

Get exchange offer

Returns a exchange offer object for the provided exchangeOfferId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetExchangeOfferExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var exchangeId = "exchangeId_example";  // string | Any exchange id within the MetaFab ecosystem.
            var exchangeOfferId = "exchangeOfferId_example";  // string | Any offer id for the exchange. Zero, or a positive integer.

            try
            {
                // Get exchange offer
                ExchangeOffer result = apiInstance.GetExchangeOffer(exchangeId, exchangeOfferId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.GetExchangeOffer: " + e.Message );
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
 **exchangeId** | **string**| Any exchange id within the MetaFab ecosystem. | 
 **exchangeOfferId** | **string**| Any offer id for the exchange. Zero, or a positive integer. | 

### Return type

[**ExchangeOffer**](ExchangeOffer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved exchange offer. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetExchangeOffers

> List&lt;ExchangeOffer&gt; GetExchangeOffers (string exchangeId)

Get exchange offers

Returns all exchange offers as an array of exchange offer objects.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetExchangeOffersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var exchangeId = "exchangeId_example";  // string | Any exchange id within the MetaFab ecosystem.

            try
            {
                // Get exchange offers
                List<ExchangeOffer> result = apiInstance.GetExchangeOffers(exchangeId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.GetExchangeOffers: " + e.Message );
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
 **exchangeId** | **string**| Any exchange id within the MetaFab ecosystem. | 

### Return type

[**List&lt;ExchangeOffer&gt;**](ExchangeOffer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved exchange offers. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetExchanges

> List&lt;GetExchanges200ResponseInner&gt; GetExchanges (string xGameKey)

Get exchanges

Returns an array of active exchanges for the game associated with the provided `X-Game-Key`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetExchangesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var xGameKey = game_pk_4SOqpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific game. This can be shared or included in game clients, websites, etc.

            try
            {
                // Get exchanges
                List<GetExchanges200ResponseInner> result = apiInstance.GetExchanges(xGameKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.GetExchanges: " + e.Message );
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

[**List&lt;GetExchanges200ResponseInner&gt;**](GetExchanges200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved an array of exchanges for the game associated with the provided &#x60;X-Game-Key&#x60; |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveExchangeOffer

> TransactionModel RemoveExchangeOffer (string exchangeId, string exchangeOfferId, string xAuthorization, string xPassword)

Remove exchange offer

Removes the provided offerId from the provided exchange. Removed offers can no longer be used.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class RemoveExchangeOfferExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var exchangeId = "exchangeId_example";  // string | Any exchange id within the MetaFab ecosystem.
            var exchangeOfferId = "exchangeOfferId_example";  // string | Any offer id for the exchange. Zero, or a positive integer.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.

            try
            {
                // Remove exchange offer
                TransactionModel result = apiInstance.RemoveExchangeOffer(exchangeId, exchangeOfferId, xAuthorization, xPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.RemoveExchangeOffer: " + e.Message );
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
 **exchangeId** | **string**| Any exchange id within the MetaFab ecosystem. | 
 **exchangeOfferId** | **string**| Any offer id for the exchange. Zero, or a positive integer. | 
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
| **200** | Successfully removed the provided offer from the provided exchange. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetExchangeOffer

> TransactionModel SetExchangeOffer (string exchangeId, string xAuthorization, string xPassword, SetExchangeOfferRequest setExchangeOfferRequest)

Set exchange offer

Sets a new exchange offer or updates an existing one for the provided id. Exchange offers allow currency to item, item to currency or item to item exchanges.  All request fields besides `id` are optional. Any optional fields omitted will not be used for the offer. This allows you to create many different combinations of offers. For example, you can create an offer that may require 3 unique item ids of specified quantities from a given item collection and gives the user 1 new unique item id in exchange.  Another example, you may want to make an exchange offer from one ERC20 token to another. This is also possible - simple set the input and output currency fields and leave the others blank.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class SetExchangeOfferExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var exchangeId = "exchangeId_example";  // string | Any exchange id within the MetaFab ecosystem.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var setExchangeOfferRequest = new SetExchangeOfferRequest(); // SetExchangeOfferRequest | 

            try
            {
                // Set exchange offer
                TransactionModel result = apiInstance.SetExchangeOffer(exchangeId, xAuthorization, xPassword, setExchangeOfferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.SetExchangeOffer: " + e.Message );
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
 **exchangeId** | **string**| Any exchange id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **setExchangeOfferRequest** | [**SetExchangeOfferRequest**](SetExchangeOfferRequest.md)|  | 

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
| **200** | Successfully created or updated an exchange offer for the provided offer id. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UseExchangeOffer

> TransactionModel UseExchangeOffer (string exchangeId, string exchangeOfferId, string xAuthorization, string xPassword)

Use exchange offer

Uses an exchange offer. The required (input) item(s) and/or currency are removed from the wallet or player wallet using the offer. The given (output) item(s) and/or currency are given to the wallet or player wallet using the offer.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class UseExchangeOfferExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var exchangeId = "exchangeId_example";  // string | Any exchange id within the MetaFab ecosystem.
            var exchangeOfferId = "exchangeOfferId_example";  // string | Any offer id for the exchange. Zero, or a positive integer.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.

            try
            {
                // Use exchange offer
                TransactionModel result = apiInstance.UseExchangeOffer(exchangeId, exchangeOfferId, xAuthorization, xPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.UseExchangeOffer: " + e.Message );
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
 **exchangeId** | **string**| Any exchange id within the MetaFab ecosystem. | 
 **exchangeOfferId** | **string**| Any offer id for the exchange. Zero, or a positive integer. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 

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
| **200** | Successfully used provided exchange offer. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WithdrawFromExchange

> TransactionModel WithdrawFromExchange (string exchangeId, string xAuthorization, string xPassword, WithdrawFromExchangeRequest withdrawFromExchangeRequest)

Withdraw from exchange

Withdraws native token, currency or items from a exchange. Whenever an exchange offer has input requirements, the native tokens, currencies or items for the requirements of that offer are deposited into the exchange contract when the offer is used. These can be withdrawn to any other address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class WithdrawFromExchangeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ExchangesApi(Configuration.Default);
            var exchangeId = "exchangeId_example";  // string | Any exchange id within the MetaFab ecosystem.
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet.
            var withdrawFromExchangeRequest = new WithdrawFromExchangeRequest(); // WithdrawFromExchangeRequest | 

            try
            {
                // Withdraw from exchange
                TransactionModel result = apiInstance.WithdrawFromExchange(exchangeId, xAuthorization, xPassword, withdrawFromExchangeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExchangesApi.WithdrawFromExchange: " + e.Message );
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
 **exchangeId** | **string**| Any exchange id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **xPassword** | **string**| The password of the authenticating game. Required to decrypt and perform blockchain transactions with the game primary wallet. | 
 **withdrawFromExchangeRequest** | [**WithdrawFromExchangeRequest**](WithdrawFromExchangeRequest.md)|  | 

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
| **200** | Successfully performed a withdrawal to the provided wallet address or wallet address of the provided walletId. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

