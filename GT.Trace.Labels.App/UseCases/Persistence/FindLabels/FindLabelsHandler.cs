using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.UseCases.Persistence.FindLabels
{
    internal sealed class FindLabelsHandler : IRequestHandler<FindLabelsRequest, FindLabelsResponse>
    {
        private readonly ILabelGateway _labels;

        public FindLabelsHandler(ILabelGateway labels)
        {
            _labels = labels;
        }

        public Task<FindLabelsResponse> Handle(FindLabelsRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<LabelDto> labels = _labels.Find(request.Date, request.LabelTypes);
            return Task.FromResult(new FindLabelsResponse(labels));
        }
    }
}