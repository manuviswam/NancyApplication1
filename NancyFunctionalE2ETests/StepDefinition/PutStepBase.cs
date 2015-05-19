using RestSharp;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class PutStepBase : TestSetup
    {
        RestRequest PutRequest { get; set; }
        StepBase step;

        public PutStepBase With()
        {
            return this;
        }
        
        public PutStepBase Put(string apiName, StepBase stepBase)
        {
            PutRequest = new RestRequest(apiName, Method.PUT);
            step = stepBase;
            return this;
        }

        public PutStepBase QueryParameter(string parameterName, string parameterValue)
        {
            PutRequest.AddQueryParameter(parameterName, parameterValue);
            return this;
        }

        public StepBase Execute()
        {
            step.ResponseOutput = (RestResponse) Client.Execute(PutRequest);
            return step;
        }
        
    }
}
