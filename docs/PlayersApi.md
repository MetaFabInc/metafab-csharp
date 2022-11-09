# Org.MetaFab.Api.PlayersApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthPlayer**](PlayersApi.md#authplayer) | **GET** /v1/players/auth | Authenticate player
[**CreatePlayer**](PlayersApi.md#createplayer) | **POST** /v1/players | Create player
[**GetPlayer**](PlayersApi.md#getplayer) | **GET** /v1/players/{playerId} | Get player
[**GetPlayerData**](PlayersApi.md#getplayerdata) | **GET** /v1/players/{playerId}/data | Get player data
[**GetPlayers**](PlayersApi.md#getplayers) | **GET** /v1/players | Get players
[**SetPlayerData**](PlayersApi.md#setplayerdata) | **POST** /v1/players/{playerId}/data | Set player data
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


## GetPlayer

> PublicPlayer GetPlayer (string playerId)

Get player

Returns a player object for the provided player id.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetPlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new PlayersApi(Configuration.Default);
            var playerId = "playerId_example";  // string | Any player id within the MetaFab ecosystem.

            try
            {
                // Get player
                PublicPlayer result = apiInstance.GetPlayer(playerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayersApi.GetPlayer: " + e.Message );
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

### Return type

[**PublicPlayer**](PublicPlayer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved player. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlayerData

> GetPlayerData200Response GetPlayerData (string playerId)

Get player data

Returns the latest public and protected data as an object for the provided playerId.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetPlayerDataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new PlayersApi(Configuration.Default);
            var playerId = "playerId_example";  // string | Any player id within the MetaFab ecosystem.

            try
            {
                // Get player data
                GetPlayerData200Response result = apiInstance.GetPlayerData(playerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayersApi.GetPlayerData: " + e.Message );
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

### Return type

[**GetPlayerData200Response**](GetPlayerData200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved player data. Returns latest player data object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPlayers

> List&lt;PublicPlayer&gt; GetPlayers (string xAuthorization)

Get players

Returns all players for the authenticated game as an array of player objects.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetPlayersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new PlayersApi(Configuration.Default);
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.

            try
            {
                // Get players
                List<PublicPlayer> result = apiInstance.GetPlayers(xAuthorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayersApi.GetPlayers: " + e.Message );
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

### Return type

[**List&lt;PublicPlayer&gt;**](PublicPlayer.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved players. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetPlayerData

> GetPlayerData200Response SetPlayerData (string playerId, string xAuthorization, SetPlayerDataRequest setPlayerDataRequest)

Set player data

Creates or updates public and/or protected data for the provided playerId. Data updates are performed using deep merging. This means that when you update any top level or nested properties specific to player public or protected data, you only need to include the properties you are making changes to. Any existing properties not included in request body arguments will be retained on the player data object.  Please note, When writing an array type for a player, arrays do not follow the deep merge approach. If you add or remove an item from an array, the entire array must be passed as an argument when updating the related property for player public or protected data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class SetPlayerDataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new PlayersApi(Configuration.Default);
            var playerId = "playerId_example";  // string | Any player id within the MetaFab ecosystem.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var setPlayerDataRequest = new SetPlayerDataRequest(); // SetPlayerDataRequest | 

            try
            {
                // Set player data
                GetPlayerData200Response result = apiInstance.SetPlayerData(playerId, xAuthorization, setPlayerDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PlayersApi.SetPlayerData: " + e.Message );
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
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **setPlayerDataRequest** | [**SetPlayerDataRequest**](SetPlayerDataRequest.md)|  | 

### Return type

[**GetPlayerData200Response**](GetPlayerData200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully set player data. Returns latest player data object. |  -  |
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

