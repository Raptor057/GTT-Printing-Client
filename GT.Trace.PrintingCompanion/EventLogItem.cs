using System;

namespace GT.Trace.PrintingCompanion
{
    public class EventLogItem
    {
        public EventLogItem(string message)
        {
            Message = message;
            TimeStamp = DateTime.Now;
        }

        public string Message { get; }

        public DateTime TimeStamp { get; }

        public override string ToString()
        {
            return $"{TimeStamp:HH:mm:ss} - {Message}";
        }
    }
}