using System.Collections.Generic;

namespace GT.Trace.Labels.App.UseCases.Printing.FetchPrinters
{
    public sealed class FetchPrintersResponse
    {
        public FetchPrintersResponse(IEnumerable<string> printers)
        {
            Printers = printers;
        }

        public IEnumerable<string> Printers { get; }
    }
}