using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.drivers;
using GaugeFunctionalTests.Pages.Contexts;

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
    }
}