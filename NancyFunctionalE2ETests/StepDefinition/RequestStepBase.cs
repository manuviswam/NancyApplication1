using RestSharp;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class RequestStepBase : TestSetup
    {
        RestRequest request { get; set; }
        StepBase step;

        public RequestStepBase With()
        {
            return this;
        }
        
        public RequestStepBase Put(string apiName, StepBase stepBase)
        {
            request = new RestRequest(apiName, Method.PUT);
            step = stepBase;
            return this;
        }

        public RequestStepBase Get(string apiName, StepBase stepBase)
        {
            request = new RestRequest(apiName, Method.GET);
            step = stepBase;
            return this;
        }

        public RequestStepBase QueryParameter(string parameterName, string parameterValue)
        {
            request.AddQueryParameter(parameterName, parameterValue);
            return this;
        }

        public StepBase Execute()
        {
            step.ResponseOutput = (RestResponse) Client.Execute(request);
            return step;
        }
        
    }
}
