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
    ///  Class for testing ItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ItemsApiTests
    {
        private ItemsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ItemsApi
            //Assert.IsInstanceOf(typeof(ItemsApi), instance);
        }

        
        /// <summary>
        /// Test BatchMintCollectionItems
        /// </summary>
        [Test]
        public void BatchMintCollectionItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //BatchMintCollectionItemsRequest batchMintCollectionItemsRequest = null;
            //var response = instance.BatchMintCollectionItems(collectionId, xAuthorization, xPassword, batchMintCollectionItemsRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test BatchTransferCollectionItems
        /// </summary>
        [Test]
        public void BatchTransferCollectionItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //BatchTransferCollectionItemsRequest batchTransferCollectionItemsRequest = null;
            //var response = instance.BatchTransferCollectionItems(collectionId, xAuthorization, xPassword, batchTransferCollectionItemsRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test BurnCollectionItem
        /// </summary>
        [Test]
        public void BurnCollectionItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //BurnCollectionItemRequest burnCollectionItemRequest = null;
            //var response = instance.BurnCollectionItem(collectionId, collectionItemId, xAuthorization, xPassword, burnCollectionItemRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test CreateCollection
        /// </summary>
        [Test]
        public void CreateCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAuthorization = null;
            //string xPassword = null;
            //CreateCollectionRequest createCollectionRequest = null;
            //var response = instance.CreateCollection(xAuthorization, xPassword, createCollectionRequest);
            //Assert.IsInstanceOf(typeof(CreateCollection200Response), response, "response is CreateCollection200Response");
        }
        
        /// <summary>
        /// Test CreateCollectionItem
        /// </summary>
        [Test]
        public void CreateCollectionItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //CreateCollectionItemRequest createCollectionItemRequest = null;
            //var response = instance.CreateCollectionItem(collectionId, xAuthorization, xPassword, createCollectionItemRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test GetCollectionApproval
        /// </summary>
        [Test]
        public void GetCollectionApprovalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string operatorAddress = null;
            //string address = null;
            //string walletId = null;
            //var response = instance.GetCollectionApproval(collectionId, operatorAddress, address, walletId);
            //Assert.IsInstanceOf(typeof(decimal), response, "response is decimal");
        }
        
        /// <summary>
        /// Test GetCollectionItem
        /// </summary>
        [Test]
        public void GetCollectionItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //var response = instance.GetCollectionItem(collectionId, collectionItemId);
            //Assert.IsInstanceOf(typeof(List<Object>), response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetCollectionItemBalance
        /// </summary>
        [Test]
        public void GetCollectionItemBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //string address = null;
            //string walletId = null;
            //var response = instance.GetCollectionItemBalance(collectionId, collectionItemId, address, walletId);
            //Assert.IsInstanceOf(typeof(decimal), response, "response is decimal");
        }
        
        /// <summary>
        /// Test GetCollectionItemBalances
        /// </summary>
        [Test]
        public void GetCollectionItemBalancesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string address = null;
            //string walletId = null;
            //var response = instance.GetCollectionItemBalances(collectionId, address, walletId);
            //Assert.IsInstanceOf(typeof(Dictionary<string, decimal>), response, "response is Dictionary<string, decimal>");
        }
        
        /// <summary>
        /// Test GetCollectionItemSupplies
        /// </summary>
        [Test]
        public void GetCollectionItemSuppliesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.GetCollectionItemSupplies(collectionId);
            //Assert.IsInstanceOf(typeof(Dictionary<string, decimal>), response, "response is Dictionary<string, decimal>");
        }
        
        /// <summary>
        /// Test GetCollectionItemSupply
        /// </summary>
        [Test]
        public void GetCollectionItemSupplyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //string address = null;
            //string walletId = null;
            //var response = instance.GetCollectionItemSupply(collectionId, collectionItemId, address, walletId);
            //Assert.IsInstanceOf(typeof(decimal), response, "response is decimal");
        }
        
        /// <summary>
        /// Test GetCollectionItemTimelock
        /// </summary>
        [Test]
        public void GetCollectionItemTimelockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //var response = instance.GetCollectionItemTimelock(collectionId, collectionItemId);
            //Assert.IsInstanceOf(typeof(decimal), response, "response is decimal");
        }
        
        /// <summary>
        /// Test GetCollectionItems
        /// </summary>
        [Test]
        public void GetCollectionItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.GetCollectionItems(collectionId);
            //Assert.IsInstanceOf(typeof(List<Object>), response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test GetCollections
        /// </summary>
        [Test]
        public void GetCollectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xGameKey = null;
            //var response = instance.GetCollections(xGameKey);
            //Assert.IsInstanceOf(typeof(List<GetCollections200ResponseInner>), response, "response is List<GetCollections200ResponseInner>");
        }
        
        /// <summary>
        /// Test MintCollectionItem
        /// </summary>
        [Test]
        public void MintCollectionItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //MintCollectionItemRequest mintCollectionItemRequest = null;
            //var response = instance.MintCollectionItem(collectionId, collectionItemId, xAuthorization, xPassword, mintCollectionItemRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test SetCollectionApproval
        /// </summary>
        [Test]
        public void SetCollectionApprovalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //SetCollectionApprovalRequest setCollectionApprovalRequest = null;
            //var response = instance.SetCollectionApproval(collectionId, xAuthorization, xPassword, setCollectionApprovalRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test SetCollectionItemTimelock
        /// </summary>
        [Test]
        public void SetCollectionItemTimelockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //SetCollectionItemTimelockRequest setCollectionItemTimelockRequest = null;
            //var response = instance.SetCollectionItemTimelock(collectionId, collectionItemId, xAuthorization, xPassword, setCollectionItemTimelockRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
        /// <summary>
        /// Test TransferCollectionItem
        /// </summary>
        [Test]
        public void TransferCollectionItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //decimal collectionItemId = null;
            //string xAuthorization = null;
            //string xPassword = null;
            //TransferCollectionItemRequest transferCollectionItemRequest = null;
            //var response = instance.TransferCollectionItem(collectionId, collectionItemId, xAuthorization, xPassword, transferCollectionItemRequest);
            //Assert.IsInstanceOf(typeof(TransactionModel), response, "response is TransactionModel");
        }
        
    }

}