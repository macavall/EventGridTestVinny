using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Messaging;
using Azure.Messaging.EventGrid;
using Azure.Messaging.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FunctionApp13
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([EventGridTrigger] string eventGridEvent,
        //[EventHub("myeventhub", Connection = "EventHubConnectionAppSetting")] ICollection<string> outputEvents,
        ILogger log)
        {
            try
            {
                log.LogInformation("triggering");                
                log.LogInformation(eventGridEvent);
                //outputEvents = eventGridEvent.ToString();
            }
            catch (Exception ex)
            {
                log.LogError("ERROR: " + ex.ToString());
               // outputEvents = "Failed";
            }
            //return outputEvents;
        }
    }
}
