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
    ///  Class for testing DescriptorInterfaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DescriptorInterfaceApiTests
    {
        private DescriptorInterfaceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DescriptorInterfaceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DescriptorInterfaceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DescriptorInterfaceApi
            //Assert.IsInstanceOfType(typeof(DescriptorInterfaceApi), instance, "instance is a DescriptorInterfaceApi");
        }

        /// <summary>
        /// Test GetDescriptor
        /// </summary>
        [Test]
        public void GetDescriptorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDescriptor();
            //Assert.IsInstanceOf<List<Descriptor>> (response, "response is List<Descriptor>");
        }
    }

}
