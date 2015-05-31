using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.Pages.Contexts;
using GaugeFunctionalTests.Pages.GetGaugePages;

namespace GaugeFunctionalTests.StepImplementation
{
    public class GetGaugeSteps
    {

        [Step("Navigate to Get Started page")]
        public void NavigateToGetStartedPage()
        {
            var aboutUsPage = new HomePage().OpenGetStartedPage();
            ScenarioContext.Current.Add(aboutUsPage);
         }

        [Step("Verify the title of GetStartedPage is <titleName>")]
        public void VerifyTitleOfGetStartedPage(string titleName)
        {
            var getStartedPage = ScenarioContext.Current.Get<AboutUsPage>();
            getStartedPage.verifyTitleOfPageIs(titleName);
        }
    }
}