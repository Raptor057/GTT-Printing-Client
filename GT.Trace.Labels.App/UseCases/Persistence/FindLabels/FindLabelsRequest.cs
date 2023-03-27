using GT.Trace.Labels.App.Dtos;
using MediatR;
using System;
using System.Collections.Generic;

namespace GT.Trace.Labels.App.UseCases.Persistence.FindLabels
{
    public sealed class FindLabelsRequest : IRequest<FindLabelsResponse>
    {
        public FindLabelsRequest(DateTime date, IEnumerable<LabelTypes> labelTypes)
        {
            Date = date;
            LabelTypes = labelTypes;
        }

        public DateTime Date { get; }

        public IEnumerable<LabelTypes> LabelTypes { get; }
    }
}