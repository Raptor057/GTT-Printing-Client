using System;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Services
{
    public interface IPointsOfUseNotificationsService
    {
        Task StartAsync();

        Task OnSubAssemblyCreated(string lineCode, long etiID, string partNo, string revision, string partDescription, int quantity, DateTime utcTimeStamp);
    }
}