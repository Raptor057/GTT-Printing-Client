namespace GT.Trace.Labels.Infra.DataStores.SqlDB.Entities
{
    internal sealed class SubAssemblyLabel
    {
        public long LabelID { get; set; }

        public string PartNo { get; set; }

        public string Revision { get; set; }

        public string PartDescription { get; set; }

        public long EtiID { get; set; }
    }
}