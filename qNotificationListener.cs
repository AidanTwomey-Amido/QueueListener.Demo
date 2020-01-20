using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using SendGrid;

namespace QueueListener
{
    public static class qNotificationListener
    {
        private const string API_KEY = "<sendgrid-api-key-here>"; // todo: pass in as env variable

        [FunctionName("qNotificationListener")]
        public static async Task RunAsync([ServiceBusTrigger("notifications-aidan", Connection = "ConnString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"ServiceBus queue trigger function processed message: {myQueueItem}");
            
            var sender = new SendGridSender(new SendGridClient(API_KEY), new SendGridEmailCreator());

            await sender.SendAsync();
        }
    }
}