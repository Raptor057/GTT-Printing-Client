using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using GT.Trace.Labels.Templates.UseCases;
using System.Printing;

namespace GT.Trace.Labels.Templates
{
    public class LabelBase : XtraReport
    {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private BottomMarginBand bottomMarginBand1;

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

        private void InitializeComponent()
        {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.HeightF = 100F;
            this.detailBand1.Name = "detailBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // LabelBase
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}