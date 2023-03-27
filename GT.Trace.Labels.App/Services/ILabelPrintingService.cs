using GT.Trace.Labels.App.Dtos;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Services
{
    public interface ILabelPrintingService
    {
        Task PrintLabelAsync(IndividualLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(PickingLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(PartialLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(MasterLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(JuniorLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(AteqLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(ReturnLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(SubAssemblyLabelDto label, string printerName, string serverName, int printCopies);

        Task PrintLabelAsync(WipLabelDto label, string printerName, string serverName, int printCopies);
    }
}