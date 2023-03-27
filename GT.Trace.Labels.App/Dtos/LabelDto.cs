using System;

namespace GT.Trace.Labels.App.Dtos
{
    public class LabelDto
    {
        public LabelDto(LabelTypes type)
        {
            Type = type;
        }

        public long LabelID { get; set; }

        public LabelTypes Type { get; }

        public int Quantity { get; set; }

        public DateTime CreationTime { get; set; }

        public string LineCode { get; set; }

        public DateTime? LastPrintingTime { get; set; }

        public bool? LastPrintingSuccessStatus { get; set; }

        public string LineName { get; set; }

        public bool IsNew => !LastPrintingTime.HasValue;

        public bool IsFailure => !(LastPrintingSuccessStatus ?? true);
    }
}