# Org.MetaFab - the C# library for the MetaFab API

 Complete MetaFab API references and guides can be found at: https://trymetafab.com

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.4.1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://trymetafab.com](https://trymetafab.com)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.MetaFab.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ContractsApi(Configuration.Default);
            var xAuthorization = game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP;  // string | The `secretKey` of the authenticating game.
            var createContractRequest = new CreateContractRequest(); // CreateContractRequest | 

            try
            {
                // Create custom contract
                ContractModel result = apiInstance.CreateContract(xAuthorization, createContractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContractsApi.CreateContract: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.trymetafab.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ContractsApi* | [**CreateContract**](docs/ContractsApi.md#createcontract) | **POST** /v1/contracts | Create custom contract
*ContractsApi* | [**GetContracts**](docs/ContractsApi.md#getcontracts) | **GET** /v1/contracts | Get contracts
*ContractsApi* | [**ReadContract**](docs/ContractsApi.md#readcontract) | **GET** /v1/contracts/{contractId}/reads | Read contract data
*ContractsApi* | [**TransferContractOwnership**](docs/ContractsApi.md#transfercontractownership) | **POST** /v1/contracts/{contractId}/owners | Transfer contract ownership
*ContractsApi* | [**UpgradeContractTrustedForwarder**](docs/ContractsApi.md#upgradecontracttrustedforwarder) | **POST** /v1/contracts/{contractId}/forwarders | Upgrade contract trusted forwarder
*ContractsApi* | [**WriteContract**](docs/ContractsApi.md#writecontract) | **POST** /v1/contracts/{contractId}/writes | Write contract data
*CurrenciesApi* | [**BatchTransferCurrency**](docs/CurrenciesApi.md#batchtransfercurrency) | **POST** /v1/currencies/{currencyId}/batchTransfers | Batch transfer currency
*CurrenciesApi* | [**BurnCurrency**](docs/CurrenciesApi.md#burncurrency) | **POST** /v1/currencies/{currencyId}/burns | Burn currency
*CurrenciesApi* | [**CreateCurrency**](docs/CurrenciesApi.md#createcurrency) | **POST** /v1/currencies | Create currency
*CurrenciesApi* | [**GetCurrencies**](docs/CurrenciesApi.md#getcurrencies) | **GET** /v1/currencies | Get currencies
*CurrenciesApi* | [**GetCurrencyBalance**](docs/CurrenciesApi.md#getcurrencybalance) | **GET** /v1/currencies/{currencyId}/balances | Get currency balance
*CurrenciesApi* | [**GetCurrencyFees**](docs/CurrenciesApi.md#getcurrencyfees) | **GET** /v1/currencies/{currencyId}/fees | Get currency fees
*CurrenciesApi* | [**GetCurrencyRole**](docs/CurrenciesApi.md#getcurrencyrole) | **GET** /v1/currencies/{currencyId}/roles | Get currency role
*CurrenciesApi* | [**GrantCurrencyRole**](docs/CurrenciesApi.md#grantcurrencyrole) | **POST** /v1/currencies/{currencyId}/roles | Grant currency role
*CurrenciesApi* | [**MintCurrency**](docs/CurrenciesApi.md#mintcurrency) | **POST** /v1/currencies/{currencyId}/mints | Mint currency
*CurrenciesApi* | [**RevokeCurrencyRole**](docs/CurrenciesApi.md#revokecurrencyrole) | **DELETE** /v1/currencies/{currencyId}/roles | Revoke currency role
*CurrenciesApi* | [**SetCurrencyFees**](docs/CurrenciesApi.md#setcurrencyfees) | **POST** /v1/currencies/{currencyId}/fees | Set currency fees
*CurrenciesApi* | [**TransferCurrency**](docs/CurrenciesApi.md#transfercurrency) | **POST** /v1/currencies/{currencyId}/transfers | Transfer currency
*GamesApi* | [**AuthGame**](docs/GamesApi.md#authgame) | **GET** /v1/games/auth | Authenticate game
*GamesApi* | [**CreateGame**](docs/GamesApi.md#creategame) | **POST** /v1/games | Create game
*GamesApi* | [**GetGame**](docs/GamesApi.md#getgame) | **GET** /v1/games/{gameId} | Get game
*GamesApi* | [**UpdateGame**](docs/GamesApi.md#updategame) | **PATCH** /v1/games/{gameId} | Update game
*ItemsApi* | [**BatchMintCollectionItems**](docs/ItemsApi.md#batchmintcollectionitems) | **POST** /v1/collections/{collectionId}/batchMints | Batch mint collection items
*ItemsApi* | [**BatchTransferCollectionItems**](docs/ItemsApi.md#batchtransfercollectionitems) | **POST** /v1/collections/{collectionId}/batchTransfers | Batch transfer collection items
*ItemsApi* | [**BurnCollectionItem**](docs/ItemsApi.md#burncollectionitem) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/burns | Burn collection item
*ItemsApi* | [**CreateCollection**](docs/ItemsApi.md#createcollection) | **POST** /v1/collections | Create collection
*ItemsApi* | [**CreateCollectionItem**](docs/ItemsApi.md#createcollectionitem) | **POST** /v1/collections/{collectionId}/items | Create collection item
*ItemsApi* | [**GetCollectionApproval**](docs/ItemsApi.md#getcollectionapproval) | **GET** /v1/collections/{collectionId}/approvals | Get collection approval
*ItemsApi* | [**GetCollectionItem**](docs/ItemsApi.md#getcollectionitem) | **GET** /v1/collections/{collectionId}/items/{collectionItemId} | Get collection item
*ItemsApi* | [**GetCollectionItemBalance**](docs/ItemsApi.md#getcollectionitembalance) | **GET** /v1/collections/{collectionId}/items/{collectionItemId}/balances | Get collection item balance
*ItemsApi* | [**GetCollectionItemBalances**](docs/ItemsApi.md#getcollectionitembalances) | **GET** /v1/collections/{collectionId}/balances | Get collection item balances
*ItemsApi* | [**GetCollectionItemSupplies**](docs/ItemsApi.md#getcollectionitemsupplies) | **GET** /v1/collections/{collectionId}/supplies | Get collection item supplies
*ItemsApi* | [**GetCollectionItemSupply**](docs/ItemsApi.md#getcollectionitemsupply) | **GET** /v1/collections/{collectionId}/items/{collectionItemId}/supplies | Get collection item supply
*ItemsApi* | [**GetCollectionItemTimelock**](docs/ItemsApi.md#getcollectionitemtimelock) | **GET** /v1/collections/{collectionId}/items/{collectionItemId}/timelocks | Get collection item timelock
*ItemsApi* | [**GetCollectionItems**](docs/ItemsApi.md#getcollectionitems) | **GET** /v1/collections/{collectionId}/items | Get collection items
*ItemsApi* | [**GetCollectionRole**](docs/ItemsApi.md#getcollectionrole) | **GET** /v1/collections/{collectionId}/roles | Get collection role
*ItemsApi* | [**GetCollections**](docs/ItemsApi.md#getcollections) | **GET** /v1/collections | Get collections
*ItemsApi* | [**GrantCollectionRole**](docs/ItemsApi.md#grantcollectionrole) | **POST** /v1/collections/{collectionId}/roles | Grant collection role
*ItemsApi* | [**MintCollectionItem**](docs/ItemsApi.md#mintcollectionitem) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/mints | Mint collection item
*ItemsApi* | [**RevokeCollectionRole**](docs/ItemsApi.md#revokecollectionrole) | **DELETE** /v1/collections/{collectionId}/roles | Revoke collection role
*ItemsApi* | [**SetCollectionApproval**](docs/ItemsApi.md#setcollectionapproval) | **POST** /v1/collections/{collectionId}/approvals | Set collection approval
*ItemsApi* | [**SetCollectionItemTimelock**](docs/ItemsApi.md#setcollectionitemtimelock) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/timelocks | Set collection item timelock
*ItemsApi* | [**TransferCollectionItem**](docs/ItemsApi.md#transfercollectionitem) | **POST** /v1/collections/{collectionId}/items/{collectionItemId}/transfers | Transfer collection item
*LootboxesApi* | [**CreateLootboxManager**](docs/LootboxesApi.md#createlootboxmanager) | **POST** /v1/lootboxManagers | Create lootbox manager
*LootboxesApi* | [**GetLootboxManagerLootbox**](docs/LootboxesApi.md#getlootboxmanagerlootbox) | **GET** /v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId} | Get lootbox manager lootbox
*LootboxesApi* | [**GetLootboxManagerLootboxes**](docs/LootboxesApi.md#getlootboxmanagerlootboxes) | **GET** /v1/lootboxManagers/{lootboxManagerId}/lootboxes | Get lootbox manager lootboxes
*LootboxesApi* | [**GetLootboxManagers**](docs/LootboxesApi.md#getlootboxmanagers) | **GET** /v1/lootboxManagers | Get lootbox managers
*LootboxesApi* | [**OpenLootboxManagerLootbox**](docs/LootboxesApi.md#openlootboxmanagerlootbox) | **POST** /v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId}/opens | Open lootbox manager lootbox
*LootboxesApi* | [**RemoveLootboxManagerLootbox**](docs/LootboxesApi.md#removelootboxmanagerlootbox) | **DELETE** /v1/lootboxManagers/{lootboxManagerId}/lootboxes/{lootboxManagerLootboxId} | Remove lootbox manager lootbox
*LootboxesApi* | [**SetLootboxManagerLootbox**](docs/LootboxesApi.md#setlootboxmanagerlootbox) | **POST** /v1/lootboxManagers/{lootboxManagerId}/lootboxes | Set lootbox manager lootbox
*PlayersApi* | [**AuthPlayer**](docs/PlayersApi.md#authplayer) | **GET** /v1/players/auth | Authenticate player
*PlayersApi* | [**CreatePlayer**](docs/PlayersApi.md#createplayer) | **POST** /v1/players | Create player
*PlayersApi* | [**GetPlayer**](docs/PlayersApi.md#getplayer) | **GET** /v1/players/{playerId} | Get player
*PlayersApi* | [**GetPlayerData**](docs/PlayersApi.md#getplayerdata) | **GET** /v1/players/{playerId}/data | Get player data
*PlayersApi* | [**GetPlayers**](docs/PlayersApi.md#getplayers) | **GET** /v1/players | Get players
*PlayersApi* | [**RemovePlayerConnectedWallet**](docs/PlayersApi.md#removeplayerconnectedwallet) | **DELETE** /v1/players/{playerId}/wallets/{playerWalletId} | Remove player connected wallet
*PlayersApi* | [**SetPlayerConnectedWallet**](docs/PlayersApi.md#setplayerconnectedwallet) | **POST** /v1/players/{playerId}/wallets | Set player connected wallet
*PlayersApi* | [**SetPlayerData**](docs/PlayersApi.md#setplayerdata) | **POST** /v1/players/{playerId}/data | Set player data
*PlayersApi* | [**UpdatePlayer**](docs/PlayersApi.md#updateplayer) | **PATCH** /v1/players/{playerId} | Update player
*ShopsApi* | [**CreateShop**](docs/ShopsApi.md#createshop) | **POST** /v1/shops | Create shop
*ShopsApi* | [**GetShopOffer**](docs/ShopsApi.md#getshopoffer) | **GET** /v1/shops/{shopId}/items/{shopOfferId} | Get shop offer
*ShopsApi* | [**GetShopOffers**](docs/ShopsApi.md#getshopoffers) | **GET** /v1/shops/{shopId}/offers | Get shop offers
*ShopsApi* | [**GetShops**](docs/ShopsApi.md#getshops) | **GET** /v1/shops | Get shops
*ShopsApi* | [**RemoveShopOffer**](docs/ShopsApi.md#removeshopoffer) | **DELETE** /v1/shops/{shopId}/offers/{shopOfferId} | Remove shop offer
*ShopsApi* | [**SetShopOffer**](docs/ShopsApi.md#setshopoffer) | **POST** /v1/shops/{shopId}/offers | Set shop offer
*ShopsApi* | [**UseShopOffer**](docs/ShopsApi.md#useshopoffer) | **POST** /v1/shops/{shopId}/offers/{shopOfferId}/uses | Use shop offer
*ShopsApi* | [**WithdrawFromShop**](docs/ShopsApi.md#withdrawfromshop) | **POST** /v1/shops/{shopId}/withdrawals | Withdraw from shop
*TransactionsApi* | [**GetTransaction**](docs/TransactionsApi.md#gettransaction) | **GET** /v1/transactions/{transactionId} | Get transaction
*WalletsApi* | [**GetWalletBalances**](docs/WalletsApi.md#getwalletbalances) | **GET** /v1/wallets/{walletId}/balances | Get wallet balances
*WalletsApi* | [**GetWalletTransactions**](docs/WalletsApi.md#getwallettransactions) | **GET** /v1/wallets/{walletId}/transactions | Get wallet transactions


## Documentation for Models

 - [Model.AuthGame200Response](docs/AuthGame200Response.md)
 - [Model.AuthGame200ResponseAllOf](docs/AuthGame200ResponseAllOf.md)
 - [Model.AuthGame200ResponseAllOf1](docs/AuthGame200ResponseAllOf1.md)
 - [Model.AuthPlayer200Response](docs/AuthPlayer200Response.md)
 - [Model.BatchMintCollectionItemsRequest](docs/BatchMintCollectionItemsRequest.md)
 - [Model.BatchTransferCollectionItemsRequest](docs/BatchTransferCollectionItemsRequest.md)
 - [Model.BatchTransferCurrencyRequest](docs/BatchTransferCurrencyRequest.md)
 - [Model.BurnCollectionItemRequest](docs/BurnCollectionItemRequest.md)
 - [Model.BurnCurrencyRequest](docs/BurnCurrencyRequest.md)
 - [Model.CollectionModel](docs/CollectionModel.md)
 - [Model.ContractModel](docs/ContractModel.md)
 - [Model.CreateCollection200Response](docs/CreateCollection200Response.md)
 - [Model.CreateCollection200ResponseAllOf](docs/CreateCollection200ResponseAllOf.md)
 - [Model.CreateCollection200ResponseAllOfContract](docs/CreateCollection200ResponseAllOfContract.md)
 - [Model.CreateCollection200ResponseAllOfContractAllOf](docs/CreateCollection200ResponseAllOfContractAllOf.md)
 - [Model.CreateCollectionItemRequest](docs/CreateCollectionItemRequest.md)
 - [Model.CreateCollectionItemRequestAttributesInner](docs/CreateCollectionItemRequestAttributesInner.md)
 - [Model.CreateCollectionRequest](docs/CreateCollectionRequest.md)
 - [Model.CreateContractRequest](docs/CreateContractRequest.md)
 - [Model.CreateCurrency200Response](docs/CreateCurrency200Response.md)
 - [Model.CreateCurrencyRequest](docs/CreateCurrencyRequest.md)
 - [Model.CreateGameRequest](docs/CreateGameRequest.md)
 - [Model.CreateLootboxManager200Response](docs/CreateLootboxManager200Response.md)
 - [Model.CreateLootboxManagerRequest](docs/CreateLootboxManagerRequest.md)
 - [Model.CreatePlayerRequest](docs/CreatePlayerRequest.md)
 - [Model.CreateShop200Response](docs/CreateShop200Response.md)
 - [Model.CreateShopRequest](docs/CreateShopRequest.md)
 - [Model.CurrencyModel](docs/CurrencyModel.md)
 - [Model.GameModel](docs/GameModel.md)
 - [Model.GetCollections200ResponseInner](docs/GetCollections200ResponseInner.md)
 - [Model.GetCollections200ResponseInnerAllOf](docs/GetCollections200ResponseInnerAllOf.md)
 - [Model.GetCurrencies200ResponseInner](docs/GetCurrencies200ResponseInner.md)
 - [Model.GetCurrencyFees200Response](docs/GetCurrencyFees200Response.md)
 - [Model.GetLootboxManagers200ResponseInner](docs/GetLootboxManagers200ResponseInner.md)
 - [Model.GetPlayerData200Response](docs/GetPlayerData200Response.md)
 - [Model.GetShops200ResponseInner](docs/GetShops200ResponseInner.md)
 - [Model.GrantCollectionRoleRequest](docs/GrantCollectionRoleRequest.md)
 - [Model.GrantCurrencyRoleRequest](docs/GrantCurrencyRoleRequest.md)
 - [Model.LootboxManagerLootbox](docs/LootboxManagerLootbox.md)
 - [Model.LootboxManagerModel](docs/LootboxManagerModel.md)
 - [Model.MintCollectionItemRequest](docs/MintCollectionItemRequest.md)
 - [Model.MintCurrencyRequest](docs/MintCurrencyRequest.md)
 - [Model.PlayerModel](docs/PlayerModel.md)
 - [Model.PublicGame](docs/PublicGame.md)
 - [Model.PublicPlayer](docs/PublicPlayer.md)
 - [Model.PublicPlayerWallet](docs/PublicPlayerWallet.md)
 - [Model.RemovePlayerConnectedWalletRequest](docs/RemovePlayerConnectedWalletRequest.md)
 - [Model.RevokeCollectionRoleRequest](docs/RevokeCollectionRoleRequest.md)
 - [Model.SetCollectionApprovalRequest](docs/SetCollectionApprovalRequest.md)
 - [Model.SetCollectionItemTimelockRequest](docs/SetCollectionItemTimelockRequest.md)
 - [Model.SetCurrencyFeesRequest](docs/SetCurrencyFeesRequest.md)
 - [Model.SetLootboxManagerLootboxRequest](docs/SetLootboxManagerLootboxRequest.md)
 - [Model.SetPlayerConnectedWallet200Response](docs/SetPlayerConnectedWallet200Response.md)
 - [Model.SetPlayerConnectedWalletRequest](docs/SetPlayerConnectedWalletRequest.md)
 - [Model.SetPlayerDataRequest](docs/SetPlayerDataRequest.md)
 - [Model.SetShopOfferRequest](docs/SetShopOfferRequest.md)
 - [Model.ShopModel](docs/ShopModel.md)
 - [Model.ShopOffer](docs/ShopOffer.md)
 - [Model.TransactionModel](docs/TransactionModel.md)
 - [Model.TransferCollectionItemRequest](docs/TransferCollectionItemRequest.md)
 - [Model.TransferContractOwnershipRequest](docs/TransferContractOwnershipRequest.md)
 - [Model.TransferCurrencyRequest](docs/TransferCurrencyRequest.md)
 - [Model.UpdateGameRequest](docs/UpdateGameRequest.md)
 - [Model.UpdatePlayerRequest](docs/UpdatePlayerRequest.md)
 - [Model.UpgradeContractTrustedForwarderRequest](docs/UpgradeContractTrustedForwarderRequest.md)
 - [Model.WalletModel](docs/WalletModel.md)
 - [Model.WithdrawFromShopRequest](docs/WithdrawFromShopRequest.md)
 - [Model.WriteContractRequest](docs/WriteContractRequest.md)
 - [Model.WriteContractRequestArgsInner](docs/WriteContractRequestArgsInner.md)


## Documentation for Authorization


### basicAuth


- **Type**: HTTP basic authentication

