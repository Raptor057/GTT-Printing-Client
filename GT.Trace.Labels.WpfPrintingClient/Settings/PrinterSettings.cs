using GT.Trace.Labels.App.Dtos;
using System;
using System.ComponentModel;

namespace GT.Trace.Labels.WpfPrintingClient.Settings
{
    public sealed class PrinterSettings
    {
        private PrinterName _printer;

        private SettingDto<string> _printerName;

        private SettingDto<int> _printCopies;

        private Action<SettingDto<string>, SettingDto<int>> _onChangeCallback;

        public PrinterSettings(SettingDto<string> printerName, SettingDto<int> printCopies, Action<SettingDto<string>, SettingDto<int>> onChangeCallback = null)
        {
            _printCopies = printCopies;
            _printerName = printerName;
            Printer = new PrinterName { Value = printerName.Value };
            _onChangeCallback = onChangeCallback;
        }

        [Editor(typeof(PrinterNameEditor), typeof(PrinterNameEditor))]
        [DisplayName("Impresora")]
        [Description("Nombre de la impresora a utilizar.")]
        public PrinterName Printer
        {
            get => _printer;
            set
            {
                if (_printer == null || value?.Value != _printer?.Value)
                {
                    _printer = value;
                    _printerName.SetValue(value.Value);
                    _onChangeCallback?.Invoke(_printerName, _printCopies);
                }
            }
        }

        [DisplayName("Copias")]
        [Description("Cantidad de copias a imprimir [1, 3].")]
        public int Copies
        {
            get => _printCopies.Value;
            set
            {
                if (value != _printCopies.Value && 1 <= value && value <= 3)
                {
                    _printCopies.SetValue(value);
                    _onChangeCallback?.Invoke(_printerName, _printCopies);
                }
            }
        }

        public override string ToString()
        {
            return $"{Printer}\nx{Copies}";
        }
    }
}