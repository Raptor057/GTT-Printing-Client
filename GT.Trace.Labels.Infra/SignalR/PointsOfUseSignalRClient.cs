using GT.Trace.Labels.App.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace GT.Trace.Labels.Infra.SignalR
{
    internal sealed class PointsOfUseSignalRClient : SignalRClient
    {
        public PointsOfUseSignalRClient(IConfigurationRoot configuration, IMessageBusService messageBus)
            : base("Points Of Use Client", configuration, messageBus)
        { }

        public override async Task Start()
        {
            On<string, long, string, string, string, int, DateTime>("EtiCreated", OnSubAssemblyCreated);
            await base.Start().ConfigureAwait(false);
        }

        private Task OnSubAssemblyCreated(string lineCode, long etiID, string partNo, string revision, string partDescription, int quantity, DateTime utcTimeStamp)
        {
            //if (string.Compare(LineCode, lineCode, true) != 0)
            //{
            //    return Task.CompletedTask;
            //}
            //var request = new PrintSubAssemblyEtiRequest(lineCode)
            //{
            //    EtiID = etiID,
            //    UtcTimeStamp = utcTimeStamp,
            //    CreationTime = utcTimeStamp.ToLocalTime(),
            //    PartNo = partNo,
            //    PartDescription = partDescription,
            //    Revision = revision,
            //    Quantity = quantity
            //};
            //Notifications.Raise("OnSubAssemblyCreated", request);
            return Task.CompletedTask;
        }
    }
}