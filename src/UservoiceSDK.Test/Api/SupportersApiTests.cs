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
    ///  Class for testing SupportersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SupportersApiTests
    {
        private SupportersApi instance;
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
            instance = client.Supporters;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SupportersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SupportersApi
            //Assert.IsInstanceOfType(typeof(SupportersApi), instance, "instance is a SupportersApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //long? perPage = null;
            //string sort = null;
            //List<int?> suggestion = null;
            //List<int?> user = null;
            //bool? legit = null;
            //List<int?> forum = null;
            //DateTime? periodStart = null;
            //DateTime? periodEnd = null;
            //bool? anonymous = null;
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, sort, suggestion, user, legit, forum, periodStart, periodEnd, anonymous, includes);
            //Assert.IsInstanceOf<SupporterResponsePaginated> (response, "response is SupporterResponsePaginated");
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
            //Assert.IsInstanceOf<SupporterResponse> (response, "response is SupporterResponse");
        }
        
    }

}
