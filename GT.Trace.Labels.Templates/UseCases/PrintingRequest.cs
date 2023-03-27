namespace GT.Trace.Labels.Templates.UseCases
{
    public class PrintingRequest : MediatR.IRequest
    {
        public PrintingRequest(string printerName, string serverName, int printCopies)
        {
            PrinterName = printerName;
            ServerName = serverName;
            PrintCopies = printCopies;
        }

        public string ServerName { get; }

        public string PrinterName { get; }

        public int PrintCopies { get; }
    }
}