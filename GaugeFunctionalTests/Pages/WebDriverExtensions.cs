using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GaugeFunctionalTests.Pages
{
    public static class WebDriverExtensions
    {
        private static int MAXIMUM_TIMEOUT_IN_SECONDS = 30;

        public static IWebElement FindElement(this IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(MAXIMUM_TIMEOUT_IN_SECONDS));
             return wait.Until(drv => drv.FindElement(by));
         }
        
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }
}