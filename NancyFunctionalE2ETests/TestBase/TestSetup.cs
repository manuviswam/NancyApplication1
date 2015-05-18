using System;
using NUnit.Framework;
using PostSharp.Aspects;
using RestSharp;

namespace NancyFunctionalE2ETests
{
    public class TestSetup
    {
        public static RestClient Client;

        [SetUp]
        public static void SetUp()
        {
            //define base url where all APIs are hosted
            const string baseUrl = "http://localhost:3579";

            //initialise RESTSharp client
            Client = new RestClient(baseUrl);
        }
     }
}
