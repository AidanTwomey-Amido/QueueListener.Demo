using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace QueueListener
{
    public class SendGridSender : IEmailSender
    {
        private readonly ISendGridClient client;
        private readonly IEmailCreator<SendGridMessage> emailCreator;

        public SendGridSender(ISendGridClient client, IEmailCreator<SendGridMessage> emailCreator)
        {
            this.client = client;
            this.emailCreator = emailCreator;
        }

        public async Task SendAsync()
        {
            SendGridMessage msg = this.emailCreator.CreateMessage(("aidan.twomey@amido.com", "Aidan Twomey")) ;
            await client.SendEmailAsync(msg);
        }
    }
}