﻿using System;

namespace GT.Trace.Labels.Templates.UseCases.PrintPartialLabel
{
    public sealed class PrintPartialLabelRequest : PrintingRequest
    {
        public PrintPartialLabelRequest(string printerName, string serverName, int printCopies)
            : base(printerName, serverName, printCopies)
        {
        }

        public long LabelID { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationTime { get; set; }

        public string LineName { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string JulianDate { get; set; }

        public string Customer { get; set; }

        public string CustomerPartNo { get; set; }

        public string PartNo { get; set; }

        public string Revision { get; set; }

        public string PartDescription { get; set; }

        public DateTime Date { get; set; }

        public long MasterID { get; set; }
    }
}