using GT.Trace.Labels.App.Dtos;
using System.Collections.Generic;

namespace GT.Trace.Labels.App.Gateways
{
    public interface ISettingsGateway
    {
        SettingDto<string> GetPrinter(LabelTypes labelType);

        SettingDto<int> GetCopies(LabelTypes labelType);

        SettingDto<string> GetLineCode();

        SettingDto<string> GetWipPrinter();

        SettingDto<string> GetMasterPrinter();

        SettingDto<string> GetJuniorPrinter();

        SettingDto<string> GetIndividualPrinter();

        SettingDto<string> GetSubAssemblyPrinter();

        SettingDto<string> GetPickingPrinter();

        SettingDto<string> GetReturnPrinter();

        SettingDto<string> GetPartialPrinter();

        SettingDto<string> GetAteqPrinter();

        SettingDto<int> GetWipCopies();

        SettingDto<int> GetMasterCopies();

        SettingDto<int> GetJuniorCopies();

        SettingDto<int> GetIndividualCopies();

        SettingDto<int> GetSubAssemblyCopies();

        SettingDto<int> GetPickingCopies();

        SettingDto<int> GetReturnCopies();

        SettingDto<int> GetPartialCopies();

        SettingDto<int> GetAteqCopies();

        void Save(IEnumerable<SettingDto> settings);

        bool Save(SettingDto setting);
    }
}