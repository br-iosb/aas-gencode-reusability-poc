/* 
 * DotAAS Part 2 | HTTP/REST | Entire Interface Collection
 *
 * The entire interface collection as part of Details of the Asset Administration Shell Part 2
 *
 * OpenAPI spec version: V1.0RC01
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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SubmodelRegistryInterfaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SubmodelRegistryInterfaceApiTests
    {
        private SubmodelRegistryInterfaceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubmodelRegistryInterfaceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubmodelRegistryInterfaceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SubmodelRegistryInterfaceApi
            //Assert.IsInstanceOfType(typeof(SubmodelRegistryInterfaceApi), instance, "instance is a SubmodelRegistryInterfaceApi");
        }

        /// <summary>
        /// Test DeleteSubmodelDescriptorById
        /// </summary>
        [Test]
        public void DeleteSubmodelDescriptorByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string submodelIdentifier = null;
            //instance.DeleteSubmodelDescriptorById(submodelIdentifier);
            
        }
        /// <summary>
        /// Test GetAllSubmodelDescriptors
        /// </summary>
        [Test]
        public void GetAllSubmodelDescriptorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllSubmodelDescriptors();
            //Assert.IsInstanceOf<List<SubmodelDescriptor>> (response, "response is List<SubmodelDescriptor>");
        }
        /// <summary>
        /// Test GetSubmodelDescriptorById
        /// </summary>
        [Test]
        public void GetSubmodelDescriptorByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string submodelIdentifier = null;
            //var response = instance.GetSubmodelDescriptorById(submodelIdentifier);
            //Assert.IsInstanceOf<SubmodelDescriptor> (response, "response is SubmodelDescriptor");
        }
        /// <summary>
        /// Test PostSubmodelDescriptor
        /// </summary>
        [Test]
        public void PostSubmodelDescriptorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelDescriptor body = null;
            //var response = instance.PostSubmodelDescriptor(body);
            //Assert.IsInstanceOf<SubmodelDescriptor> (response, "response is SubmodelDescriptor");
        }
        /// <summary>
        /// Test PutSubmodelDescriptorById
        /// </summary>
        [Test]
        public void PutSubmodelDescriptorByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmodelDescriptor body = null;
            //string submodelIdentifier = null;
            //instance.PutSubmodelDescriptorById(body, submodelIdentifier);
            
        }
    }

}
