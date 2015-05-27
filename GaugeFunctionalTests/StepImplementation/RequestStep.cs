using System;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NancyFunctionalE2ETests;
using RestSharp;

namespace GaugeFunctionalTests.StepImplementation
{
    public class RequestStep : GaugeTestHooks
    {
        private const string ApiName = "/api/";

        [Step("There are users with storyboards given as <table>")]
        public void ThereAreUsersWithStoryboardsGivenAs(Table table)

        {
            var rows = table.GetRows();
            foreach (var row in rows)
            {
                var api = ApiName + row[0];
                var request = new RestRequest(api, Method.PUT);
                request.AddQueryParameter("SB", row[1]);
                var response = (RestResponse)Client.Execute(request);
                
                var request1 = new RestRequest(api, Method.GET);
                Assert.Equals(request1, row[1]);


            }
        }

        [Step("The number of storyboards for the users are returned")]
        public void TheNumberOfStoryboardsForTheUsersAreReturned(Table table)
        {
            var rows = table.GetRows();
            foreach (var row in rows)
            {
                var api = ApiName + row[0];
                var request1 = new RestRequest(api, Method.GET);
                Assert.Equals(request1, row[1]);
            }
        }
    }
}
