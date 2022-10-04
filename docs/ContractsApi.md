# Org.MetaFab.Api.ContractsApi

All URIs are relative to *https://api.trymetafab.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateContract**](ContractsApi.md#createcontract) | **POST** /v1/contracts | Create custom contract
[**GetContracts**](ContractsApi.md#getcontracts) | **GET** /v1/contracts | Get contracts
[**ReadContract**](ContractsApi.md#readcontract) | **GET** /v1/contracts/{contractId}/reads | Read contract data
[**WriteContract**](ContractsApi.md#writecontract) | **POST** /v1/contracts/{contractId}/writes | Write contract data



## CreateContract

> ContractModel CreateContract (string xAuthorization, CreateContractRequest createContractRequest)

Create custom contract

Create a MetaFab custom contract entry from an existing contract address and contract abi. This allows the game and players belonging to the authenticated game to interact with the contract's read and write functions through MetaFab's read and write contract endpoints.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class CreateContractExample
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

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of the authenticating game. | 
 **createContractRequest** | [**CreateContractRequest**](CreateContractRequest.md)|  | 

### Return type

[**ContractModel**](ContractModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created a MetaFab contract entry. Returns a contract object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetContracts

> List&lt;ContractModel&gt; GetContracts (string xGameKey)

Get contracts

Returns an array of active contracts deployed by the game associated with the provided `X-Game-Key`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class GetContractsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ContractsApi(Configuration.Default);
            var xGameKey = game_pk_4SOqpDi8pQdnQgfCOBW29qR8YmwOhxVPz5iHoMgUEJLDdPXgwLuHqZf8ewo2GajZ;  // string | The `publishedKey` of a specific game. This can be shared or included in game clients, websites, etc.

            try
            {
                // Get contracts
                List<ContractModel> result = apiInstance.GetContracts(xGameKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContractsApi.GetContracts: " + e.Message );
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

[**List&lt;ContractModel&gt;**](ContractModel.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved an array of contracts for the game associated with the provided &#x60;X-Game-Key&#x60;. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadContract

> Object ReadContract (string contractId, string func, string args = null)

Read contract data

Oftentimes you'll want to query and retrieve some data from a contract. This is incredibly easy to do for any contract deployed through MetaFab.  Using this endpoint, you can get the data returned by any readable function listed in a contracts ABI. This could be things like querying the totalSupply of a currency contract, the number of owners of an items contract, and more.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class ReadContractExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ContractsApi(Configuration.Default);
            var contractId = "contractId_example";  // string | Any contract id within the MetaFab ecosystem.
            var func = "func_example";  // string | A contract function name. This can be any valid function from the the ABI of the contract you are interacting with. For example, `balanceOf`.
            var args = 123,"Hello",false;  // string | A comma seperated list of basic data type arguments. This is optional and only necessary if the function being invoked requires arguments per the contract ABI. For example, `123,\"Hello\",false`. (optional) 

            try
            {
                // Read contract data
                Object result = apiInstance.ReadContract(contractId, func, args);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContractsApi.ReadContract: " + e.Message );
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
 **contractId** | **string**| Any contract id within the MetaFab ecosystem. | 
 **func** | **string**| A contract function name. This can be any valid function from the the ABI of the contract you are interacting with. For example, &#x60;balanceOf&#x60;. | 
 **args** | **string**| A comma seperated list of basic data type arguments. This is optional and only necessary if the function being invoked requires arguments per the contract ABI. For example, &#x60;123,\&quot;Hello\&quot;,false&#x60;. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved value returned by contract function. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## WriteContract

> TransactionModel WriteContract (string contractId, string xAuthorization, string xPassword, WriteContractRequest writeContractRequest)

Write contract data

MetaFab's convenience endpoints for contract interactions may not be flexible enough depending on your use case. For these situations, you can interact with contracts and create transactions directly.  Using this endpoint, you can execute a transaction for any writeable contract method as defined in the contract's ABI for the MetaFab contractId provided. Both Games and Player resources have authority to use this endpoint to execute transactions against any valid MetaFab contractId.  Additionally, MetaFab will automatically attempt to perform a gasless transaction for players interacting with a contract through this endpoint. Gasless transactions by players through this endpoint will only work if the target contract was deployed through MetaFab or supports MetaFab's ERC2771 trusted forwarder contract.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.MetaFab.Api;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Example
{
    public class WriteContractExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.trymetafab.com";
            var apiInstance = new ContractsApi(Configuration.Default);
            var contractId = "contractId_example";  // string | Any contract id within the MetaFab ecosystem.
            var xAuthorization = ["game_sk_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP","player_at_02z4Mv3c85Ig0gNowY9Dq0N2kjb1xwzr27ArLE0669RrRI6dLf822iPO26K1p1FP"];  // string | The `secretKey` of a specific game or the `accessToken` of a specific player.
            var xPassword = mySecurePassword;  // string | The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet.
            var writeContractRequest = new WriteContractRequest(); // WriteContractRequest | 

            try
            {
                // Write contract data
                TransactionModel result = apiInstance.WriteContract(contractId, xAuthorization, xPassword, writeContractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContractsApi.WriteContract: " + e.Message );
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
 **contractId** | **string**| Any contract id within the MetaFab ecosystem. | 
 **xAuthorization** | **string**| The &#x60;secretKey&#x60; of a specific game or the &#x60;accessToken&#x60; of a specific player. | 
 **xPassword** | **string**| The password of the authenticating game or player. Required to decrypt and perform blockchain transactions with the game or player primary wallet. | 
 **writeContractRequest** | [**WriteContractRequest**](WriteContractRequest.md)|  | 

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
| **200** | Successfully executed and confirmed the transaction. Returns a transaction object. |  -  |
| **400** | An API level error occurred. This is often due to problematic data being provided by you. |  -  |
| **401** | An authorization error occured. This is often due to incorrect tokens or keys being provided, or accessing a resource that the provided tokens or keys do not have access to. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

