using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.UseCases.Notifications.EnsureLineCode
{
    internal sealed class EnsureLineCodeHandler : IRequestHandler<EnsureLineCodeRequest, EnsureLineCodeResponse>
    {
        private readonly ISettingsGateway _settings;

        public EnsureLineCodeHandler(ISettingsGateway settings)
        {
            _settings = settings;
        }

        public Task<EnsureLineCodeResponse> Handle(EnsureLineCodeRequest request, CancellationToken cancellationToken)
        {
            SettingDto<string> lineCodeSetting = _settings.GetLineCode();
            EnsureLineCodeResponse response = new EnsureLineCodeResponse(!string.IsNullOrWhiteSpace(lineCodeSetting.Value));
            return Task.FromResult(response);
        }
    }
}