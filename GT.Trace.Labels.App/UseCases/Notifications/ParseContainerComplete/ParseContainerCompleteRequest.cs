using MediatR;

namespace GT.Trace.Labels.App.Notifications.UseCases.ParseContainerComplete
{
    public sealed class ParseContainerCompleteRequest : IRequest
    {
        public ParseContainerCompleteRequest(string jsonData)
        {
            JsonData = jsonData;
        }

        public string JsonData { get; }
    }
}