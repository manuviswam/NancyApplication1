using System;
using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.Pages.Contexts;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace GaugeFunctionalTests.drivers
{
    public class WebDriverSetup
    {
        public static IWebDriver Driver { get; private set; }

        [BeforeSuite]
        public void Setup()
        {
            string IE_DRIVER_PATH = "D:\\mckinsey\\NancyApplication1\\GaugeFunctionalTests\\drivers";
            var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            Driver = new InternetExplorerDriver(IE_DRIVER_PATH, options);
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
        }
    }
}
