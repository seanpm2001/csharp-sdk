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
    ///  Class for testing AttachmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AttachmentsApiTests
    {
        private AttachmentsApi instance;
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
            instance = client.Attachments;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AttachmentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AttachmentsApi
            //Assert.IsInstanceOfType(typeof(AttachmentsApi), instance, "instance is a AttachmentsApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //List<string> includes = null;
            //var response = instance.Create(file, includes);
            //Assert.IsInstanceOf<AttachmentResponse> (response, "response is AttachmentResponse");
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
            //Assert.IsInstanceOf<AttachmentResponse> (response, "response is AttachmentResponse");
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
            //List<int?> note = null;
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, sort, suggestion, note, includes);
            //Assert.IsInstanceOf<AttachmentResponsePaginated> (response, "response is AttachmentResponsePaginated");
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
            //Assert.IsInstanceOf<AttachmentResponse> (response, "response is AttachmentResponse");
        }
        
    }

}
