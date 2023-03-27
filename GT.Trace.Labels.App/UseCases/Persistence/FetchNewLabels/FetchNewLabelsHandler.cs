using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Persistence.UseCases.FetchNewLabels
{
    internal sealed class FetchNewLabelsHandler : IRequestHandler<FetchNewLabelsRequest, FetchNewLabelsResponse>
    {
        private readonly Gateways.ILabelGateway _labels;

        public FetchNewLabelsHandler(Gateways.ILabelGateway labels)
        {
            _labels = labels;
        }

        public Task<FetchNewLabelsResponse> Handle(FetchNewLabelsRequest request, CancellationToken cancellationToken)
        {
            var labels = _labels.FetchNewLabels();
            return Task.FromResult(new FetchNewLabelsResponse(labels));
        }
    }
}