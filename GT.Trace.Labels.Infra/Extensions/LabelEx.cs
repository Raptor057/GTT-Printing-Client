using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.Infra.DataStores.SqlDB.Entities;

namespace GT.Trace.Labels.Infra.Extensions
{
    internal static class LabelEx
    {
        public static LabelDto ToDto(this Label entity)
        {
            return new LabelDto((LabelTypes)entity.LabelTypeID)
            {
                CreationTime = entity.UtcCreationTime.ToLocalTime(),
                LabelID = entity.LabelID,
                LastPrintingSuccessStatus = entity.LastPrintingSuccessStatus,
                LastPrintingTime = entity.LastUtcPrintingTime,
                LineCode = entity.LineCode,
                Quantity = entity.Quantity
            };
        }
    }
}