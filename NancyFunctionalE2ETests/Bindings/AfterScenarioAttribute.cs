using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFunctionalE2ETests.Bindings
{
  public class AfterScenarioAttribute : HookAttribute
  {
    public AfterScenarioAttribute(params string[] tags)
      : base(HookType.AfterScenario, tags)
    {
    }
  }
}