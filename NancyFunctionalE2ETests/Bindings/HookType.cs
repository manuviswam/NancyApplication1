using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFunctionalE2ETests.Bindings
{
    public enum HookType
        {
            BeforeTestRun,
            AfterTestRun,
            BeforeFeature,
            AfterFeature,
            BeforeScenario,
            AfterScenario,
            BeforeScenarioBlock,
            AfterScenarioBlock,
            BeforeStep,
            AfterStep,
        }
}
