using System;
using GaugeFunctionalTests.drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace GaugeFunctionalTests.Pages.GetGaugePages
{

    public class HomePage
    {
        public AboutUsPage OpenGetStartedPage()
        {
            var element = WebDriverSetup.driver.FindElement(By.ClassName("chf_footer_list")).FindElement(By.LinkText("About Us"));
            Actions actions = new Actions(WebDriverSetup.driver);
            actions.MoveToElement(element);
            actions.Perform();
            WebDriverSetup.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            return new AboutUsPage();
        }
    }
}