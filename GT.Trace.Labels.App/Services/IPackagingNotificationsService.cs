using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Services
{
    //IPushNotificationsSubService
    public interface IPackagingNotificationsService
    {
        Task StartAsync();

        Task OnUnitPicked(string lineCode, long unitID);

        Task OnPalletComplete(string lineCode, string jsonData);

        Task OnContainerComplete(string lineCode, string jsonData);

        Task OnWip(string lineCode, string jsonData);
    }
}