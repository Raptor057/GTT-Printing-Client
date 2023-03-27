using System;

namespace GT.Trace.PrintingCompanion
{
    public class PrintingRequest : MediatR.IRequest<PrintingResponse>
    {
        public enum PrintRequestTypes
        {
            MaterialReturnLabel,
            SubAssemblyEti,
            MasterLabel,
            JrLabel,
            PickingLabel
        }

        public PrintingRequest(string name, DateTime timeStamp, PrintRequestTypes requestType)
        {
            Name = name;
            TimeStamp = timeStamp;
            RequestType = requestType;
        }

        public PrintRequestTypes RequestType { get; }

        public string Name { get; }

        public DateTime TimeStamp { get; }

        public string PrinterName { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}