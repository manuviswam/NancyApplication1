using NUnit.Framework;
using RestSharp;

namespace NancyFunctionalE2ETests.Tests
{
    [TestFixture]
    [Category("Storyboard")]
    public class GetStoryboardsTest : TestSetup
    {
        private const string api = "/api/";

        [TestCase("user1")]
        [TestCase("user*")]
        [Category("Smoke")]
        public void Number_of_storyboards_for_user_should_be_returned(string User)
        {
//            const string User = "user1";

            // Put values to API for input
            var putRequest = new RestRequest(api + User, Method.PUT);
            const string expectedResult = "10";
            putRequest.AddQueryParameter("SB", expectedResult);
            var putResponse = (RestResponse) Client.Execute(putRequest);
           
            //Get values from API for output
            var getRequest = new RestRequest(api + User, Method.GET);
            var response = (RestResponse)Client.Execute(getRequest);
            var actualResult = response.Content;
            
            //Validate if expected result = actual result
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [Category("Regression")]
        public void Number_of_storyboards_for_invalid_user_should_not_be_returned()
        {
            const string validUser = "user1";
            const string invalidUser = "user2";

            // Put values to API for input
            var putRequest = new RestRequest(api + validUser, Method.PUT);
            const string expectedResult = "15";
            putRequest.AddQueryParameter("SB", expectedResult);
            var putResponse = (RestResponse) Client.Execute(putRequest);
           
            //Get values from API for output
            var getRequest = new RestRequest(api + invalidUser, Method.GET);
            var response = (RestResponse)Client.Execute(getRequest);
            var actualResult = response.Content;
            
            //Validate if expected result = actual result
            Assert.AreNotEqual(expectedResult, actualResult);
        }

      
    }
}
