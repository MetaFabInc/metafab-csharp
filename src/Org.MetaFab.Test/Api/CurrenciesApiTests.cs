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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.MetaFab.Client;
using Org.MetaFab.Api;
using Org.MetaFab.Model;

namespace Org.MetaFab.Test
{
    /// <summary>
    ///  Class for testing CurrenciesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CurrenciesApiTests
    {
        private CurrenciesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CurrenciesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CurrenciesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CurrenciesApi
            //Assert.IsInstanceOf(typeof(CurrenciesApi), instance);
        }

        
        /// <summary>
        /// Test BatchTransferCurrency
        /// </summary>
        [Test]
        public void BatchTransferCurrencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //BatchTransferCurrencyRequest batchTransferCurrencyRequest = null;
            //var response = instance.BatchTransferCurrency(currencyId, xAuthorization, xPassword, batchTransferCurrencyRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test BurnCurrency
        /// </summary>
        [Test]
        public void BurnCurrencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //BurnCurrencyRequest burnCurrencyRequest = null;
            //var response = instance.BurnCurrency(currencyId, xAuthorization, xPassword, burnCurrencyRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test CreateCurrency
        /// </summary>
        [Test]
        public void CreateCurrencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAuthorization = null;
            //string xPassword = null;
            //CreateCurrencyRequest createCurrencyRequest = null;
            //var response = instance.CreateCurrency(xAuthorization, xPassword, createCurrencyRequest);
            //Assert.IsInstanceOf(typeof(CreateCurrency200Response), response, "response is CreateCurrency200Response");
        }
        
        /// <summary>
        /// Test GetCurrencies
        /// </summary>
        [Test]
        public void GetCurrenciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xGameKey = null;
            //var response = instance.GetCurrencies(xGameKey);
            //Assert.IsInstanceOf(typeof(List<GetCurrencies200ResponseInner>), response, "response is List<GetCurrencies200ResponseInner>");
        }
        
        /// <summary>
        /// Test GetCurrencyBalance
        /// </summary>
        [Test]
        public void GetCurrencyBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string address = null;
            //string walletId = null;
            //var response = instance.GetCurrencyBalance(currencyId, address, walletId);
            //Assert.IsInstanceOf(typeof(decimal), response, "response is decimal");
        }
        
        /// <summary>
        /// Test GetCurrencyFees
        /// </summary>
        [Test]
        public void GetCurrencyFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //var response = instance.GetCurrencyFees(currencyId);
            //Assert.IsInstanceOf(typeof(GetCurrencyFees200Response), response, "response is GetCurrencyFees200Response");
        }
        
        /// <summary>
        /// Test GetCurrencyRole
        /// </summary>
        [Test]
        public void GetCurrencyRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string role = null;
            //string address = null;
            //string walletId = null;
            //var response = instance.GetCurrencyRole(currencyId, role, address, walletId);
            //Assert.IsInstanceOf(typeof(bool), response, "response is bool");
        }
        
        /// <summary>
        /// Test GrantCurrencyRole
        /// </summary>
        [Test]
        public void GrantCurrencyRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //GrantCurrencyRoleRequest grantCurrencyRoleRequest = null;
            //var response = instance.GrantCurrencyRole(currencyId, xAuthorization, xPassword, grantCurrencyRoleRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test MintCurrency
        /// </summary>
        [Test]
        public void MintCurrencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //MintCurrencyRequest mintCurrencyRequest = null;
            //var response = instance.MintCurrency(currencyId, xAuthorization, xPassword, mintCurrencyRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test RevokeCurrencyRole
        /// </summary>
        [Test]
        public void RevokeCurrencyRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //RevokeCollectionRoleRequest revokeCollectionRoleRequest = null;
            //var response = instance.RevokeCurrencyRole(currencyId, xAuthorization, xPassword, revokeCollectionRoleRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test SetCurrencyFees
        /// </summary>
        [Test]
        public void SetCurrencyFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //SetCurrencyFeesRequest setCurrencyFeesRequest = null;
            //var response = instance.SetCurrencyFees(currencyId, xAuthorization, xPassword, setCurrencyFeesRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test TransferCurrency
        /// </summary>
        [Test]
        public void TransferCurrencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currencyId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //TransferCurrencyRequest transferCurrencyRequest = null;
            //var response = instance.TransferCurrency(currencyId, xAuthorization, xPassword, transferCurrencyRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
    }

}
