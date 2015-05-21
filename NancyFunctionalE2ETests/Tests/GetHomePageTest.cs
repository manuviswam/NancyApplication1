using NancyFunctionalE2ETests.StepDefinition;
using NUnit.Framework;
using NancyFunctionalE2ETests.TestBase;
using RestSharp;

namespace NancyFunctionalE2ETests.Tests
{
    [TestFixture]
    [Category("Home")]
    public class GetHomePageTest : StepBase
    {
        [Test]
        [Category("Smoke")]
        public void HomePage_should_be_returned()
        {
            const string expectedResult = "Welcome!";

            When()
                .Get("/home")
                .Execute().
            Then()
                .ResponseContent().Should().Equals(expectedResult);
            
           
        }
    }
}
