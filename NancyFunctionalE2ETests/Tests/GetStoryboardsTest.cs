using NUnit.Framework;
using NancyFunctionalE2ETests.StepDefinition;

namespace NancyFunctionalE2ETests.Tests
{
    [TestFixture]
    [Category("Storyboard")]
    public class GetStoryboardsTest : StepBase
    {
        private const string api = "/api/";

      [Test]
      [Category("Smoke")]
        public void Number_of_storyboards_for_user_should_be_returned()
        {
          const string user = "user1";
          const string expectedResult = "10";
          const string apiForValidUser = api + user;

          Given()
              .Put(apiForValidUser)
              .With().QueryParameter("SB", expectedResult)
              .Execute().
          When()
              .Get(apiForValidUser)
              .Execute().
          Then()
              .AssertEqual(PutResponse(), expectedResult);
        }

        [Test]
        [Category("Regression")]
        public void Number_of_storyboards_for_invalid_user_should_not_be_returned()
        {
            const string validUser = "user1";
            const string invalidUser = "user2";
            const string apiForValidUser = api + validUser;
            const string apiForInvalidUser = api + invalidUser;
            const string expectedResult = "15";


            Given()
                .Put(apiForValidUser)
                .With().QueryParameter("SB", expectedResult)
                .Execute().
            When()
                .Get(apiForInvalidUser)
                .Execute().
            Then()
                .AssertNotEqual(PutResponse(), expectedResult);          
        }

      
    }
}
