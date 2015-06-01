using GaugeFunctionalTests.drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GaugeFunctionalTests.Pages.PoetryFoundationPages
{
    public class AboutUsPage
    {
      private static string Title()
        {
            var title = WebDriverSetup.Driver.FindElement(By.CssSelector(".col.nopad .heading")).Text;
            return title;
        }

      public void VerifyTitleOfPageIs(string titleName)
      {
          var title = Title().ToUpper();
          Assert.AreEqual(titleName, title);
      }
    }
}