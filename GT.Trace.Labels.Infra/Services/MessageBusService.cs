using GT.Trace.Labels.App.Services;

namespace GT.Trace.Labels.Infra.Services
{
    internal class MessageBusService : IMessageBusService
    {
        public event OnMessageEventHandler OnMessage;

        public void PassMessage(string message)
        {
            OnMessage?.Invoke(message);
        }
    }
}