using System;

namespace GT.Trace.Labels.Templates.UseCases.PrintPickingLabel
{
    public sealed class PrintPickingLabelRequest : PrintingRequest
    {
        public PrintPickingLabelRequest(string printerName, string serverName, int printCopies)
            : base(printerName, serverName, printCopies)
        {
        }

        public long LabelID { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationTime { get; set; }

        public string LineCode { get; set; }

        public long UnitID { get; set; }

        public long ProtoID { get; set; }
    }
}