using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintAteqLabel
{
    internal class PrintAteqLabelHandler : IRequestHandler<PrintAteqLabelRequest>
    {
        public Task<Unit> Handle(PrintAteqLabelRequest request, CancellationToken cancellationToken)
        {
            using (WipLabel label = new WipLabel(
                request.PurchaseOrderNo,
                request.JulianDate,
                request.CustomerPartNo,
                request.Revision,
                request.PartNo,
                request.Customer,
                request.PartDescription,
                request.Date,
                request.Quantity,
                request.LineName,
                request.MasterID,
                false, false, true))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}