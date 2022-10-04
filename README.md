# Org.MetaFab - the C# library for the MetaFab API

 Complete MetaFab API references and guides can be found at: https://trymetafab.com

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
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
*ContractsApi* | [**WriteContract**](docs/ContractsApi.md#writecontract) | **POST** /v1/contracts/{contractId}/writes | Write contract data
*CurrenciesApi* | [**BatchTransferCurrency**](docs/CurrenciesApi.md#batchtransfercurrency) | **POST** /v1/currencies/{currencyId}/batchTransfers | Batch transfer currency
*CurrenciesApi* | [**BurnCurrency**](docs/CurrenciesApi.md#burncurrency) | **POST** /v1/currencies/{currencyId}/burns | Burn currency
*CurrenciesApi* | [**CreateCurrency**](docs/CurrenciesApi.md#createcurrency) | **POST** /v1/currencies | Create currency
*CurrenciesApi* | [**GetCurrencies**](docs/CurrenciesApi.md#getcurrencies) | **GET** /v1/currencies | Get currencies
*CurrenciesApi* | [**GetCurrencyBalances**](docs/CurrenciesApi.md#getcurrencybalances) | **GET** /v1/currencies/{currencyId}/balances | Get currency balance
*CurrenciesApi* | [**GetCurrencyFees**](docs/CurrenciesApi.md#getcurrencyfees) | **GET** /v1/currencies/{currencyId}/fees | Get currency fees
*CurrenciesApi* | [**MintCurrency**](docs/CurrenciesApi.md#mintcurrency) | **POST** /v1/currencies/{currencyId}/mints | Mint currency
*CurrenciesApi* | [**SetCurrencyFees**](docs/CurrenciesApi.md#setcurrencyfees) | **POST** /v1/currencies/{currencyId}/fees | Set currency fees
*CurrenciesApi* | [**TransferCurrency**](docs/CurrenciesApi.md#transfercurrency) | **POST** /v1/currencies/{currencyId}/transfers | Transfer currency
*GamesApi* | [**AuthGame**](docs/GamesApi.md#authgame) | **GET** /v1/games | Authenticate game
*GamesApi* | [**CreateGame**](docs/GamesApi.md#creategame) | **POST** /v1/games | Create game
*GamesApi* | [**UpdateGame**](docs/GamesApi.md#updategame) | **PATCH** /v1/games/{gameId} | Update game
*PlayersApi* | [**AuthPlayer**](docs/PlayersApi.md#authplayer) | **GET** /v1/players | Authenticate player
*PlayersApi* | [**CreatePlayer**](docs/PlayersApi.md#createplayer) | **POST** /v1/players | Create player
*PlayersApi* | [**UpdatePlayer**](docs/PlayersApi.md#updateplayer) | **PATCH** /v1/players/{playerId} | Update player
*TransactionsApi* | [**GetTransaction**](docs/TransactionsApi.md#gettransaction) | **GET** /v1/transactions/{transactionId} | Get transaction
*WalletsApi* | [**GetWalletBalances**](docs/WalletsApi.md#getwalletbalances) | **GET** /v1/wallets/{walletId}/balances | Get wallet balances
*WalletsApi* | [**GetWalletTransactions**](docs/WalletsApi.md#getwallettransactions) | **GET** /v1/wallets/{walletId}/transactions | Get wallet transactions


## Documentation for Models

 - [Model.AuthGame200Response](docs/AuthGame200Response.md)
 - [Model.AuthGame200ResponseAllOf](docs/AuthGame200ResponseAllOf.md)
 - [Model.AuthGame200ResponseAllOf1](docs/AuthGame200ResponseAllOf1.md)
 - [Model.AuthPlayer200Response](docs/AuthPlayer200Response.md)
 - [Model.BatchTransferCurrencyRequest](docs/BatchTransferCurrencyRequest.md)
 - [Model.BurnCurrencyRequest](docs/BurnCurrencyRequest.md)
 - [Model.ContractModel](docs/ContractModel.md)
 - [Model.CreateContractRequest](docs/CreateContractRequest.md)
 - [Model.CreateCurrency200Response](docs/CreateCurrency200Response.md)
 - [Model.CreateCurrency200ResponseAllOf](docs/CreateCurrency200ResponseAllOf.md)
 - [Model.CreateCurrency200ResponseAllOfContract](docs/CreateCurrency200ResponseAllOfContract.md)
 - [Model.CreateCurrency200ResponseAllOfContractAllOf](docs/CreateCurrency200ResponseAllOfContractAllOf.md)
 - [Model.CreateCurrencyRequest](docs/CreateCurrencyRequest.md)
 - [Model.CreateGameRequest](docs/CreateGameRequest.md)
 - [Model.CreatePlayerRequest](docs/CreatePlayerRequest.md)
 - [Model.CurrencyModel](docs/CurrencyModel.md)
 - [Model.GameModel](docs/GameModel.md)
 - [Model.GetCurrencies200ResponseInner](docs/GetCurrencies200ResponseInner.md)
 - [Model.GetCurrencies200ResponseInnerAllOf](docs/GetCurrencies200ResponseInnerAllOf.md)
 - [Model.GetCurrencyFees200Response](docs/GetCurrencyFees200Response.md)
 - [Model.MintCurrencyRequest](docs/MintCurrencyRequest.md)
 - [Model.PlayerModel](docs/PlayerModel.md)
 - [Model.SetCurrencyFeesRequest](docs/SetCurrencyFeesRequest.md)
 - [Model.TransactionModel](docs/TransactionModel.md)
 - [Model.TransferCurrencyRequest](docs/TransferCurrencyRequest.md)
 - [Model.UpdateGameRequest](docs/UpdateGameRequest.md)
 - [Model.UpdatePlayerRequest](docs/UpdatePlayerRequest.md)
 - [Model.WalletModel](docs/WalletModel.md)
 - [Model.WriteContractRequest](docs/WriteContractRequest.md)


## Documentation for Authorization


### basicAuth


- **Type**: HTTP basic authentication

