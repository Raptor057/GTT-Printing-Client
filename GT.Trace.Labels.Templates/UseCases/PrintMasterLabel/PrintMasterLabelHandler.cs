using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Templates.UseCases.PrintMasterLabel
{
    internal class PrintMasterLabelHandler : IRequestHandler<PrintMasterLabelRequest>
    {
        public Task<Unit> Handle(PrintMasterLabelRequest request, CancellationToken cancellationToken)
        {
            using (MasterLabel label = new MasterLabel(
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
                request.Approver,
                request.ApprovalDate,
                //Se agrega el Origen para ingresar en las etiquetas.
                request.Origen))
            {
                label.CreateAndPrintDocument(request);
            }

            return Unit.Task;
        }
    }
}