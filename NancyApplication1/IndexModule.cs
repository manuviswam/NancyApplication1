using System.Collections.Generic;

namespace NancyApplication1
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            System.IO.Directory.CreateDirectory("Data");

            Get["/"] = parameters => View["index"];

            Get["/home"] = parameters => { return "Welcome!"; };

            Get["/api/{username}"] = parameters =>
            {
                var dataFile = string.Format("Data\\{0}.txt", parameters.username);
                if (!System.IO.File.Exists(dataFile))
                    return "No data found";
                return System.IO.File.ReadAllText(dataFile);
            };

            Put["/api/{username}"] = parameters =>
            {
                if (string.IsNullOrEmpty(parameters.username) || string.IsNullOrEmpty(Request.Query["SB"]))
                    return "Username/SB is empty";
                System.IO.File.WriteAllText(string.Format("Data\\{0}.txt",parameters.username),Request.Query["SB"]);
                return "OK";
            };
        }
    }
}