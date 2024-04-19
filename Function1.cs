using System;
using Microsoft.Extensions.Logging;

namespace WeatherInfoReceiver
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("aztrainingtaktuk_topic", "AzTrainingSubscription", Connection = "ServiceBusConnectionString")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
