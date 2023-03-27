namespace GT.Trace.Labels.App.Dtos
{
    public sealed class PrintingSettingsDto
    {
        public SettingDto<string> AteqPrinter { get; set; }

        public SettingDto<string> JuniorPrinter { get; set; }

        public SettingDto<string> MasterPrinter { get; set; }

        public SettingDto<string> PartialPrinter { get; set; }

        public SettingDto<string> WipPrinter { get; set; }

        public SettingDto<string> IndividualPrinter { get; set; }

        public SettingDto<string> PickingPrinter { get; set; }

        public SettingDto<string> ReturnPrinter { get; set; }

        public SettingDto<string> SubAssemblyPrinter { get; set; }

        public SettingDto<int> AteqCopies { get; set; }

        public SettingDto<int> JuniorCopies { get; set; }

        public SettingDto<int> MasterCopies { get; set; }

        public SettingDto<int> PartialCopies { get; set; }

        public SettingDto<int> WipCopies { get; set; }

        public SettingDto<int> IndividualCopies { get; set; }

        public SettingDto<int> PickingCopies { get; set; }

        public SettingDto<int> ReturnCopies { get; set; }

        public SettingDto<int> SubAssemblyCopies { get; set; }
    }
}