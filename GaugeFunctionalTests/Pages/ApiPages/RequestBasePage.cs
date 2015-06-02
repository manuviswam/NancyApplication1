using GaugeFunctionalTests.Pages.Contexts;
using GaugeFunctionalTests.setup;
using RestSharp;

namespace GaugeFunctionalTests.Pages.ApiPages
{
    public class RequestPage
    {
       RestRequest request { get; set; }

        public RequestPage Put(string apiName)
        {
            request = new RestRequest(apiName, Method.PUT);
            return this;
        }

        public RequestPage Get(string apiName)
        {
            request = new RestRequest(apiName, Method.GET);
            return this;
        }

        public RequestPage QueryParameter(string parameterName, string parameterValue)
        {
            request.AddQueryParameter(parameterName, parameterValue);
            return this;
        }

        public RestResponse Execute()
        {
            var client = ScenarioContext.Current.Get<ApiDriverSetup>().Client;
            var response = (RestResponse) client.Execute(request);
            return response;
        }
        
    }
}
