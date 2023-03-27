namespace GT.Trace.Labels.App.Dtos
{
    public class SubAssemblyLabelDto : LabelDto
    {
        public SubAssemblyLabelDto()
            : base(LabelTypes.SubAssembly)
        {
        }

        public long EtiID { get; set; }

        public string PartNo { get; set; }

        public string Revision { get; set; }

        public string PartDescription { get; set; }
    }
}