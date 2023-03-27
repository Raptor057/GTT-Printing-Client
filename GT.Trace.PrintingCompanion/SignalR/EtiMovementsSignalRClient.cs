using GT.Trace.Labels.Templates.UseCases.PrintReturnLabel;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace GT.Trace.PrintingCompanion.SignalR
{
    public sealed class EtiMovementsSignalRClient : SignalRClient
    {
        public EtiMovementsSignalRClient(IConfigurationRoot configuration, Notifications notifications)
            : base("Eti Movements Client", configuration, notifications)
        { }

        public override async Task Start()
        {
            On<string, string, string, string, string, string, DateTime>("EtiReturned", OnEtiReturned);
            await base.Start().ConfigureAwait(false);
        }

        private Task OnEtiReturned(string lineCode, string etiNo, string partNo, string componentNo, string pointOfUseCode, string operatorNo, DateTime utcTimeStamp)
        {
            Notifications.Add($"Mensaje recibido: retorno de material {lineCode} / {etiNo}.");
            if (string.Compare(LineCode, lineCode, true) != 0)
            {
                return Task.CompletedTask;
            }

            PrintReturnLabelRequest request = new PrintReturnLabelRequest
            {
                LineCode = lineCode,
                EtiNo = etiNo,
                UtcTimeStamp = utcTimeStamp,
                ComponentNo = componentNo,
                OperatorNo = operatorNo,
                PartNo = partNo,
                PointOfUseCode = pointOfUseCode
            };
            //Notifications.Raise("OnMaterialReturned", request);
            return Task.CompletedTask;
        }
    }
}