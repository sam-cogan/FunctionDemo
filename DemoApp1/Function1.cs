
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System;
using Microsoft.Extensions.Logging;

namespace DemoApp1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, 
            [CosmosDB(
                databaseName: "FunctionLogDemo",
                collectionName: "DemoCollection",
                ConnectionStringSetting = "CosmosDBConnection")]out dynamic document,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");



            string requestBody = new StreamReader(req.Body).ReadToEnd();
            var logEvent =JsonConvert.DeserializeObject<LogData>(requestBody as string);

            document = new { Id = Guid.NewGuid(), Message= logEvent.EventMessage, Time=logEvent.EventTime, Category=logEvent.EventCategory, Priority=logEvent.Priority };

        }
    }
}
