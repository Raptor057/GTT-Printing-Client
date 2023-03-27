using System.Collections.Generic;

namespace GT.Trace.Labels.App.Persistence.UseCases.FetchLabelsWithFailure
{
    public sealed class FetchLabelsWithFailureResponse
    {
        public FetchLabelsWithFailureResponse(IEnumerable<Dtos.LabelDto> labels)
        {
            Labels = labels;
        }

        public IEnumerable<Dtos.LabelDto> Labels { get; }
    }
}