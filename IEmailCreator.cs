namespace QueueListener
{
    public interface IEmailCreator<U>
    {
        U CreateMessage((string email, string name) sender);
    }
}