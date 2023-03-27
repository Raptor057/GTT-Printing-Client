using System;

namespace GT.Trace.Labels.Templates
{
    public partial class MaterialReturnLabel : LabelBase
    {
        public MaterialReturnLabel(string etiNo, string componentNo, string employeeName, string lineName, string partNo, DateTime timeStamp, string pointOfUse)
        {
            InitializeComponent();

            bareti.Text = etiNo;
            LBLcomponente.Text = componentNo;
            lblempleado.Text = $"{employeeName}\n{lineName} / {pointOfUse}\n{partNo}\t\t{timeStamp:dd-MMM-yyyy}";

            ShowPrintMarginsWarning = false;
        }
    }
}