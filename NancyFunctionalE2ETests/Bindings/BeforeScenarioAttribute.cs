using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFunctionalE2ETests.Bindings
{
  public class BeforeScenarioAttribute : HookAttribute
  {
      public BeforeScenarioAttribute(params string[] tags)
      : base(HookType.BeforeScenario, tags)
    {
    }
  }
}