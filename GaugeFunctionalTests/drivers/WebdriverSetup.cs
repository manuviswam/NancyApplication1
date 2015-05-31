using System;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace GaugeFunctionalTests.drivers
{
    public class WebDriverSetup
    {
        public static IWebDriver driver { get; private set; }

        [BeforeSuite]
        public void Setup()
        {
            string IE_DRIVER_PATH = "D:\\mckinsey\\NancyApplication1\\GaugeFunctionalTests\\drivers";
            var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            driver = new InternetExplorerDriver(IE_DRIVER_PATH, options);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Navigate().GoToUrl("http://www.makemytrip.com/");
            driver.Manage().Window.Maximize();
        }

        [AfterSuite]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
