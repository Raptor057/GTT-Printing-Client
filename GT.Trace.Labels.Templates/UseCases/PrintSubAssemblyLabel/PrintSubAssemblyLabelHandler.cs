using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintSubAssemblyLabel
{
    internal class PrintSubAssemblyLabelHandler : IRequestHandler<PrintSubAssemblyLabelRequest>
    {
        public Task<Unit> Handle(PrintSubAssemblyLabelRequest request, CancellationToken cancellationToken)
        {
            using (SubAssemblyEtiLabel label = new SubAssemblyEtiLabel(
                request.Folio,
                request.PartNo,
                request.Revision,
                request.PartDescription,
                request.Quantity,
                request.CreationTime))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}