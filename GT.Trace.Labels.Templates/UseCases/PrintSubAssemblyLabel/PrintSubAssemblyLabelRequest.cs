using System;

namespace GT.Trace.Labels.Templates.UseCases.PrintSubAssemblyLabel
{
    public sealed class PrintSubAssemblyLabelRequest : PrintingRequest
    {
        public PrintSubAssemblyLabelRequest(string printerName, string serverName, int printCopies)
            : base(printerName, serverName, printCopies)
        {
        }

        public long LabelID { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationTime { get; set; }

        public string LineCode { get; set; }

        public string PartNo { get; set; }

        public string Revision { get; set; }

        public string PartDescription { get; set; }

        public long Folio { get; set; }
    }
}