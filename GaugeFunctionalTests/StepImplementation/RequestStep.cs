using System;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NancyFunctionalE2ETests;
using NancyFunctionalE2ETests.StepDefinition;
using RestSharp;

namespace GaugeFunctionalTests.StepImplementation
{
    public class RequestStep : GaugeTestHooks
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
