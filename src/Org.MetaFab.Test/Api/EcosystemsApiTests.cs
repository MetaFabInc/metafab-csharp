/*
 * MetaFab API
 *
 * Complete MetaFab API references and guides can be found at: https://trymetafab.com
 *
 * The version of the OpenAPI document: 1.5.0
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
    ///  Class for testing EcosystemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EcosystemsApiTests
    {
        private EcosystemsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EcosystemsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EcosystemsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' EcosystemsApi
            //Assert.IsInstanceOf(typeof(EcosystemsApi), instance);
        }

        
        /// <summary>
        /// Test ApproveEcosystemGame
        /// </summary>
        [Test]
        public void ApproveEcosystemGameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ecosystemId = null;
            //string xAuthorization = null;
            //ApproveEcosystemGameRequest approveEcosystemGameRequest = null;
            //instance.ApproveEcosystemGame(ecosystemId, xAuthorization, approveEcosystemGameRequest);
            
        }
        
        /// <summary>
        /// Test AuthEcosystem
        /// </summary>
        [Test]
        public void AuthEcosystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AuthEcosystem();
            //Assert.IsInstanceOf(typeof(EcosystemModel), response, "response is EcosystemModel");
        }
        
        /// <summary>
        /// Test AuthProfile
        /// </summary>
        [Test]
        public void AuthProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xEcosystemKey = null;
            //var response = instance.AuthProfile(xEcosystemKey);
            //Assert.IsInstanceOf(typeof(AuthProfile200Response), response, "response is AuthProfile200Response");
        }
        
        /// <summary>
        /// Test AuthProfilePlayer
        /// </summary>
        [Test]
        public void AuthProfilePlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string gameId = null;
            //string xAuthorization = null;
            //string xWalletDecryptKey = null;
            //string xUsername = null;
            //var response = instance.AuthProfilePlayer(profileId, gameId, xAuthorization, xWalletDecryptKey, xUsername);
            //Assert.IsInstanceOf(typeof(AuthPlayer200Response), response, "response is AuthPlayer200Response");
        }
        
        /// <summary>
        /// Test CreateEcosystem
        /// </summary>
        [Test]
        public void CreateEcosystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateEcosystemRequest createEcosystemRequest = null;
            //var response = instance.CreateEcosystem(createEcosystemRequest);
            //Assert.IsInstanceOf(typeof(EcosystemModel), response, "response is EcosystemModel");
        }
        
        /// <summary>
        /// Test CreateProfile
        /// </summary>
        [Test]
        public void CreateProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xEcosystemKey = null;
            //CreateProfileRequest createProfileRequest = null;
            //var response = instance.CreateProfile(xEcosystemKey, createProfileRequest);
            //Assert.IsInstanceOf(typeof(AuthProfile200Response), response, "response is AuthProfile200Response");
        }
        
        /// <summary>
        /// Test CreateProfilePlayer
        /// </summary>
        [Test]
        public void CreateProfilePlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string gameId = null;
            //string xAuthorization = null;
            //string xWalletDecryptKey = null;
            //CreateProfilePlayerRequest createProfilePlayerRequest = null;
            //var response = instance.CreateProfilePlayer(profileId, gameId, xAuthorization, xWalletDecryptKey, createProfilePlayerRequest);
            //Assert.IsInstanceOf(typeof(AuthPlayer200Response), response, "response is AuthPlayer200Response");
        }
        
        /// <summary>
        /// Test GetEcosystem
        /// </summary>
        [Test]
        public void GetEcosystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ecosystemId = null;
            //var response = instance.GetEcosystem(ecosystemId);
            //Assert.IsInstanceOf(typeof(PublicEcosystem), response, "response is PublicEcosystem");
        }
        
        /// <summary>
        /// Test GetEcosystemGame
        /// </summary>
        [Test]
        public void GetEcosystemGameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ecosystemId = null;
            //string gameId = null;
            //var response = instance.GetEcosystemGame(ecosystemId, gameId);
            //Assert.IsInstanceOf(typeof(PublicGame), response, "response is PublicGame");
        }
        
        /// <summary>
        /// Test GetEcosystemGames
        /// </summary>
        [Test]
        public void GetEcosystemGamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ecosystemId = null;
            //var response = instance.GetEcosystemGames(ecosystemId);
            //Assert.IsInstanceOf(typeof(List<PublicGame>), response, "response is List<PublicGame>");
        }
        
        /// <summary>
        /// Test GetProfileGame
        /// </summary>
        [Test]
        public void GetProfileGameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string gameId = null;
            //string xAuthorization = null;
            //var response = instance.GetProfileGame(profileId, gameId, xAuthorization);
            //Assert.IsInstanceOf(typeof(GetProfileGames200ResponseInner), response, "response is GetProfileGames200ResponseInner");
        }
        
        /// <summary>
        /// Test GetProfileGames
        /// </summary>
        [Test]
        public void GetProfileGamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string xAuthorization = null;
            //var response = instance.GetProfileGames(profileId, xAuthorization);
            //Assert.IsInstanceOf(typeof(List<GetProfileGames200ResponseInner>), response, "response is List<GetProfileGames200ResponseInner>");
        }
        
        /// <summary>
        /// Test UnapproveEcosystemGame
        /// </summary>
        [Test]
        public void UnapproveEcosystemGameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ecosystemId = null;
            //string gameId = null;
            //string xAuthorization = null;
            //instance.UnapproveEcosystemGame(ecosystemId, gameId, xAuthorization);
            
        }
        
        /// <summary>
        /// Test UpdateEcosystem
        /// </summary>
        [Test]
        public void UpdateEcosystemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ecosystemId = null;
            //string xAuthorization = null;
            //UpdateEcosystemRequest updateEcosystemRequest = null;
            //var response = instance.UpdateEcosystem(ecosystemId, xAuthorization, updateEcosystemRequest);
            //Assert.IsInstanceOf(typeof(EcosystemModel), response, "response is EcosystemModel");
        }
        
        /// <summary>
        /// Test UpdateProfile
        /// </summary>
        [Test]
        public void UpdateProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string xAuthorization = null;
            //UpdateProfileRequest updateProfileRequest = null;
            //var response = instance.UpdateProfile(profileId, xAuthorization, updateProfileRequest);
            //Assert.IsInstanceOf(typeof(ProfileModel), response, "response is ProfileModel");
        }
        
        /// <summary>
        /// Test UpdateProfilePlayer
        /// </summary>
        [Test]
        public void UpdateProfilePlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string profileId = null;
            //string gameId = null;
            //string playerId = null;
            //string xAuthorization = null;
            //string xWalletDecryptKey = null;
            //UpdateProfilePlayerRequest updateProfilePlayerRequest = null;
            //var response = instance.UpdateProfilePlayer(profileId, gameId, playerId, xAuthorization, xWalletDecryptKey, updateProfilePlayerRequest);
            //Assert.IsInstanceOf(typeof(UpdateProfilePlayer200Response), response, "response is UpdateProfilePlayer200Response");
        }
        
    }

}
