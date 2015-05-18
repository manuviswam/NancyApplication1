using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            step.PutResponseOutput = (RestResponse) Client.Execute(PutRequest);
            return step;
        }
        
    }
}
