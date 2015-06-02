using GaugeFunctionalTests.Pages.Contexts;
using RestSharp;

namespace GaugeFunctionalTests.setup
{
    public class ApiDriverSetup
    {
        public RestClient Client { get; private set; }

        public void Setup()
        {
            const string baseUrl = "http://localhost:3579";
            Client = new RestClient(baseUrl);
            ScenarioContext.Current.Add(this);
        }
     }
}
