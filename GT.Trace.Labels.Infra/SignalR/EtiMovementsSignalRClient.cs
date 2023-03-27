using GT.Trace.Labels.App.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Infra.SignalR
{
    internal sealed class EtiMovementsSignalRClient : SignalRClient
    {
        public EtiMovementsSignalRClient(IConfigurationRoot configuration, IMessageBusService messageBus)
            : base("Eti Movements Client", configuration, messageBus)
        { }

        public override async Task Start()
        {
            On<string, string, string, string, string, string, DateTime>("EtiReturned", OnEtiReturned);
            await base.Start().ConfigureAwait(false);
        }

        private Task OnEtiReturned(string lineCode, string etiNo, string partNo, string componentNo, string pointOfUseCode, string operatorNo, DateTime utcTimeStamp)
        {
            //Notifications.Add($"Mensaje recibido: retorno de material {lineCode} / {etiNo}.");
            //if (string.Compare(LineCode, lineCode, true) != 0)
            //{
            //    return Task.CompletedTask;
            //}

            //PrintReturnLabelRequest request = new PrintReturnLabelRequest
            //{
            //    LineCode = lineCode,
            //    EtiNo = etiNo,
            //    UtcTimeStamp = utcTimeStamp,
            //    ComponentNo = componentNo,
            //    OperatorNo = operatorNo,
            //    PartNo = partNo,
            //    PointOfUseCode = pointOfUseCode
            //};
            //Notifications.Raise("OnMaterialReturned", request);
            return Task.CompletedTask;
        }
    }
}