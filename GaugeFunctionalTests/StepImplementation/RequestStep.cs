using Gauge.CSharp.Lib.Attribute;
using GaugeFunctionalTests.Pages.ApiPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GaugeFunctionalTests.StepImplementation
{
    public class RequestStep
    {
        private string numberOfStoryboards;
        
        StoryboardApiPage storyboardApiPage =  new StoryboardApiPage();

        [Step("Enter user <username> with <numberOfStoryboards> storyboards")]
        public void EnterUserStoryboardInformation(string username, string numberOfStoryboards)
        {
            storyboardApiPage.PutStoryboardValueForUser(username, numberOfStoryboards);
        }

        [Step("Fetch number of storyboards for <username>")]
        public void FetchNumberOfStoryboards(string username)
        {
            numberOfStoryboards = storyboardApiPage.GetStoryboardNumberForUser(username);
        }

        [Step("The number of storyboards should be <expectedNumberOfStoryboards>")]
        public void AssertNumberOfStoryboard(string expectedNumberOfStoryboards)
        {
            
            Assert.AreEqual(expectedNumberOfStoryboards, numberOfStoryboards, "Expected value:{0} \nActual value", expectedNumberOfStoryboards, numberOfStoryboards);
        }

        [Step("The number of storyboards should not be <expectedNumberOfStoryboards>")]
        public void AssertNotNumberOfStoryboards(string expectedNumberOfStoryboards)
        {
            
            Assert.AreNotEqual(expectedNumberOfStoryboards, numberOfStoryboards, "Expected value: not {0} \nActual value", expectedNumberOfStoryboards, numberOfStoryboards);
        }
    }
}
