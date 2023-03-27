using GT.Trace.Labels.App.Dtos;
using System;
using System.Collections.Generic;

namespace GT.Trace.Labels.App.Gateways
{
    public interface ILabelGateway
    {
        object FindLabel(long labelID);

        /// <summary>
        /// Fetch labels to be printed for the first time.
        /// </summary>
        /// <returns>An enumeration of label objects.</returns>
        IEnumerable<LabelDto> FetchNewLabels();

        /// <summary>
        /// Fetch junior labels wich failed to be printed.
        /// </summary>
        /// <returns>An enumeration of junior labels.</returns>
        IEnumerable<LabelDto> FetchLabelsWithFailure();

        bool SaveLabel<T>(T label);

        bool UpdateLabelPrintingStatus(long labelID, bool isSuccess);

        IEnumerable<LabelDto> Find(DateTime date, IEnumerable<LabelTypes> labelTypes);
    }
}