using System;
using System.Collections.Generic;

namespace GaugeFunctionalTests.Pages.Contexts
{
    public class ScenarioContext
    {
        private static readonly ScenarioContext context = new ScenarioContext();

        private readonly Dictionary<Type, object> pageObjects = new Dictionary<Type, object>();

        private ScenarioContext()
        {
        }

        public static ScenarioContext Current { get {return context;} }

        public void Add<T>(T pageContext)
        {
            pageObjects.Add(typeof(T), pageContext);
            
        }

        public T Get<T>()
        {
            return (T) pageObjects[typeof(T)];
        }
    }
}