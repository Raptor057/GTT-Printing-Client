namespace GT.Trace.Labels.App.Dtos
{
    public class ReturnLabelDto : LabelDto
    {
        public ReturnLabelDto()
            : base(LabelTypes.Return)
        {
        }

        public string EtiNo { get; set; }

        public string ComponentNo { get; set; }

        public string EmployeeName { get; set; }

        public string PointOfUseCode { get; set; }
    }
}