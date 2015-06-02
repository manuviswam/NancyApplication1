using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.Pages.Contexts;
using GaugeFunctionalTests.Pages.GetGaugePages;
using GaugeFunctionalTests.Pages.PoetryFoundationPages;

namespace GaugeFunctionalTests.StepImplementation
{
    public class PoetryFoundationSteps
    {

        [Step("Navigate to About Us page")]
        public void NavigateToAboutUsPage()
        {
            var aboutUsPage = new HomePage().OpenAboutUsPage();
            ScenarioContext.Current.Add(aboutUsPage);
         }

        [Step("Verify the title of GetStartedPage is <titleName>")]
        public void VerifyTitleOfGetStartedPage(string titleName)
        {
            var getStartedPage = ScenarioContext.Current.Get<AboutUsPage>();
            getStartedPage.VerifyTitleOfPageIs(titleName);
        }
    }
}