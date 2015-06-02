using GaugeFunctionalTests.drivers;
using GaugeFunctionalTests.Pages.Contexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GaugeFunctionalTests.Pages.PoetryFoundationPages
{
    public class AboutUsPage
    {
      private static string Title()
      {
          var browser = ScenarioContext.Current.Get<WebDriverSetup>().Driver;
            var title = browser.FindElement(By.CssSelector(".col.nopad .heading")).Text;
            return title;
        }

      public void VerifyTitleOfPageIs(string titleName)
      {
          var title = Title().ToUpper();
          Assert.AreEqual(titleName, title);
      }
    }
}