using GT.Trace.Labels.App.Services;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Printing;
using System.Text.RegularExpressions;

namespace GT.Trace.Labels.Infra.Services
{
    internal sealed class SystemPrintersService : IPrintersService
    {
        private readonly string _localServerName;

        public SystemPrintersService()
        {
            _localServerName = $"\\\\{System.Net.Dns.GetHostName()}";
        }

        public List<string> GetInstalledPrintersOnline()
        {
            var installedPrinters = new List<string>();
            string fullPrinterName, printerName, serverName;
            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                fullPrinterName = printer.ToString();
                GetPrinterNameAndServer(fullPrinterName, out printerName, out serverName);
                if (PrinterIsOnline(printerName, serverName))
                {
                    installedPrinters.Add(fullPrinterName);
                }
            }
            return installedPrinters;
        }

        public void GetPrinterNameAndServer(string fullPrinterName, out string printerName, out string serverName)
        {
            printerName = "";
            serverName = "";

            var match = Regex.Match(fullPrinterName, @"((?<serverName>\\\\.+)\\)?(?<printerName>.+)");
            if (match.Success)
            {
                serverName = match.Groups["serverName"].Value;
                printerName = match.Groups["printerName"].Value;
            }

            if (string.IsNullOrWhiteSpace(serverName))
            {
                serverName = _localServerName;
            }
        }

        public bool PrinterIsOnline(string printerName, string serverName)
        {
            var server = new PrintServer(serverName);
            try
            {
                using (PrintQueue queue = server.GetPrintQueue(printerName, new string[0]))
                {
                    return !queue.IsOffline;
                }
            }
            catch { }
            return false;
        }
    }
}