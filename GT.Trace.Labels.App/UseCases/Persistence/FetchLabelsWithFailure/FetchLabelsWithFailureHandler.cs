using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Persistence.UseCases.FetchLabelsWithFailure
{
    internal sealed class FetchLabelsWithFailureHandler : IRequestHandler<FetchLabelsWithFailureRequest, FetchLabelsWithFailureResponse>
    {
        private readonly Gateways.ILabelGateway _gateway;

        public FetchLabelsWithFailureHandler(Gateways.ILabelGateway gateway)
        {
            _gateway = gateway;
        }

        public Task<FetchLabelsWithFailureResponse> Handle(FetchLabelsWithFailureRequest request, CancellationToken cancellationToken)
        {
            var labels = _gateway.FetchNewLabels();
            return Task.FromResult(new FetchLabelsWithFailureResponse(labels));
        }
    }
}