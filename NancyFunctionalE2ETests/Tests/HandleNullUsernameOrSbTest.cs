using System;
using NancyFunctionalE2ETests.StepDefinition;
using NUnit.Framework;

namespace NancyFunctionalE2ETests.Tests
{
    [TestFixture]
    public class HandleNullUsernameOrSbTest : StepBase
    {
        private const string api = "/api/";

        [Test]
        [Category("Regression")]
        public void Error_message_should_be_returned_when_SB_is_null()
        {
            const string userName = "user18";
            const string expectedResult = "Username/SB is empty";

            Given()
                .Put(api + userName)
                .With().QueryParameter(String.Empty, userName)
                .Execute().

                Then()
                .ResponseContent().Should().Equals(expectedResult);
        }

        [Test()]
        [Category("Regression")]
        public void Error_message_should_be_returned_when_userName_is_null()
        {

            const string expectedResult = "Username/SB is empty";
            string userName = string.Empty;

            Given()
                .Put(api + userName)
                .With().QueryParameter(String.Empty, userName)
                .Execute().
                When()
                .Get(api + userName)
                .Execute().

                Then()
                .ResponseContent().Should().Equals(expectedResult);
        }
    }
}