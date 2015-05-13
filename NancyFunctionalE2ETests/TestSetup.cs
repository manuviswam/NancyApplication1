using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NancyFunctionalE2ETests.Bindings;
using RestSharp;

namespace NancyFunctionalE2ETests
{
    [SetUpFixture]
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

        [AfterScenario("Home")]
        public void SayHelloSetup()
        {
            Console.Out.WriteLine("Hello there!");
        }
     }
}
