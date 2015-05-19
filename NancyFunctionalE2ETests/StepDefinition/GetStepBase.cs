using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace NancyFunctionalE2ETests.StepDefinition
{
    public class GetStepBase : TestSetup
    {
        RestRequest GetRequest { get; set; }
        private StepBase step;

        public GetStepBase With()
        {
            return this;
        }
        
        public GetStepBase Get(string apiName, StepBase stepBase)
        {
            GetRequest = new RestRequest(apiName, Method.GET);
            step = stepBase;
            return this;
        }

        public StepBase Execute()
        {
            var stepBase = new StepBase {ResponseOutput = (RestResponse) Client.Execute(GetRequest)};
            return stepBase;
        }
        
    }
}
