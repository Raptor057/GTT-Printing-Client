using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintReturnLabel
{
    internal class PrintReturnLabelHandler : IRequestHandler<PrintReturnLabelRequest>
    {
        public Task<Unit> Handle(PrintReturnLabelRequest request, CancellationToken cancellationToken)
        {
            using (MaterialReturnLabel label = new MaterialReturnLabel(
                request.EtiNo,
                request.ComponentNo,
                request.EmployeeName,
                request.LineName,
                request.PartNo,
                request.CreationTime,
                request.PointOfUseCode))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}