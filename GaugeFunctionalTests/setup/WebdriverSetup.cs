using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.Pages.Contexts;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace GaugeFunctionalTests.drivers
{
    public class WebDriverSetup
    {
        public IWebDriver Driver { get; private set; }
        public bool isUI { get; private set; }

/*       [BeforeSuite]
        public void Setup()
        {
            var options = new InternetExplorerOptions {IntroduceInstabilityByIgnoringProtectedModeSettings = true};
            Driver = new InternetExplorerDriver(options);
            ScenarioContext.Current.Add(this);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver.Navigate().GoToUrl("http://www.poetryfoundation.org/");
            Driver.Manage().Window.Maximize();
        }

        [AfterSuite]
        public void TearDown()
        {
                Driver.Close();
                Driver.Quit();           
        }
 */

        public void Setup()
        {
            var options = new InternetExplorerOptions { IntroduceInstabilityByIgnoringProtectedModeSettings = true };
            Driver = new InternetExplorerDriver(options);
            ScenarioContext.Current.Add(this);
            isUI = true;
            Driver.Navigate().GoToUrl("http://www.poetryfoundation.org/");
            Driver.Manage().Window.Maximize();
        }
     }
}
