using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauge.CSharp.Lib.Attribute;
using RestSharp;

namespace NancyFunctionalE2ETests
{
    public class GaugeTestHooks
    {
        public RestClient Client;

        [BeforeSuite]
        public void BeforeAll()
        {
            //define base url where all APIs are hosted
            const string baseUrl = "http://localhost:3579";

            //initialise RESTSharp client
            Client = new RestClient(baseUrl);
        }
    }
}
