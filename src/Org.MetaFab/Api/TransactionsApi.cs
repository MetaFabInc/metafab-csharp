/*
 * MetaFab API
 *
 *  Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.0.0
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
    public interface ITransactionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get transaction
        /// </summary>
        /// <remarks>
        /// Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <returns>TransactionModel</returns>
        TransactionModel GetTransaction (string transactionId);

        /// <summary>
        /// Get transaction
        /// </summary>
        /// <remarks>
        /// Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <returns>ApiResponse of TransactionModel</returns>
        ApiResponse<TransactionModel> GetTransactionWithHttpInfo (string transactionId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get transaction
        /// </summary>
        /// <remarks>
        /// Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TransactionModel</returns>
        System.Threading.Tasks.Task<TransactionModel> GetTransactionAsync (string transactionId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get transaction
        /// </summary>
        /// <remarks>
        /// Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </remarks>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TransactionModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionModel>> GetTransactionWithHttpInfoAsync (string transactionId, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionsApi : ITransactionsApi
    {
        private Org.MetaFab.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
        {
            this.Configuration = new Org.MetaFab.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.MetaFab.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class
        /// </summary>
        /// <returns></returns>
        public TransactionsApi()
        {
            this.Configuration = Org.MetaFab.Client.Configuration.Default;

            ExceptionFactory = Org.MetaFab.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionsApi(Org.MetaFab.Client.Configuration configuration = null)
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
        /// Get transaction Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <returns>TransactionModel</returns>
        public TransactionModel GetTransaction (string transactionId)
        {
             ApiResponse<TransactionModel> localVarResponse = GetTransactionWithHttpInfo(transactionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get transaction Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <returns>ApiResponse of TransactionModel</returns>
        public ApiResponse<TransactionModel> GetTransactionWithHttpInfo (string transactionId)
        {
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionsApi->GetTransaction");

            var localVarPath = "/v1/transactions/{transactionId}";
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

            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TransactionModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionModel)));
        }

        /// <summary>
        /// Get transaction Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of TransactionModel</returns>
        public async System.Threading.Tasks.Task<TransactionModel> GetTransactionAsync (string transactionId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<TransactionModel> localVarResponse = await GetTransactionWithHttpInfoAsync(transactionId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get transaction Returns an executed transaction object for the provided transactionId. Transactions are created by MetaFab when interacting with contracts, currencies, items and other MetaFab resources.
        /// </summary>
        /// <exception cref="Org.MetaFab.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="transactionId">Any transaction id within the MetaFab ecosystem.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (TransactionModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionModel>> GetTransactionWithHttpInfoAsync (string transactionId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'transactionId' is set
            if (transactionId == null)
                throw new ApiException(400, "Missing required parameter 'transactionId' when calling TransactionsApi->GetTransaction");

            var localVarPath = "/v1/transactions/{transactionId}";
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

            if (transactionId != null) localVarPathParams.Add("transactionId", this.Configuration.ApiClient.ParameterToString(transactionId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (TransactionModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TransactionModel)));
        }

    }
}
