using GT.Trace.Labels.App.Dtos;
using MediatR;

namespace GT.Trace.Labels.App.UseCases.Persistence.SavePrintingSetting
{
    public sealed class SavePrintingSettingRequest : IRequest
    {
        public SavePrintingSettingRequest(SettingDto<string> printerName, SettingDto<int> printCopies)
        {
            PrinterName = printerName;
            PrintCopies = printCopies;
        }

        public SettingDto<string> PrinterName { get; }

        public SettingDto<int> PrintCopies { get; }
    }
}