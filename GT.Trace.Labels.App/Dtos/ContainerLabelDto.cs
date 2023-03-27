using System;

namespace GT.Trace.Labels.App.Dtos
{
    public class ContainerLabelDto : LabelDto
    {
        public ContainerLabelDto(LabelTypes type)
            : base(type)
        { }

        public string PurchaseOrderNo { get; set; }

        public string JulianDate { get; set; }

        public string Customer { get; set; }

        public string CustomerPartNo { get; set; }

        public string PartNo { get; set; }

        public string Revision { get; set; }

        public string PartDescription { get; set; }

        public DateTime Date { get; set; }

        public string Approver { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public long? MasterID { get; set; }
    }
}