using System;

namespace GT.Trace.Labels.Templates.UseCases.PrintReturnLabel
{
    public sealed class PrintReturnLabelRequest : PrintingRequest
    {
        public PrintReturnLabelRequest(string printerName, string serverName, int printCopies)
            : base(printerName, serverName, printCopies)
        {
        }

        public long LabelID { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationTime { get; set; }

        public string LineName { get; set; }

        public string EtiNo { get; set; }

        public string ComponentNo { get; set; }

        public string EmployeeName { get; set; }

        public string PartNo { get; set; }

        public string PointOfUseCode { get; set; }
    }
}