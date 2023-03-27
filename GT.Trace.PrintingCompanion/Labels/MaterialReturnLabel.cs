using System;

namespace GT.Trace.PrintingCompanion.Labels
{
    public partial class MaterialReturnLabel : DevExpress.XtraReports.UI.XtraReport
    {
        public MaterialReturnLabel(string etiNo, string componentNo, string employeeName, string lineCode, string partNo, DateTime timeStamp, string pointOfUse)
        {
            InitializeComponent();

            bareti.Text = etiNo;
            LBLcomponente.Text = componentNo;
            lblempleado.Text = $"{employeeName}\n{lineCode} / {pointOfUse}\n{partNo}\t\t{timeStamp:dd-MMM-yyyy}";

            ShowPrintMarginsWarning = false;
        }
    }
}