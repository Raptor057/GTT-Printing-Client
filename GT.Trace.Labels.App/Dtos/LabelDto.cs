﻿using System;

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

        public string Origen { get; set; } //Se agrego Campo Origen Faltante RA: 04 / 19 /2023

        public string Www { get; set; } //Se agrego Campo Www Faltante RA: 04 / 16 /2024
    }
}