using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Gateways;
using GT.Trace.Labels.Infra.DataStores.SqlDB;
using GT.Trace.Labels.Infra.DataStores.SqlDB.Entities;
using System;
using System.Collections.Generic;

namespace GT.Trace.Labels.Infra.Gateways
{
    internal sealed class SQLiteSettingsGateway : ISettingsGateway
    {
        private readonly SQLiteSettingsDao _dao;

        public SQLiteSettingsGateway(SQLiteSettingsDao dao)
        {
            _dao = dao;
        }

        public SettingDto<string> GetLineCode()
        {
            Setting setting = _dao.Get("LineCode");
            return new SettingDto<string>(setting.Key, Convert.ToString(setting.Value));
        }

        public SettingDto<int> GetAteqCopies()
        {
            return GetCopies(LabelTypes.Ateq);
        }

        public SettingDto<string> GetAteqPrinter()
        {
            return GetPrinter(LabelTypes.Ateq);
        }

        public SettingDto<int> GetIndividualCopies()
        {
            return GetCopies(LabelTypes.Individual);
        }

        public SettingDto<string> GetIndividualPrinter()
        {
            return GetPrinter(LabelTypes.Individual);
        }

        public SettingDto<int> GetJuniorCopies()
        {
            return GetCopies(LabelTypes.Junior);
        }

        public SettingDto<string> GetJuniorPrinter()
        {
            return GetPrinter(LabelTypes.Junior);
        }

        public SettingDto<int> GetMasterCopies()
        {
            return GetCopies(LabelTypes.Master);
        }

        public SettingDto<string> GetMasterPrinter()
        {
            return GetPrinter(LabelTypes.Master);
        }

        public SettingDto<int> GetPartialCopies()
        {
            return GetCopies(LabelTypes.Partial);
        }

        public SettingDto<string> GetPartialPrinter()
        {
            return GetPrinter(LabelTypes.Partial);
        }

        public SettingDto<int> GetPickingCopies()
        {
            return GetCopies(LabelTypes.Picking);
        }

        public SettingDto<string> GetPickingPrinter()
        {
            return GetPrinter(LabelTypes.Picking);
        }

        public SettingDto<int> GetReturnCopies()
        {
            return GetCopies(LabelTypes.Return);
        }

        public SettingDto<string> GetReturnPrinter()
        {
            return GetPrinter(LabelTypes.Return);
        }

        public SettingDto<int> GetSubAssemblyCopies()
        {
            return GetCopies(LabelTypes.SubAssembly);
        }

        public SettingDto<string> GetSubAssemblyPrinter()
        {
            return GetPrinter(LabelTypes.SubAssembly);
        }

        public SettingDto<int> GetWipCopies()
        {
            return GetCopies(LabelTypes.Wip);
        }

        public SettingDto<string> GetWipPrinter()
        {
            return GetPrinter(LabelTypes.Wip);
        }

        public void Save(IEnumerable<SettingDto> settings)
        {
            foreach (SettingDto item in settings)
            {
                _ = _dao.Set(item.Key, item.Value);
            }
        }

        public bool Save(SettingDto setting)
        {
            return _dao.Set(setting.Key, setting.Value);
        }

        public SettingDto<string> GetPrinter(LabelTypes labelType)
        {
            string key = $"{labelType}_Printer";
            Setting setting = _dao.Get(key);
            return new SettingDto<string>(setting.Key, Convert.ToString(setting.Value));
        }

        public SettingDto<int> GetCopies(LabelTypes labelType)
        {
            string key = $"{labelType}_Copies";
            Setting setting = _dao.Get(key);
            return new SettingDto<int>(setting.Key, int.TryParse(setting.Value, out int value) ? value : 1);
        }
    }
}