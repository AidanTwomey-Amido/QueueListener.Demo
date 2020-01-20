using SendGrid.Helpers.Mail;

namespace QueueListener
{
    public class SendGridEmailCreator : IEmailCreator<SendGridMessage>
    {

        public SendGridMessage CreateMessage((string email, string name) to)
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("test@example.com", "Example User"));
            msg.AddTo(new EmailAddress(to.email, to.name));
            msg.SetTemplateId("d-2c985d384b364fe3bd91c7073d300829");

            var dynamicTemplateData = new ExampleTemplateData
            {
                Subject = "Hi!",
                Name = "Example User",
                Location = new Location
                {
                    City = "Birmingham",
                    Country = "United Kingdom"
                }
            };

            msg.SetTemplateData(dynamicTemplateData);

            return msg;
        }
    }
}