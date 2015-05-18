using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace NancyFunctionalE2ETests.TestBase
{
    [SerializableAttribute]
    public class HomeAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.Out.WriteLine("Entry: Hello there!");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.Out.WriteLine("Exit: Hello there!");
        }          
       
    }
}
