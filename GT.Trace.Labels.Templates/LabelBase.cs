using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using GT.Trace.Labels.Templates.UseCases;
using System.Printing;

namespace GT.Trace.Labels.Templates
{
    public class LabelBase : XtraReport
    {
        public void CreateAndPrintDocument(PrintingRequest request)
        {
            CreateDocument();
            for (int i = 0; i < request.PrintCopies; i++)
            {
                this.Print($"{request.ServerName}\\{request.PrinterName}");
            }
            return;

            var printServer = new PrintServer(request.ServerName);
            var printQueue = printServer.GetPrintQueue(request.PrinterName);
            for (int i = 0; i < request.PrintCopies; i++)
            {
                PrintHelper.PrintDirect(this, printQueue);
            }
        }
    }
}