namespace GT.Trace.Labels.Infra.DataStores.SqlDB.Entities
{
    internal sealed class ReturnLabel
    {
        public long LabelID { get; set; }

        public string EtiNo { get; set; }

        public string ComponentNo { get; set; }

        public string EmployeeName { get; set; }

        public string PointOfUseCode { get; set; }
    }
}