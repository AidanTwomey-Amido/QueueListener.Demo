using System.Threading.Tasks;

namespace QueueListener
{
    public interface IEmailSender
    {
        Task SendAsync();
    }
}