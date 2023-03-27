using System;
using System.Globalization;

namespace GT.Trace.Labels.Templates
{
    public partial class PickingUnitLabel : LabelBase
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