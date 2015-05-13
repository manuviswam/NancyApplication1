using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyFunctionalE2ETests.Bindings
{
   [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
        public abstract class HookAttribute : Attribute
        {
            internal HookType Event { get; private set; }

            public string[] Tags { get; private set; }

            internal HookAttribute(HookType bindingEvent, string[] tags)
            {
                Event = bindingEvent;
                Tags = tags;
            }
        }
    }
