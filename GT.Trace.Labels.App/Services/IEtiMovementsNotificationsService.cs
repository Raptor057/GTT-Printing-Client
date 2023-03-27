using System;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Services
{
    public interface IEtiMovementsNotificationsService
    {
        Task StartAsync();

        Task OnEtiReturned(string lineCode, string etiNo, string partNo, string componentNo, string pointOfUseCode, string operatorNo, DateTime utcTimeStamp);
    }
}