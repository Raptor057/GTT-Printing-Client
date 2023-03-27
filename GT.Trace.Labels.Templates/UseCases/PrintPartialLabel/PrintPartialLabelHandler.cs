using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintPartialLabel
{
    internal class PrintPartialLabelHandler : IRequestHandler<PrintPartialLabelRequest>
    {
        public Task<Unit> Handle(PrintPartialLabelRequest request, CancellationToken cancellationToken)
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
                true, false, false))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}