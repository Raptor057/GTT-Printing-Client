using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.UseCases.Persistence.SaveLineCode
{
    internal sealed class SaveLineCodeHandler : IRequestHandler<SaveLineCodeRequest, SaveLineCodeResponse>
    {
        private readonly ISettingsGateway _settings;

        public SaveLineCodeHandler(ISettingsGateway settings)
        {
            _settings = settings;
        }

        public Task<SaveLineCodeResponse> Handle(SaveLineCodeRequest request, CancellationToken cancellationToken)
        {
            SettingDto lineCodeSetting = _settings.GetLineCode();
            lineCodeSetting.Value = request.LineCode;
            bool result = _settings.Save(lineCodeSetting);
            SaveLineCodeResponse response = new SaveLineCodeResponse(result);
            return Task.FromResult(response);
        }
    }
}