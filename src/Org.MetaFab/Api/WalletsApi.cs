/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: metafabproject@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Org.MetaFab.Client;
using Org.MetaFab.Model;

namespace Org.MetaFab.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWalletsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get wallet balances
        /// </summary>
        /// <remarks>
        /// Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>Dictionary<string, decimal></returns>
        Dictionary<string, decimal> GetWalletBalances (string walletId);

        /// <summary>
        /// Get wallet balances
        /// </summary>
        /// <remarks>
        /// Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>ApiResponse of Dictionary<string, decimal></returns>
        ApiResponse<Dictionary<string, decimal>> GetWalletBalancesWithHttpInfo (string walletId);
        /// <summary>
        /// Get wallet transactions
        /// </summary>
        /// <remarks>
        /// Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>List<TransactionModel></returns>
        List<TransactionModel> GetWalletTransactions (string walletId);

        /// <summary>
        /// Get wallet transactions
        /// </summary>
        /// <remarks>
        /// Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>ApiResponse of List<TransactionModel></returns>
        ApiResponse<List<TransactionModel>> GetWalletTransactionsWithHttpInfo (string walletId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get wallet balances
        /// </summary>
        /// <remarks>
        /// Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Dictionary<string, decimal></returns>
        System.Threading.Tasks.Task<Dictionary<string, decimal>> GetWalletBalancesAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get wallet balances
        /// </summary>
        /// <remarks>
        /// Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, decimal&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, decimal>>> GetWalletBalancesWithHttpInfoAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get wallet transactions
        /// </summary>
        /// <remarks>
        /// Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<TransactionModel></returns>
        System.Threading.Tasks.Task<List<TransactionModel>> GetWalletTransactionsAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get wallet transactions
        /// </summary>
        /// <remarks>
        /// Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;TransactionModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransactionModel>>> GetWalletTransactionsWithHttpInfoAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WalletsApi : IWalletsApi
    {
        private Org.MetaFab.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WalletsApi(String basePath)
        {
            this.Configuration = new Org.MetaFab.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.MetaFab.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsApi"/> class
        /// </summary>
        /// <returns></returns>
        public WalletsApi()
        {
            this.Configuration = Org.MetaFab.Client.Configuration.Default;

            ExceptionFactory = Org.MetaFab.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WalletsApi(Org.MetaFab.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.MetaFab.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.MetaFab.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.MetaFab.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.MetaFab.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get wallet balances Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>Dictionary<string, decimal></returns>
        public Dictionary<string, decimal> GetWalletBalances (string walletId)
        {
             ApiResponse<Dictionary<string, decimal>> localVarResponse = GetWalletBalancesWithHttpInfo(walletId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get wallet balances Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>ApiResponse of Dictionary<string, decimal></returns>
        public ApiResponse<Dictionary<string, decimal>> GetWalletBalancesWithHttpInfo (string walletId)
        {
            // verify the required parameter 'walletId' is set
            if (walletId == null)
                throw new ApiException(400, "Missing required parameter 'walletId' when calling WalletsApi->GetWalletBalances");

            var localVarPath = "/v1/wallets/{walletId}/balances";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (walletId != null) localVarPathParams.Add("walletId", this.Configuration.ApiClient.ParameterToString(walletId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWalletBalances", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, decimal>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, decimal>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, decimal>)));
        }

        /// <summary>
        /// Get wallet balances Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Dictionary<string, decimal></returns>
        public async System.Threading.Tasks.Task<Dictionary<string, decimal>> GetWalletBalancesAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Dictionary<string, decimal>> localVarResponse = await GetWalletBalancesWithHttpInfoAsync(walletId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get wallet balances Returns the current native token balance for all chains supported by MetaFab for the provided walletId. This includes balances like Eth, Matic and other native tokens from chains MetaFab supports.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, decimal&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, decimal>>> GetWalletBalancesWithHttpInfoAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'walletId' is set
            if (walletId == null)
                throw new ApiException(400, "Missing required parameter 'walletId' when calling WalletsApi->GetWalletBalances");

            var localVarPath = "/v1/wallets/{walletId}/balances";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (walletId != null) localVarPathParams.Add("walletId", this.Configuration.ApiClient.ParameterToString(walletId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWalletBalances", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Dictionary<string, decimal>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Dictionary<string, decimal>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, decimal>)));
        }

        /// <summary>
        /// Get wallet transactions Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>List<TransactionModel></returns>
        public List<TransactionModel> GetWalletTransactions (string walletId)
        {
             ApiResponse<List<TransactionModel>> localVarResponse = GetWalletTransactionsWithHttpInfo(walletId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get wallet transactions Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <returns>ApiResponse of List<TransactionModel></returns>
        public ApiResponse<List<TransactionModel>> GetWalletTransactionsWithHttpInfo (string walletId)
        {
            // verify the required parameter 'walletId' is set
            if (walletId == null)
                throw new ApiException(400, "Missing required parameter 'walletId' when calling WalletsApi->GetWalletTransactions");

            var localVarPath = "/v1/wallets/{walletId}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (walletId != null) localVarPathParams.Add("walletId", this.Configuration.ApiClient.ParameterToString(walletId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWalletTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<TransactionModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TransactionModel>)));
        }

        /// <summary>
        /// Get wallet transactions Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List<TransactionModel></returns>
        public async System.Threading.Tasks.Task<List<TransactionModel>> GetWalletTransactionsAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<TransactionModel>> localVarResponse = await GetWalletTransactionsWithHttpInfoAsync(walletId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get wallet transactions Returns an array of MetaFab initiated transactions performed by the provided walletId. Transactions returned are ordered chronologically from newest to oldest.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="walletId">Any wallet id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;TransactionModel&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransactionModel>>> GetWalletTransactionsWithHttpInfoAsync (string walletId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'walletId' is set
            if (walletId == null)
                throw new ApiException(400, "Missing required parameter 'walletId' when calling WalletsApi->GetWalletTransactions");

            var localVarPath = "/v1/wallets/{walletId}/transactions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (walletId != null) localVarPathParams.Add("walletId", this.Configuration.ApiClient.ParameterToString(walletId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWalletTransactions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<TransactionModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<TransactionModel>)));
        }

    }
}
