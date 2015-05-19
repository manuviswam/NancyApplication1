using NUnit.Framework;
using RestSharp;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class StepBase : TestSetup
    {
        public string ActualResult { get; set; }
        public RestResponse ResponseOutput { get; set; }

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
        
        public RequestStepBase Put(string apiName)
        {
            return new RequestStepBase().Put(apiName,this);
        }
        
        public RequestStepBase Get(string apiName)
        {
            return new RequestStepBase().Get(apiName,this);
        }

        public AssertionStepBase ResponseContent()
        {
            var assertionStepBase = new AssertionStepBase();
            assertionStepBase.ResponseContent(this);
            return assertionStepBase;
        }
    }
}
