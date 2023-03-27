using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintJuniorLabel
{
    internal class PrintJuniorLabelHandler : IRequestHandler<PrintJuniorLabelRequest>
    {
        public Task<Unit> Handle(PrintJuniorLabelRequest request, CancellationToken cancellationToken)
        {
            using (JuniorLabel label = new JuniorLabel(
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
                request.Approver,
                request.ApprovalDate))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}