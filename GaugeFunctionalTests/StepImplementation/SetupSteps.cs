using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.drivers;
using GaugeFunctionalTests.Pages.Contexts;
using GaugeFunctionalTests.setup;

namespace GaugeFunctionalTests.StepImplementation
{
    public class SetupSteps
    {

        [Step("Open browser")]
        public void SetupUiTest()
        {
            var webDriverSetup = new WebDriverSetup();
            webDriverSetup.Setup();
            ScenarioContext.Current.Add(webDriverSetup);
        }

        [Step("Connect the API")]
        public void SetupApiTest()
        {
            var apiDriverSetup = new ApiDriverSetup();
            apiDriverSetup.Setup();
            ScenarioContext.Current.Add(apiDriverSetup);
        }
    }
}