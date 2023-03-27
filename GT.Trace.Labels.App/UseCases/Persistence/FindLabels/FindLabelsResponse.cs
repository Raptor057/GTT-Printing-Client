using GT.Trace.Labels.App.Dtos;
using System.Collections.Generic;

namespace GT.Trace.Labels.App.UseCases.Persistence.FindLabels
{
    public sealed class FindLabelsResponse
    {
        public FindLabelsResponse(IEnumerable<LabelDto> labels)
        {
            Labels = labels;
        }

        public IEnumerable<LabelDto> Labels { get; }
    }
}