using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.UseCases.Printing.FetchPrinters
{
    internal sealed class FetchPrintersHandler : IRequestHandler<FetchPrintersRequest, FetchPrintersResponse>
    {
        private readonly Services.IPrintersService _printing;

        public FetchPrintersHandler(Services.IPrintersService printing)
        {
            _printing = printing;
        }

        public Task<FetchPrintersResponse> Handle(FetchPrintersRequest request, CancellationToken cancellationToken)
        {
            var printers = _printing.GetInstalledPrintersOnline();
            return Task.FromResult(new FetchPrintersResponse(printers));
        }
    }
}