using GT.Trace.Labels.App.Gateways;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.UseCases.Persistence.SavePrintingSetting
{
    internal sealed class SavePrintingSettingHandler : IRequestHandler<SavePrintingSettingRequest>
    {
        private readonly ISettingsGateway _settings;

        public SavePrintingSettingHandler(ISettingsGateway settings)
        {
            _settings = settings;
        }

        public Task<Unit> Handle(SavePrintingSettingRequest request, CancellationToken cancellationToken)
        {
            _ = _settings.Save(request.PrintCopies);
            _ = _settings.Save(request.PrinterName);
            return Unit.Task;
        }
    }
}