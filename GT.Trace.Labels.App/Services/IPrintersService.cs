using System.Collections.Generic;

namespace GT.Trace.Labels.App.Services
{
    public interface IPrintersService
    {
        List<string> GetInstalledPrintersOnline();

        bool PrinterIsOnline(string printerName, string serverName);

        void GetPrinterNameAndServer(string fullPrinterName, out string printerName, out string serverName);
    }
}