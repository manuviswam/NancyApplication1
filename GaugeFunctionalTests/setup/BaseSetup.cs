using System;
using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.Pages.Contexts;

namespace GaugeFunctionalTests.drivers
{
    public class BaseSetup
    {
        private WebDriverSetup setup;

        [AfterScenario]
        public void TearDown()
        {
            try
            {
                setup = ScenarioContext.Current.Get<WebDriverSetup>();
            }
            catch (NullReferenceException)
            {
                
                ScenarioContext.Current.Add(new WebDriverSetup());
                setup = ScenarioContext.Current.Get<WebDriverSetup>();
            }

            if (setup.isUI)
            {
                var browser = setup.Driver;
                browser.Close();
                browser.Quit();
            }
            ScenarioContext.Current.EmptyList();
        }
    }
}