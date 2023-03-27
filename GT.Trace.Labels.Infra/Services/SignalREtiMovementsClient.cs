using GT.Trace.Labels.App;
using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using GT.Trace.Labels.App.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Infra.Services
{
    internal sealed class SignalREtiMovementsClient : SignalR.SignalRClient, IEtiMovementsNotificationsService
    {
        private readonly LineCode _lineCode;

        private readonly ILabelGateway _labels;

        public SignalREtiMovementsClient(IConfigurationRoot configuration, IMessageBusService messageBus, LineCode lineCode, ILabelGateway labels)
            : base("Eti Movements Client", configuration, messageBus)
        {
            _lineCode = lineCode;
            _labels = labels;
        }

        public async Task StartAsync()
        {
            On<string, string, string, string, string, string, DateTime>("EtiReturned", OnEtiReturned);
            await Start().ConfigureAwait(false);
        }

        public Task OnEtiReturned(string lineCode, string etiNo, string partNo, string componentNo, string pointOfUseCode, string operatorNo, DateTime utcTimeStamp)
        {
            if (string.Compare(lineCode, _lineCode.Value, true) == 0)
            {
                MessageBus.PassMessage("Etiqueta de retorno de material recibida.");
                DateTime date = DateTime.Now;
                _labels.SaveLabel(new ReturnLabelDto
                {
                    ComponentNo = componentNo,
                    CreationTime = date,
                    EmployeeName = operatorNo,
                    EtiNo = etiNo,
                    LineCode = lineCode,
                    Quantity = 1,
                    PointOfUseCode = pointOfUseCode
                });
            }
            return Task.CompletedTask;
        }
    }
}