using System;

namespace GT.Trace.Labels.App.Notifications.UseCases.ParseContainerComplete
{
    public sealed class ContainerCompleteDto
    {
        public string LineCode { get; set; }

        public long UnitID { get; set; }

        public bool QCContainerApprovalInWarning { get; set; }

        public bool QCContainerApprovalRequired { get; set; }

        public string PartNo { get; set; }

        public string Revision { get; set; }

        public string PartDescription { get; set; }

        public int Quantity { get; set; }

        public string CustomerNo { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPartNo { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string ApprovalUser { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public DateTime Date { get; set; }
    }
}