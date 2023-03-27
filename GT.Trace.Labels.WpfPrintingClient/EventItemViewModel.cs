using System;

namespace GT.Trace.Labels.WpfPrintingClient
{
    public sealed class EventItemViewModel
    {
        public EventItemViewModel(string message)
            : this(message, DateTime.Now)
        { }

        public EventItemViewModel(string message, DateTime timeStamp)
        {
            Message = message;
            TimeStamp = timeStamp;
        }

        public DateTime TimeStamp { get; }

        public string Message { get; }
    }
}