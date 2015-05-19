using NUnit.Framework;
using RestSharp;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class StepBase : TestSetup
    {
        public RestResponse PutResponseOutput { get; set; }
        public RestResponse GetResponseOutput { get; set; }

        public StepBase Given()
        {
            return this;
        }
        
        public StepBase When()
        {
            return this;
        }
        
        public StepBase Then()
        {
            return this;
        }
        
        public StepBase And()
        {
            return this;
        }
        
        public PutStepBase Put(string apiName)
        {
            return new PutStepBase().Put(apiName,this);
        }
        
        public GetStepBase Get(string apiName)
        {
            return new GetStepBase().Get(apiName,this);
        }

        public string PutResponse()
        {
            return PutResponseOutput.Content;
        }  

        public string GetResponse()
        {
            return GetResponseOutput.Content;
        }

        public StepBase AssertEqual(string actualResult, string expectedResult)
        {
            Assert.AreEqual(actualResult, expectedResult, "Actual value:{0} \nExpected value:{1}",actualResult,expectedResult);
            return this;
        }

        public StepBase AssertNotEqual(string actualResult, string expectedResult)
        {
            Assert.AreNotEqual(actualResult, expectedResult, "Actual value:{0} \nExpected value:{1}",actualResult,expectedResult);
            return this;
        }
    }
}
