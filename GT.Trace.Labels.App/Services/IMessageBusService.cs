namespace GT.Trace.Labels.App.Services
{
    public delegate void OnMessageEventHandler(string message);

    public interface IMessageBusService
    {
        event OnMessageEventHandler OnMessage;

        void PassMessage(string message);
    }
}