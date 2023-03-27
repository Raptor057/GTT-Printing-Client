using System.Collections.Generic;

namespace GT.Trace.Labels.App.Persistence.UseCases.FetchNewLabels
{
    public sealed class FetchNewLabelsResponse
    {
        public FetchNewLabelsResponse(IEnumerable<Dtos.LabelDto> labels)
        {
            Labels = labels;
        }

        public IEnumerable<Dtos.LabelDto> Labels { get; }
    }
}