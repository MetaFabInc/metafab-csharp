# Org.MetaFab.Api.WalletsApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWalletBalances**](WalletsApi.md#getwalletbalances) | **GET** /v1/wallets/{walletId}/balances | Get wallet balances
[**GetWalletTransactions**](WalletsApi.md#getwallettransactions) | **GET** /v1/wallets/{walletId}/transactions | Get wallet transactions



## GetWalletBalances

> Dictionary&lt;string, decimal&gt; GetWalletBalances (string walletId)

Get wallet balances

Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetWalletBalancesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new WalletsApi(Configuration.Default);
            var walletId = "walletId_example";  // string | Any wallet id within the MetaFab ecosystem.

            try
            {
                // Get wallet balances
                Dictionary<string, decimal> result = apiInstance.GetWalletBalances(walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.GetWalletBalances: " + e.Message );
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
 **walletId** | **string**| Any wallet id within the MetaFab ecosystem. | 

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
| **200** | Successfully retrieved native token balances of the provided walletId&#39;s address for each chain supported by MetaFab. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetWalletTransactions

> List&lt;TransactionModel&gt; GetWalletTransactions (string walletId)

Get wallet transactions

Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetWalletTransactionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new WalletsApi(Configuration.Default);
            var walletId = "walletId_example";  // string | Any wallet id within the MetaFab ecosystem.

            try
            {
                // Get wallet transactions
                List<TransactionModel> result = apiInstance.GetWalletTransactions(walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WalletsApi.GetWalletTransactions: " + e.Message );
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
 **walletId** | **string**| Any wallet id within the MetaFab ecosystem. | 

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
| **200** | Successfully retrieved an array of transactions performed by the provided walletId. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

