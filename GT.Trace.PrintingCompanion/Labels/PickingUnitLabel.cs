using System;
using System.Globalization;

namespace GT.Trace.PrintingCompanion.Labels
{
    public partial class PickingUnitLabel : DevExpress.XtraReports.UI.XtraReport
    {
        public PickingUnitLabel(long protoID, string lineCode, long unitID)
        {
            InitializeComponent();
            var week = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            lblserial.Text = $"{unitID}/{lineCode}/{week}";
            BARCODE.Text = protoID.ToString();
        }
    }
}