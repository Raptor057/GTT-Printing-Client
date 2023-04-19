using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using GT.Trace.Labels.App.Services;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.UseCases.Printing.PrintLabel
{
    internal sealed class PrintLabelHandler : IRequestHandler<PrintLabelRequest, PrintLabelResponse>
    {
        private readonly ILabelGateway _labels;

        private readonly ISettingsGateway _settings;

        private readonly IPrintersService _printers;

        private readonly ILabelPrintingService _labelPrinting;

        public PrintLabelHandler(ILabelGateway labels, ISettingsGateway settings, IPrintersService printers, ILabelPrintingService labelPrinting)
        {
            _labels = labels;
            _settings = settings;
            _printers = printers;
            _labelPrinting = labelPrinting;
        }

        public bool CheckIfParametersAreValid(string printerName, string serverName, int printCopies, out List<string> errors)
        {
            errors = new List<string>();
            if (string.IsNullOrWhiteSpace(printerName) || string.IsNullOrWhiteSpace(serverName))
            {
                errors.Add("La impresora o servidor no ha sido especificada.");
            }
            else if (!_printers.PrinterIsOnline(printerName, serverName))
            {
                errors.Add($"La impresora \"{printerName}\" no se encuentra en línea.");
            }
            if (printCopies < 1 || printCopies > 3)
            {
                errors.Add($"El número de copias no es válido [ {printCopies} ]. Sólo se permite un máximo de tres copias.");
            }
            return errors.Count == 0;
        }

        public async Task<PrintLabelResponse> Handle(PrintLabelRequest request, CancellationToken cancellationToken)
        {
            LabelDto label = _labels.FindLabel(request.Label.LabelID) as LabelDto; //Analisar estas 2 lineas NOTA.
            string fullPrinterName = _settings.GetPrinter(label.Type).Value;
            int printCopies = _settings.GetCopies(label.Type).Value;

            _printers.GetPrinterNameAndServer(fullPrinterName, out var printerName, out var serverName);

            if (!CheckIfParametersAreValid(printerName, serverName, printCopies, out List<string> errors))
            {
                _ = _labels.UpdateLabelPrintingStatus(request.Label.LabelID, false);
                return Failure(errors);
            }

            if (label is WipLabelDto wipLabel)
            {
                await _labelPrinting.PrintLabelAsync(wipLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is IndividualLabelDto individualLabel)
            {
                await _labelPrinting.PrintLabelAsync(individualLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is MasterLabelDto masterLabel)
            {
                await _labelPrinting.PrintLabelAsync(masterLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is JuniorLabelDto juniorLabel)
            {
                await _labelPrinting.PrintLabelAsync(juniorLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is PartialLabelDto partialLabel)
            {
                await _labelPrinting.PrintLabelAsync(partialLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is AteqLabelDto ateqLabel)
            {
                await _labelPrinting.PrintLabelAsync(ateqLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is PickingLabelDto pickingLabel)
            {
                await _labelPrinting.PrintLabelAsync(pickingLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is SubAssemblyLabelDto subAssemblyLabel)
            {
                await _labelPrinting.PrintLabelAsync(subAssemblyLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else if (label is ReturnLabelDto returnLabel)
            {
                await _labelPrinting.PrintLabelAsync(returnLabel, printerName, serverName, printCopies).ConfigureAwait(false);
            }
            else
            {
                _ = _labels.UpdateLabelPrintingStatus(request.Label.LabelID, false);
                return Failure($"Tipo de etiqueta desconocido: {label.Type}.");
            }

            _ = _labels.UpdateLabelPrintingStatus(request.Label.LabelID, true);

            return new PrintLabelResponse($"Etiqueta {request.Label.Type} enviada a la impresora {fullPrinterName} x{printCopies}.", true);
        }

        private PrintLabelResponse Failure(string message)
        {
            return new PrintLabelResponse(message, false);
        }

        private PrintLabelResponse Failure(List<string> errors)
        {
            return Failure(errors.Aggregate((a, b) => $"{a}\n- {b}"));
        }
    }
}