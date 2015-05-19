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
        
        public PutStepBase Put(string apiName)
        {
            return new PutStepBase().Put(apiName,this);
        }
        
        public GetStepBase Get(string apiName)
        {
            return new GetStepBase().Get(apiName,this);
        }

        public AssertionStepBase ResponseContent()
        {
            var assertionStepBase = new AssertionStepBase();
            assertionStepBase.ResponseContent(this);
            return assertionStepBase;
        }
    }
}
