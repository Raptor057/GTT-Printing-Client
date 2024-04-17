using System;

namespace GT.Trace.Labels.Templates.UseCases.PrintKitSavLabel
{
    public sealed class PrintKitSavLabelRequest : PrintingRequest
    {
        public PrintKitSavLabelRequest(string printerName, string serverName, int printCopies) 
            : base(printerName, serverName, printCopies)
        {
        }

        public string CustomerPartNo { get; set; }

        public string PartNo { get; set; }

        public string PartDescription { get; set; }

        public string Www { get; set; }

    }
}
