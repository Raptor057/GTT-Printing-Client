using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Services;
using GT.Trace.Labels.Templates.UseCases.PrintAteqLabel;
using GT.Trace.Labels.Templates.UseCases.PrintIndividualLabel;
using GT.Trace.Labels.Templates.UseCases.PrintJuniorLabel;
using GT.Trace.Labels.Templates.UseCases.PrintMasterLabel;
using GT.Trace.Labels.Templates.UseCases.PrintPartialLabel;
using GT.Trace.Labels.Templates.UseCases.PrintPickingLabel;
using GT.Trace.Labels.Templates.UseCases.PrintReturnLabel;
using GT.Trace.Labels.Templates.UseCases.PrintSubAssemblyLabel;
using GT.Trace.Labels.Templates.UseCases.PrintWipLabel;
using MediatR;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Infra.Services
{
    internal sealed class DevExpressLabelPrintingService : ILabelPrintingService
    {
        //Estas son las solicitudes de impresion de las etiquetas, aqui ya llegan para ser impresas en la impresora predeterminada
        private readonly IMediator _mediator;

        public DevExpressLabelPrintingService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PrintLabelAsync(IndividualLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintIndividualLabelRequest request = new PrintIndividualLabelRequest(printerName, serverName, printCopies)
            {
                CreationTime = label.CreationTime,
                LabelID = label.LabelID,
                LineCode = label.LineCode,
                Quantity = label.Quantity
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(PickingLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintPickingLabelRequest request = new PrintPickingLabelRequest(printerName, serverName, printCopies)
            {
                CreationTime = label.CreationTime,
                LabelID = label.LabelID,
                LineCode = label.LineCode,
                ProtoID = label.ProtoID,
                Quantity = label.Quantity,
                UnitID = label.UnitID
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(PartialLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintPartialLabelRequest request = new PrintPartialLabelRequest(printerName, serverName, printCopies)
            {
                //ApprovalDate = label.ApprovalDate,
                //Approver = label.Approver,
                CreationTime = label.CreationTime,
                Customer = label.Customer,
                CustomerPartNo = label.CustomerPartNo,
                Date = label.CreationTime,
                JulianDate = label.JulianDate,
                LabelID = label.LabelID,
                LineName = label.LineName,
                PartDescription = label.PartDescription,
                PartNo = label.PartNo,
                PurchaseOrderNo = label.PurchaseOrderNo,
                Quantity = label.Quantity,
                Revision = label.Revision,
                MasterID = label.MasterID.Value,
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(MasterLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintMasterLabelRequest request = new PrintMasterLabelRequest(printerName, serverName, printCopies)
            {
                ApprovalDate = label.ApprovalDate,
                Approver = label.Approver,
                CreationTime = label.CreationTime,
                Customer = label.Customer,
                CustomerPartNo = label.CustomerPartNo,
                Date = label.CreationTime,
                JulianDate = label.JulianDate,
                LabelID = label.LabelID,
                LineName = label.LineName,
                PartDescription = label.PartDescription,
                PartNo = label.PartNo,
                PurchaseOrderNo = label.PurchaseOrderNo,
                Quantity = label.Quantity,
                Revision = label.Revision,
                MasterID = label.MasterID.Value,
                Origen = label.Origen, //Se agrego Campo Origen Faltante RA: 04 / 19 /2023
                Www = label.Www//Se agrego Campo Www Faltante RA: 04 / 16 /2024
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(JuniorLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintJuniorLabelRequest request = new PrintJuniorLabelRequest(printerName, serverName, printCopies)
            {
                ApprovalDate = label.ApprovalDate,
                Approver = label.Approver,
                CreationTime = label.CreationTime,
                Customer = label.Customer,
                CustomerPartNo = label.CustomerPartNo,
                Date = label.CreationTime,
                JulianDate = label.JulianDate,
                LabelID = label.LabelID,
                LineName = label.LineName,
                PartDescription = label.PartDescription,
                PartNo = label.PartNo,
                PurchaseOrderNo = label.PurchaseOrderNo,
                Quantity = label.Quantity,
                Revision = label.Revision
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(AteqLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintAteqLabelRequest request = new PrintAteqLabelRequest(printerName, serverName, printCopies)
            {
                ApprovalDate = label.ApprovalDate,
                Approver = label.Approver,
                CreationTime = label.CreationTime,
                Customer = label.Customer,
                CustomerPartNo = label.CustomerPartNo,
                Date = label.CreationTime,
                JulianDate = label.JulianDate,
                LabelID = label.LabelID,
                LineName = label.LineName,
                PartDescription = label.PartDescription,
                PartNo = label.PartNo,
                PurchaseOrderNo = label.PurchaseOrderNo,
                Quantity = label.Quantity,
                Revision = label.Revision,
                MasterID = label.MasterID.Value,
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(ReturnLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintReturnLabelRequest request = new PrintReturnLabelRequest(printerName, serverName, printCopies)
            {
                ComponentNo = label.ComponentNo,
                CreationTime = label.CreationTime,
                EmployeeName = label.EmployeeName,
                EtiNo = label.EtiNo,
                LabelID = label.LabelID,
                LineName = label.LineName,
                //PartNo = label.part
                PointOfUseCode = label.PointOfUseCode,
                Quantity = label.Quantity
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(SubAssemblyLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintSubAssemblyLabelRequest request = new PrintSubAssemblyLabelRequest(printerName, serverName, printCopies)
            {
                CreationTime = label.CreationTime,
                Folio = label.EtiID,
                LabelID = label.LabelID,
                LineCode = label.LineCode,
                PartDescription = label.PartDescription,
                PartNo = label.PartNo,
                Quantity = label.Quantity
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }

        public async Task PrintLabelAsync(WipLabelDto label, string printerName, string serverName, int printCopies)
        {
            PrintWipLabelRequest request = new PrintWipLabelRequest(printerName, serverName, printCopies)
            {
                ApprovalDate = label.ApprovalDate,
                Approver = label.Approver,
                CreationTime = label.CreationTime,
                Customer = label.Customer,
                CustomerPartNo = label.CustomerPartNo,
                Date = label.CreationTime,
                JulianDate = label.JulianDate,
                LabelID = label.LabelID,
                LineName = label.LineName,
                PartDescription = label.PartDescription,
                PartNo = label.PartNo,
                PurchaseOrderNo = label.PurchaseOrderNo,
                Quantity = label.Quantity,
                Revision = label.Revision
            };
            _ = await _mediator.Send(request).ConfigureAwait(false);
        }
    }
}