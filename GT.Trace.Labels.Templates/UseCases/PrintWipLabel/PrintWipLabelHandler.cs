using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintWipLabel
{
    internal class PrintWipLabelHandler : IRequestHandler<PrintWipLabelRequest>
    {
        public Task<Unit> Handle(PrintWipLabelRequest request, CancellationToken cancellationToken)
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
                request.LabelID,
                false, true, false))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}