using GT.Trace.Labels.App;
using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using GT.Trace.Labels.App.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Infra.Services
{
    internal sealed class SignalRPointsOfUseClient : SignalR.SignalRClient, IPointsOfUseNotificationsService
    {
        private readonly LineCode _lineCode;

        private readonly ILabelGateway _labels;

        public SignalRPointsOfUseClient(IConfigurationRoot configuration, IMessageBusService messageBus, LineCode lineCode, ILabelGateway labels)
            : base("Points Of Use Client", configuration, messageBus)
        {
            _lineCode = lineCode;
            _labels = labels;
        }

        public Task OnSubAssemblyCreated(string lineCode, long etiID, string partNo, string revision, string partDescription, int quantity, DateTime utcTimeStamp)
        {
            if (string.Compare(lineCode, _lineCode.Value, true) == 0)
            {
                MessageBus.PassMessage("Etiqueta de Sub Ensamble recibida.");
                DateTime date = DateTime.Now;
                _labels.SaveLabel(new SubAssemblyLabelDto
                {
                    CreationTime = date,
                    EtiID = etiID,
                    LineCode = lineCode,
                    PartDescription = partDescription,
                    PartNo = partNo,
                    Quantity = quantity,
                    Revision = revision,
                });
            }
            return Task.CompletedTask;
        }

        public async Task StartAsync()
        {
            await Start().ConfigureAwait(false);
        }
    }
}