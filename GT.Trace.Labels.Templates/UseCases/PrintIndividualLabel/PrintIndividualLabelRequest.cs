using System;

namespace GT.Trace.Labels.Templates.UseCases.PrintIndividualLabel
{
    public sealed class PrintIndividualLabelRequest : PrintingRequest
    {
        public PrintIndividualLabelRequest(string printerName, string serverName, int printCopies)
            : base(printerName, serverName, printCopies)
        {
        }

        public long LabelID { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationTime { get; set; }

        public string LineCode { get; set; }
    }
}