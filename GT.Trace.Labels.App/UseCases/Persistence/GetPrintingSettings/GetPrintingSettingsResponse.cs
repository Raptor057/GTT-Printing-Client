using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.UseCases.Persistence.GetPrintingSettings
{
    public sealed class GetPrintingSettingsResponse
    {
        public GetPrintingSettingsResponse(PrintingSettingsDto settings)
        {
            Settings = settings;
        }

        public PrintingSettingsDto Settings { get; }
    }

    internal sealed class GetPrintingSettingsHandle : IRequestHandler<GetPrintingSettingsRequest, GetPrintingSettingsResponse>
    {
        private readonly ISettingsGateway _settings;

        public GetPrintingSettingsHandle(ISettingsGateway settings)
        {
            _settings = settings;
        }

        public Task<GetPrintingSettingsResponse> Handle(GetPrintingSettingsRequest request, CancellationToken cancellationToken)
        {
            PrintingSettingsDto settings = new PrintingSettingsDto
            {
                AteqCopies = _settings.GetAteqCopies(),
                AteqPrinter = _settings.GetAteqPrinter(),
                IndividualCopies = _settings.GetIndividualCopies(),
                IndividualPrinter = _settings.GetIndividualPrinter(),
                JuniorCopies = _settings.GetJuniorCopies(),
                JuniorPrinter = _settings.GetJuniorPrinter(),
                MasterCopies = _settings.GetMasterCopies(),
                MasterPrinter = _settings.GetMasterPrinter(),
                PartialCopies = _settings.GetPartialCopies(),
                PartialPrinter = _settings.GetPartialPrinter(),
                PickingCopies = _settings.GetPickingCopies(),
                PickingPrinter = _settings.GetPickingPrinter(),
                ReturnCopies = _settings.GetReturnCopies(),
                ReturnPrinter = _settings.GetReturnPrinter(),
                SubAssemblyCopies = _settings.GetSubAssemblyCopies(),
                SubAssemblyPrinter = _settings.GetSubAssemblyPrinter(),
                WipCopies = _settings.GetWipCopies(),
                WipPrinter = _settings.GetWipPrinter()
            };
            return Task.FromResult(new GetPrintingSettingsResponse(settings));
        }
    }
}