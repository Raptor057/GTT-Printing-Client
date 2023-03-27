using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintIndividualLabel
{
    internal class PrintIndividualLabelHandler : IRequestHandler<PrintIndividualLabelRequest>
    {
        public Task<Unit> Handle(PrintIndividualLabelRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}