
# Org.MetaFab.Model.ProfilePermissionsValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chain** | **string** | The target chain for the contract and related permissions. | [optional] 
**Scopes** | **List&lt;string&gt;** | An optional array of valid permissioning scopes. | [optional] 
**Functions** | **List&lt;string&gt;** | An optional array of contract functions to request permission for. | [optional] 
**Erc20Limit** | **int** | A maximum lifetime limit of erc20 that can be tranferred for this contract address. | [optional] 
**Erc1155Limits** | **Dictionary&lt;string, int&gt;** | An object mapping erc1155 ids to maximum lifetime transfer limits of each permitted item id supplied for this contract address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

