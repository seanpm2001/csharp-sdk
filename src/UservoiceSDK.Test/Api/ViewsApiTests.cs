/* 
 * UserVoice API
 *
 * A RESTful API to interface with UserVoice's feedback system. Online documentation available here: https://developer.uservoice.com/docs/api/v2/reference/.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using UserVoiceSdk.Client;
using UserVoiceSdk.Api;
using UserVoiceSdk.Models;

namespace UserVoiceSdk.Test
{
    /// <summary>
    ///  Class for testing ViewsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ViewsApiTests
    {
        private ViewsApi instance;
        private ApiClient client;
        private string subdomain = ""; // TODO
        private string clientId = ""; // TODO
        private string clientSecret = ""; // TODO

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            client = new ApiClient(subdomain, clientId, clientSecret: clientSecret);
            instance = client.Views;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ViewsApi
            //Assert.IsInstanceOfType(typeof(ViewsApi), instance, "instance is a ViewsApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string kind = null;
            //string name = null;
            //string subKind = null;
            //string _params = null;
            //bool? subscribed = null;
            //string subscriptionParams = null;
            //long? linksSuggestion = null;
            //long? linksSmartvoteExperiment = null;
            //long? linksUser = null;
            //List<string> includes = null;
            //var response = instance.Create(kind, name, subKind, _params, subscribed, subscriptionParams, linksSuggestion, linksSmartvoteExperiment, linksUser, includes);
            //Assert.IsInstanceOf<ViewResponse> (response, "response is ViewResponse");
        }
        
        /// <summary>
        /// Test DeleteById
        /// </summary>
        [Test]
        public void DeleteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.DeleteById(id, includes);
            //Assert.IsInstanceOf<ViewResponse> (response, "response is ViewResponse");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? user = null;
            //long? page = null;
            //long? perPage = null;
            //List<string> kind = null;
            //string sort = null;
            //List<string> includes = null;
            //var response = instance.Get(user, page, perPage, kind, sort, includes);
            //Assert.IsInstanceOf<ViewResponsePaginated> (response, "response is ViewResponsePaginated");
        }
        
        /// <summary>
        /// Test GetById
        /// </summary>
        [Test]
        public void GetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> id = null;
            //List<string> includes = null;
            //var response = instance.GetById(id, includes);
            //Assert.IsInstanceOf<ViewResponse> (response, "response is ViewResponse");
        }
        
        /// <summary>
        /// Test UpdateById
        /// </summary>
        [Test]
        public void UpdateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string name = null;
            //bool? subscribed = null;
            //string subscriptionParams = null;
            //string _params = null;
            //long? position = null;
            //List<string> includes = null;
            //var response = instance.UpdateById(id, name, subscribed, subscriptionParams, _params, position, includes);
            //Assert.IsInstanceOf<ViewResponse> (response, "response is ViewResponse");
        }
        
    }

}
