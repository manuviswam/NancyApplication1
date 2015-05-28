using RestSharp;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class RequestPage
    {
        const string baseUrl = "http://localhost:3579";
        RestClient client = new RestClient(baseUrl);
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
            var response = (RestResponse) client.Execute(request);
            return response;
        }
        
    }
}
