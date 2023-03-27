using SQLite;
using System;

namespace GT.Trace.Labels.Infra.DataStores.SqlDB.Entities
{
    internal sealed class Label
    {
        [PrimaryKey, AutoIncrement]
        public long LabelID { get; set; }

        [NotNull]
        public int LabelTypeID { get; set; }

        [NotNull]
        public int Quantity { get; set; }

        public DateTime UtcCreationTime { get; set; }

        [MaxLength(2), NotNull]
        public string LineCode { get; set; }

        public string LineName { get; set; }

        public DateTime? LastUtcPrintingTime { get; set; }

        public bool? LastPrintingSuccessStatus { get; set; }
    }
}