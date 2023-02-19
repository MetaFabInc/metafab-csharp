# Org.MetaFab.Api.EcosystemsApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApproveEcosystemGame**](EcosystemsApi.md#approveecosystemgame) | **POST** /v1/ecosystems/{ecosystemId}/games | Approve ecosystem game
[**AuthEcosystem**](EcosystemsApi.md#authecosystem) | **GET** /v1/ecosystems/auth | Authenticate ecosystem
[**AuthProfile**](EcosystemsApi.md#authprofile) | **GET** /v1/profiles/auth | Authenticate profile
[**AuthProfilePlayer**](EcosystemsApi.md#authprofileplayer) | **GET** /v1/profiles/{profileId}/games/{gameId}/players/auth | Authenticate profile player
[**CreateEcosystem**](EcosystemsApi.md#createecosystem) | **POST** /v1/ecosystems | Create ecosystem
[**CreateProfile**](EcosystemsApi.md#createprofile) | **POST** /v1/profiles | Create profile
[**CreateProfilePlayer**](EcosystemsApi.md#createprofileplayer) | **POST** /v1/profiles/{profileId}/games/{gameId}/players | Create profile player
[**GetEcosystem**](EcosystemsApi.md#getecosystem) | **GET** /v1/ecosystems/{ecosystemId} | Get ecosystem
[**GetEcosystemGame**](EcosystemsApi.md#getecosystemgame) | **GET** /v1/ecosystems/{ecosystemId}/games/{gameId} | Get ecosystem game
[**GetEcosystemGames**](EcosystemsApi.md#getecosystemgames) | **GET** /v1/ecosystems/{ecosystemId}/games | Get ecosystem games
[**GetProfileGame**](EcosystemsApi.md#getprofilegame) | **GET** /v1/profiles/{profileId}/games/{gameId} | Get profile game
[**GetProfileGames**](EcosystemsApi.md#getprofilegames) | **GET** /v1/profiles/{profileId}/games | Get profile games
[**UnapproveEcosystemGame**](EcosystemsApi.md#unapproveecosystemgame) | **DELETE** /v1/ecosystems/{ecosystemId}/games/{gameId} | Unapprove ecosystem game
[**UpdateEcosystem**](EcosystemsApi.md#updateecosystem) | **PATCH** /v1/ecosystems/{ecosystemId} | Update ecosystem
[**UpdateProfile**](EcosystemsApi.md#updateprofile) | **PATCH** /v1/profiles/{profileId} | Update profile
[**UpdateProfilePlayer**](EcosystemsApi.md#updateprofileplayer) | **PATCH** /v1/profiles/{profileId}/games/{gameId}/players/{playerId} | Update profile player



## ApproveEcosystemGame

> void ApproveEcosystemGame (string ecosystemId, string xAuthorization, ApproveEcosystemGameRequest approveEcosystemGameRequest)

Approve ecosystem game

Approves a game for an ecosystem. By approving a game, it allows that game to integrate the ability for profile accounts from an ecosystem to login directly to the approved game and play. This also allows games to request access to assets held at the profile level for the game to frictionlessly interact with on behalf of the profile.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class ApproveEcosystemGameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var ecosystemId = "ecosystemId_example";  // string | The ecosystem id of the authenticating ecosystem.
            var xAuthorization = ecosystem_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating ecosystem.
            var approveEcosystemGameRequest = new ApproveEcosystemGameRequest(); // ApproveEcosystemGameRequest | 

            try
            {
                // Approve ecosystem game
                apiInstance.ApproveEcosystemGame(ecosystemId, xAuthorization, approveEcosystemGameRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.ApproveEcosystemGame: " + e.Message );
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
 **ecosystemId** | **string**| The ecosystem id of the authenticating ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating ecosystem. | 
 **approveEcosystemGameRequest** | [**ApproveEcosystemGameRequest**](ApproveEcosystemGameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully approved the game for the ecosystem. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AuthEcosystem

> EcosystemModel AuthEcosystem ()

Authenticate ecosystem

Returns an existing ecosystem object containing authorization keys when provided a valid email (in place of username) and password login using Basic Auth.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class AuthEcosystemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EcosystemsApi(Configuration.Default);

            try
            {
                // Authenticate ecosystem
                EcosystemModel result = apiInstance.AuthEcosystem();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.AuthEcosystem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**EcosystemModel**](EcosystemModel.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Succesfully authorized the request and retrieved an ecosystem object containing authorization keys and credentials. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AuthProfile

> AuthProfile200Response AuthProfile (string xEcosystemKey)

Authenticate profile

Returns an existing profile object containing access token, wallet, and other details when provided a valid profile username and password login using Basic Auth.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class AuthProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new EcosystemsApi(Configuration.Default);
            var xEcosystemKey = ecosystem_pk_a5sFpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific ecosystem. This can be shared or included in clients, websites, etc.

            try
            {
                // Authenticate profile
                AuthProfile200Response result = apiInstance.AuthProfile(xEcosystemKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.AuthProfile: " + e.Message );
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
 **xEcosystemKey** | **string**| The &#x60;publishedKey&#x60; of a specific ecosystem. This can be shared or included in clients, websites, etc. | 

### Return type

[**AuthProfile200Response**](AuthProfile200Response.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Succesfully authorized the request and retrieved a profile object containing access token, wallet, and other details. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AuthProfilePlayer

> AuthPlayer200Response AuthProfilePlayer (string profileId, string gameId, string xAuthorization, string xWalletDecryptKey, string xUsername)

Authenticate profile player

Returns an existing player object containing access token, wallet, wallet decrypt key, profile authorization and other details for a game when provided profile authentication and the player's username.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class AuthProfilePlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var profileId = "profileId_example";  // string | The profile id of the authenticating profile.
            var gameId = "gameId_example";  // string | Any game id within the MetaFab platform.
            var xAuthorization = profile_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `accessToken` of the authenticating profile.
            var xWalletDecryptKey = AXNP8MKb+5SbBtHWrZu5KHh5/BomXY/dMRG/BDUn7a4=;  // string | The `walletDecryptKey` of the authenticating profile. Required to decrypt and perform blockchain transactions with the profile wallet.
            var xUsername = arkdev;  // string | The username of a player.

            try
            {
                // Authenticate profile player
                AuthPlayer200Response result = apiInstance.AuthProfilePlayer(profileId, gameId, xAuthorization, xWalletDecryptKey, xUsername);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.AuthProfilePlayer: " + e.Message );
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
 **profileId** | **string**| The profile id of the authenticating profile. | 
 **gameId** | **string**| Any game id within the MetaFab platform. | 
 **xAuthorization** | **string**| The &#x60;accessToken&#x60; of the authenticating profile. | 
 **xWalletDecryptKey** | **string**| The &#x60;walletDecryptKey&#x60; of the authenticating profile. Required to decrypt and perform blockchain transactions with the profile wallet. | 
 **xUsername** | **string**| The username of a player. | 

### Return type

[**AuthPlayer200Response**](AuthPlayer200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Succesfully authorized the request and retrieved a player object containing access token, wallet, profile authorization, and other details. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateEcosystem

> EcosystemModel CreateEcosystem (CreateEcosystemRequest createEcosystemRequest)

Create ecosystem

Create a new ecosystem. An ecosystem is a parent entity that many profiles live under for a given ecosystem of games. Ecosystems allow your players to create one profile within your ecosystem that allows a single account and wallet to be used across all of the approved games in your ecosystem that they play.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateEcosystemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var createEcosystemRequest = new CreateEcosystemRequest(); // CreateEcosystemRequest | 

            try
            {
                // Create ecosystem
                EcosystemModel result = apiInstance.CreateEcosystem(createEcosystemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.CreateEcosystem: " + e.Message );
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
 **createEcosystemRequest** | [**CreateEcosystemRequest**](CreateEcosystemRequest.md)|  | 

### Return type

[**EcosystemModel**](EcosystemModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a new ecosystem. Returns an ecosystem object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateProfile

> AuthProfile200Response CreateProfile (string xEcosystemKey, CreateProfileRequest createProfileRequest)

Create profile

Create a new profile. Profiles are automatically associated with an internally managed wallet. Profiles can be thought of as a umbrella account that can be used to sign into and create player accounts across many games and have a singular asset store wallet at the profile level that can be used across all connected player accounts for games those player accounts are a part of.  Profiles are associated to a parent ecosystem of games. This allows an ecosystem to approve a permissioned set of games that can request authorized wallet permissions from profiles of players for their game.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var xEcosystemKey = ecosystem_pk_a5sFpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific ecosystem. This can be shared or included in clients, websites, etc.
            var createProfileRequest = new CreateProfileRequest(); // CreateProfileRequest | 

            try
            {
                // Create profile
                AuthProfile200Response result = apiInstance.CreateProfile(xEcosystemKey, createProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.CreateProfile: " + e.Message );
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
 **xEcosystemKey** | **string**| The &#x60;publishedKey&#x60; of a specific ecosystem. This can be shared or included in clients, websites, etc. | 
 **createProfileRequest** | [**CreateProfileRequest**](CreateProfileRequest.md)|  | 

### Return type

[**AuthProfile200Response**](AuthProfile200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a new profile. Returns a profile object containing a wallet (used to interact with contracts, currencies, etc). |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateProfilePlayer

> AuthPlayer200Response CreateProfilePlayer (string profileId, string gameId, string xAuthorization, string xWalletDecryptKey, CreateProfilePlayerRequest createProfilePlayerRequest)

Create profile player

Creates a new player account for the provided game id linked to the authenticating profile. The created player account will default to using the parent profile's wallet for any transactions, wallet content balance checks and verifications, and more.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateProfilePlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var profileId = "profileId_example";  // string | The profile id of the authenticating profile.
            var gameId = "gameId_example";  // string | Any game id within the MetaFab platform.
            var xAuthorization = profile_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `accessToken` of the authenticating profile.
            var xWalletDecryptKey = AXNP8MKb+5SbBtHWrZu5KHh5/BomXY/dMRG/BDUn7a4=;  // string | The `walletDecryptKey` of the authenticating profile. Required to decrypt and perform blockchain transactions with the profile wallet.
            var createProfilePlayerRequest = new CreateProfilePlayerRequest(); // CreateProfilePlayerRequest | 

            try
            {
                // Create profile player
                AuthPlayer200Response result = apiInstance.CreateProfilePlayer(profileId, gameId, xAuthorization, xWalletDecryptKey, createProfilePlayerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.CreateProfilePlayer: " + e.Message );
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
 **profileId** | **string**| The profile id of the authenticating profile. | 
 **gameId** | **string**| Any game id within the MetaFab platform. | 
 **xAuthorization** | **string**| The &#x60;accessToken&#x60; of the authenticating profile. | 
 **xWalletDecryptKey** | **string**| The &#x60;walletDecryptKey&#x60; of the authenticating profile. Required to decrypt and perform blockchain transactions with the profile wallet. | 
 **createProfilePlayerRequest** | [**CreateProfilePlayerRequest**](CreateProfilePlayerRequest.md)|  | 

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
| **200** | Successfully created a new player linked to the authenticating profile. Returns a player object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEcosystem

> PublicEcosystem GetEcosystem (string ecosystemId)

Get ecosystem

Returns a ecosystem object for the provided ecosystem id.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetEcosystemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var ecosystemId = "ecosystemId_example";  // string | Any ecosystem id within the MetaFab platform.

            try
            {
                // Get ecosystem
                PublicEcosystem result = apiInstance.GetEcosystem(ecosystemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.GetEcosystem: " + e.Message );
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
 **ecosystemId** | **string**| Any ecosystem id within the MetaFab platform. | 

### Return type

[**PublicEcosystem**](PublicEcosystem.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved ecosystem. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEcosystemGame

> PublicGame GetEcosystemGame (string ecosystemId, string gameId)

Get ecosystem game

Returns a game object for the provided game id that the ecosystem has approved.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetEcosystemGameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var ecosystemId = "ecosystemId_example";  // string | Any ecosystem id within the MetaFab platform.
            var gameId = "gameId_example";  // string | Any game id within the MetaFab platform.

            try
            {
                // Get ecosystem game
                PublicGame result = apiInstance.GetEcosystemGame(ecosystemId, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.GetEcosystemGame: " + e.Message );
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
 **ecosystemId** | **string**| Any ecosystem id within the MetaFab platform. | 
 **gameId** | **string**| Any game id within the MetaFab platform. | 

### Return type

[**PublicGame**](PublicGame.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved an approved game. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEcosystemGames

> List&lt;PublicGame&gt; GetEcosystemGames (string ecosystemId)

Get ecosystem games

Returns an array of games the ecosystem has approved.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetEcosystemGamesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var ecosystemId = "ecosystemId_example";  // string | Any ecosystem id within the MetaFab platform.

            try
            {
                // Get ecosystem games
                List<PublicGame> result = apiInstance.GetEcosystemGames(ecosystemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.GetEcosystemGames: " + e.Message );
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
 **ecosystemId** | **string**| Any ecosystem id within the MetaFab platform. | 

### Return type

[**List&lt;PublicGame&gt;**](PublicGame.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved an array of approved games. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProfileGame

> GetProfileGames200ResponseInner GetProfileGame (string profileId, string gameId, string xAuthorization)

Get profile game

Returns a game this profile has connected player accounts for.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetProfileGameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var profileId = "profileId_example";  // string | The profile id of the authenticating profile.
            var gameId = "gameId_example";  // string | Any game id within the MetaFab platform.
            var xAuthorization = profile_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `accessToken` of the authenticating profile.

            try
            {
                // Get profile game
                GetProfileGames200ResponseInner result = apiInstance.GetProfileGame(profileId, gameId, xAuthorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.GetProfileGame: " + e.Message );
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
 **profileId** | **string**| The profile id of the authenticating profile. | 
 **gameId** | **string**| Any game id within the MetaFab platform. | 
 **xAuthorization** | **string**| The &#x60;accessToken&#x60; of the authenticating profile. | 

### Return type

[**GetProfileGames200ResponseInner**](GetProfileGames200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved array of games this profile has connected player accounts for. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProfileGames

> List&lt;GetProfileGames200ResponseInner&gt; GetProfileGames (string profileId, string xAuthorization)

Get profile games

Returns an array of games the authorized profile has connected player accounts for.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetProfileGamesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var profileId = "profileId_example";  // string | The profile id of the authenticating profile.
            var xAuthorization = profile_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `accessToken` of the authenticating profile.

            try
            {
                // Get profile games
                List<GetProfileGames200ResponseInner> result = apiInstance.GetProfileGames(profileId, xAuthorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.GetProfileGames: " + e.Message );
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
 **profileId** | **string**| The profile id of the authenticating profile. | 
 **xAuthorization** | **string**| The &#x60;accessToken&#x60; of the authenticating profile. | 

### Return type

[**List&lt;GetProfileGames200ResponseInner&gt;**](GetProfileGames200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved array of games this profile has connected player accounts for. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnapproveEcosystemGame

> void UnapproveEcosystemGame (string ecosystemId, string gameId, string xAuthorization)

Unapprove ecosystem game

Unapproves a game for an ecosystem. The game will no longer be able to allow profiles from the ecosystem to login. All profile permissions approved for the game will also be revoked.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class UnapproveEcosystemGameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var ecosystemId = "ecosystemId_example";  // string | The ecosystem id of the authenticating ecosystem.
            var gameId = "gameId_example";  // string | Any game id within the MetaFab platform.
            var xAuthorization = ecosystem_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating ecosystem.

            try
            {
                // Unapprove ecosystem game
                apiInstance.UnapproveEcosystemGame(ecosystemId, gameId, xAuthorization);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.UnapproveEcosystemGame: " + e.Message );
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
 **ecosystemId** | **string**| The ecosystem id of the authenticating ecosystem. | 
 **gameId** | **string**| Any game id within the MetaFab platform. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating ecosystem. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully approved the game for the ecosystem. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateEcosystem

> EcosystemModel UpdateEcosystem (string ecosystemId, string xAuthorization, UpdateEcosystemRequest updateEcosystemRequest)

Update ecosystem

Update various fields specific to an ecosystem. Such as changing its password, resetting its published or secret key, or updating its approved games.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class UpdateEcosystemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var ecosystemId = "ecosystemId_example";  // string | The ecosystem id of the authenticating ecosystem.
            var xAuthorization = ecosystem_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating ecosystem.
            var updateEcosystemRequest = new UpdateEcosystemRequest(); // UpdateEcosystemRequest | 

            try
            {
                // Update ecosystem
                EcosystemModel result = apiInstance.UpdateEcosystem(ecosystemId, xAuthorization, updateEcosystemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.UpdateEcosystem: " + e.Message );
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
 **ecosystemId** | **string**| The ecosystem id of the authenticating ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating ecosystem. | 
 **updateEcosystemRequest** | [**UpdateEcosystemRequest**](UpdateEcosystemRequest.md)|  | 

### Return type

[**EcosystemModel**](EcosystemModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated ecosystem object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateProfile

> ProfileModel UpdateProfile (string profileId, string xAuthorization, UpdateProfileRequest updateProfileRequest)

Update profile

Update various fields specific to a profile. Such as changing its password and resetting its access token.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class UpdateProfileExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var profileId = "profileId_example";  // string | The profile id of the authenticating profile.
            var xAuthorization = profile_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `accessToken` of the authenticating profile.
            var updateProfileRequest = new UpdateProfileRequest(); // UpdateProfileRequest | 

            try
            {
                // Update profile
                ProfileModel result = apiInstance.UpdateProfile(profileId, xAuthorization, updateProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.UpdateProfile: " + e.Message );
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
 **profileId** | **string**| The profile id of the authenticating profile. | 
 **xAuthorization** | **string**| The &#x60;accessToken&#x60; of the authenticating profile. | 
 **updateProfileRequest** | [**UpdateProfileRequest**](UpdateProfileRequest.md)|  | 

### Return type

[**ProfileModel**](ProfileModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the updated profile object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateProfilePlayer

> UpdateProfilePlayer200Response UpdateProfilePlayer (string profileId, string gameId, string playerId, string xAuthorization, string xWalletDecryptKey, UpdateProfilePlayerRequest updateProfilePlayerRequest)

Update profile player

Update various fields specific to a player. Such as changing its permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class UpdateProfilePlayerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new EcosystemsApi(Configuration.Default);
            var profileId = "profileId_example";  // string | The profile id of the authenticating profile.
            var gameId = "gameId_example";  // string | Any game id within the MetaFab platform.
            var playerId = "playerId_example";  // string | Any player id within the MetaFab platform.
            var xAuthorization = profile_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `accessToken` of the authenticating profile.
            var xWalletDecryptKey = AXNP8MKb+5SbBtHWrZu5KHh5/BomXY/dMRG/BDUn7a4=;  // string | The `walletDecryptKey` of the authenticating profile. Required to decrypt and perform blockchain transactions with the profile wallet.
            var updateProfilePlayerRequest = new UpdateProfilePlayerRequest(); // UpdateProfilePlayerRequest | 

            try
            {
                // Update profile player
                UpdateProfilePlayer200Response result = apiInstance.UpdateProfilePlayer(profileId, gameId, playerId, xAuthorization, xWalletDecryptKey, updateProfilePlayerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EcosystemsApi.UpdateProfilePlayer: " + e.Message );
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
 **profileId** | **string**| The profile id of the authenticating profile. | 
 **gameId** | **string**| Any game id within the MetaFab platform. | 
 **playerId** | **string**| Any player id within the MetaFab platform. | 
 **xAuthorization** | **string**| The &#x60;accessToken&#x60; of the authenticating profile. | 
 **xWalletDecryptKey** | **string**| The &#x60;walletDecryptKey&#x60; of the authenticating profile. Required to decrypt and perform blockchain transactions with the profile wallet. | 
 **updateProfilePlayerRequest** | [**UpdateProfilePlayerRequest**](UpdateProfilePlayerRequest.md)|  | 

### Return type

[**UpdateProfilePlayer200Response**](UpdateProfilePlayer200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated the player. Returns a player object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

