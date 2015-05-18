using NUnit.Framework;
using NancyFunctionalE2ETests.TestBase;
using RestSharp;

namespace NancyFunctionalE2ETests.Tests
{
    [TestFixture]
    [Category("Home")]
    public class GetHomePageTest : TestSetup
    {
        [Test]
        [HomeAspect]
        [Category("Smoke")]
        public void HomePage_should_be_returned()
        {
            const string expectedResult = "Welcome!";
            

          //Get values from API for output
            var getRequest = new RestRequest("/home", Method.GET);
            var response = (RestResponse)Client.Execute(getRequest);
            var actualResult = response.Content;
            
            //Validate if expected result = actual result
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
