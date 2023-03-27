using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintPickingLabel
{
    internal class PrintPickingLabelHandler : IRequestHandler<PrintPickingLabelRequest>
    {
        public Task<Unit> Handle(PrintPickingLabelRequest request, CancellationToken cancellationToken)
        {
            using (PickingUnitLabel label = new PickingUnitLabel(
                request.ProtoID,
                request.LineCode,
                request.UnitID))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}