using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Persistence.UseCases.AddLabel
{
    internal sealed class AddLabelHandler<T> : IRequestHandler<AddLabelRequest<T>, AddLabelResponse<T>>
        where T : class
    {
        private readonly Gateways.ILabelGateway _gateway;

        public AddLabelHandler(Gateways.ILabelGateway gateway)
        {
            _gateway = gateway;
        }

        public Task<AddLabelResponse<T>> Handle(AddLabelRequest<T> request, CancellationToken cancellationToken)
        {
            if (_gateway.SaveLabel(request.LabelData))
            {
                return Task.FromResult(new AddLabelResponse<T>(request.LabelData));
            }
            return Task.FromResult(new AddLabelResponse<T>());
        }
    }
}