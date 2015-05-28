using RestSharp;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class StoryboardApiPage : RequestPage
    {
        private const string ApiName = "/api/";

        RestRequest request { get; set; }

        public RestResponse PutStoryboardValueForUser(string username, string numberOfStoryboards)
        {
            var api = ApiName + username;
            var response = Put(api).QueryParameter("SB", numberOfStoryboards).Execute();
            return response;
        }

        public string GetStoryboardNumberForUser(string username)
        {
            var api = ApiName + username;
            var response = Get(api).Execute();
            return response.Content;
        }
    }
}
