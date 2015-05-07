using System.Collections.Generic;

namespace NancyApplication1
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        private Dictionary<string,int> usernameSbDictionary = new Dictionary<string, int>(); 
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Put["/hello"] = parameters =>
            {
                return this.Request.Query["foo"];
            };

            Get["/api/{username}"] = parameters => usernameSbDictionary[parameters.username];

            Put["/api/{username}"] = parameters =>
            {
                usernameSbDictionary.Add(parameters.username,(int) this.Request.Query["SB"]);
                return "OK";
            };
        }
    }
}