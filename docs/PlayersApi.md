# Org.MetaFab.Api.PlayersApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthPlayer**](PlayersApi.md#authplayer) | **GET** /v1/players | Authenticate player
[**CreatePlayer**](PlayersApi.md#createplayer) | **POST** /v1/players | Create player
[**UpdatePlayer**](PlayersApi.md#updateplayer) | **PATCH** /v1/players/{playerId} | Update player



## AuthPlayer

> AuthPlayer200Response AuthPlayer (string xGameKey)

Authenticate player

Returns an existing player object containing access token, wallet, and other details for a game when provided a valid username and password login using Basic Auth.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class AuthPlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new PlayersApi(Configuration.Default);
            var xGameKey = game_pk_4SOqpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific game. This can be shared or included in game clients, websites, etc.

            try
            {
                // Authenticate player
                AuthPlayer200Response result = apiInstance.AuthPlayer(xGameKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayersApi.AuthPlayer: " + e.Message );
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

[**AuthPlayer200Response**](AuthPlayer200Response.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Succesfully authorized the request and retrieved a player object containing access token, wallet, and other details. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreatePlayer

> AuthPlayer200Response CreatePlayer (string xGameKey, CreatePlayerRequest createPlayerRequest)

Create player

Create a new player for a game. Players are automatically associated with an internally managed wallet.  Player access tokens can be used to directly interact with any MetaFab managed contracts, currencies, items collections, marketplaces and more. Player interactions are also gasless by default, completely removing all crypto friction for players to engage with your MetaFab supported games.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreatePlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new PlayersApi(Configuration.Default);
            var xGameKey = game_pk_4SOqpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific game. This can be shared or included in game clients, websites, etc.
            var createPlayerRequest = new CreatePlayerRequest(); // CreatePlayerRequest | 

            try
            {
                // Create player
                AuthPlayer200Response result = apiInstance.CreatePlayer(xGameKey, createPlayerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayersApi.CreatePlayer: " + e.Message );
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
 **createPlayerRequest** | [**CreatePlayerRequest**](CreatePlayerRequest.md)|  | 

### Return type

[**AuthPlayer200Response**](AuthPlayer200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a new player. Returns a player object containing a wallet (used to interact with contracts, currencies, etc). |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePlayer

> PlayerModel UpdatePlayer (string playerId, string xAuthorization, UpdatePlayerRequest updatePlayerRequest)

Update player

Update various fields specific to a player. Such as changing its password and resetting its access token.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class UpdatePlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new PlayersApi(Configuration.Default);
            var playerId = "playerId_example";  // string | Any player id within the MetaFab ecosystem.
            var xAuthorization = player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `accessToken` of the authenticating player.
            var updatePlayerRequest = new UpdatePlayerRequest(); // UpdatePlayerRequest | 

            try
            {
                // Update player
                PlayerModel result = apiInstance.UpdatePlayer(playerId, xAuthorization, updatePlayerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayersApi.UpdatePlayer: " + e.Message );
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
 **playerId** | **string**| Any player id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;accessToken&#x60; of the authenticating player. | 
 **updatePlayerRequest** | [**UpdatePlayerRequest**](UpdatePlayerRequest.md)|  | 

### Return type

[**PlayerModel**](PlayerModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated player object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

