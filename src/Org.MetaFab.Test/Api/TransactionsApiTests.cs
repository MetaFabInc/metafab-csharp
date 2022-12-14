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
    ///  Class for testing TransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransactionsApiTests
    {
        private TransactionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransactionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TransactionsApi
            //Assert.IsInstanceOf(typeof(TransactionsApi), instance);
        }

        
        /// <summary>
        /// Test GetTransaction
        /// </summary>
        [Test]
        public void GetTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string transactionId = null;
            //var response = instance.GetTransaction(transactionId);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
    }

}
