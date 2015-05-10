using NUnit.Framework;
using RestSharp;

namespace NancyFunctionalE2ETests.Tests
{
    [TestFixture]
    public class GetStoryboardsTest
    {

        [Test]
        public void Number_of_storyboards_for_user_should_be_returned()
        {
            const string BaseUrl = "http://localhost:3579";
            var client = new RestClient(BaseUrl);

            // Put values to API
            var putRequest = new RestRequest("/api/user1", Method.PUT);
            const string expectedResult = "10";
            putRequest.AddQueryParameter("SB", expectedResult);
            var putResponse = (RestResponse) client.Execute(putRequest);
           
            //Get values from API
            var getRequest = new RestRequest("/api/user1/", Method.GET);
            var response = (RestResponse)client.Execute(getRequest);
            var actualResult = response.Content;
            
            //Validate if expected result = actual result
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
