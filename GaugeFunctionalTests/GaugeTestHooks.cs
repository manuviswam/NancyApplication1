using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauge.CSharp.Lib.Attribute;
using RestSharp;

namespace NancyFunctionalE2ETests
{
    public class GaugeTestHooks
    {
        string output = "Begin";

        [BeforeSuite]
        public void BeforeAll()
        {
            Console.WriteLine("\n BeforeSuite");
        }  
        
        [BeforeSpec]
        public void BeforeSpec()
        {
            Console.WriteLine("\n BeforeSpec");
        } 
       
        [BeforeScenario]
        public void BeforeScenario()
        {
            output = output+"\n BeforeScenario";
        } 
      
        [BeforeStep]
        public void BeforeStep()
        {
            output = output+"\n BeforeStep";
        }  

        [AfterSuite]
        public void AfterAll()
        {
            output = output + "\n AfterSuite";
//            Console.Write(output);
        }  
        
        [AfterSpec]
        public void AfterSpec()
        {
            output = output + "\n AfterSpec";
        } 
       
        [AfterScenario]
        public void AfterScenario()
        {
            output = output + "\n AfterScenario";
        } 
      
        [AfterStep]
        public void AfterStep()
        {
            output = output + "\n AfterStep";
        }  
       

    }
}
