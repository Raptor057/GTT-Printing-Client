using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.UseCases.Persistence.GetPrintingSettings;
using GT.Trace.Labels.App.UseCases.Persistence.SavePrintingSetting;
using MediatR;
using System.ComponentModel;

namespace GT.Trace.Labels.WpfPrintingClient.Settings
{
    [DisplayName("Configuración de Impresión")]
    public sealed class PrintingConfiguration
    {
        private readonly IMediator _mediator;

        public PrintingConfiguration(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Initialize()
        {
            var response = _mediator.Send(new GetPrintingSettingsRequest()).GetAwaiter().GetResult();
            var settings = response.Settings;
            AteqLabel = new PrinterSettings(settings.AteqPrinter, settings.AteqCopies, Save);
            JuniorLabel = new PrinterSettings(settings.JuniorPrinter, settings.JuniorCopies, Save);
            MasterLabel = new PrinterSettings(settings.MasterPrinter, settings.MasterCopies, Save);
            PartialLabel = new PrinterSettings(settings.PartialPrinter, settings.PartialCopies, Save);
            WipLabel = new PrinterSettings(settings.WipPrinter, settings.WipCopies, Save);
            ReturnLabel = new PrinterSettings(settings.ReturnPrinter, settings.ReturnCopies, Save);
            SubAssemblyLabel = new PrinterSettings(settings.SubAssemblyPrinter, settings.SubAssemblyCopies, Save);
            IndividualLabel = new PrinterSettings(settings.IndividualPrinter, settings.IndividualCopies, Save);
            PickingLabel = new PrinterSettings(settings.PickingPrinter, settings.PickingCopies, Save);
        }

        private void Save(SettingDto<string> printerName, SettingDto<int> printCopies)
        {
            _mediator.Send(new SavePrintingSettingRequest(printerName, printCopies));
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("Individual")]
        [Description("Etiqueta para unidades individuales.")]
        public PrinterSettings IndividualLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("Contenedor Parcial")]
        [Description("Etiqueta para contenedores parciales.")]
        public PrinterSettings PartialLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("WIP")]
        [Description("Etiqueta para contenedores pendientes.")]
        public PrinterSettings WipLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("Retorno de Material")]
        [Description("Etiqueta para material de retorno en la línea.")]
        public PrinterSettings ReturnLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("Master")]
        [Description("Etiqueta para tarimas completas.")]
        public PrinterSettings MasterLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("Junior")]
        [Description("Etiqueta para contenedores completos.")]
        public PrinterSettings JuniorLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("Pruebas de Calidad")]
        [Description("Etiqueta para contenedores piezas que se seleccionan para pruebas de calidad.")]
        public PrinterSettings PickingLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("Sub Ensamble")]
        [Description("Etiqueta para material sub ensamble.")]
        public PrinterSettings SubAssemblyLabel { get; set; }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        [DisplayName("ATEQ")]
        [Description("Etiqueta para contenedores ATEQ.")]
        public PrinterSettings AteqLabel { get; set; }
    }
}