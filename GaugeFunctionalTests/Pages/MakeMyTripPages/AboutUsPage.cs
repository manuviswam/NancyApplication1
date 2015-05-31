using GaugeFunctionalTests.drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GaugeFunctionalTests.Pages.GetGaugePages
{
    public class AboutUsPage
    {
        public void verifyTitleOfPageIs(string titleName)
        {
            var title = WebDriverSetup.driver.FindElement(By.ClassName("fIL")).Text;
            Assert.AreEqual(titleName, title);
        }
    }
}