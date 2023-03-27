using GT.Trace.Labels.App.UseCases.Printing.FetchPrinters;
using MediatR;
using System.Collections.ObjectModel;

namespace GT.Trace.Labels.WpfPrintingClient.Windows.PrinterSelection
{
    public sealed class PrinterSelectionViewModel
    {
        private readonly IMediator _mediator;

        public PrinterSelectionViewModel(IMediator mediator)
        {
            _mediator = mediator;
            UpdatePrinters();
        }

        public int SelectedPrinterIndex { get; set; } = -1;

        public ObservableCollection<string> Printers { get; } = new ObservableCollection<string>();

        /// <summary>
        /// Update local list of printers.
        /// </summary>
        public void UpdatePrinters()
        {
            var response = _mediator.Send(new FetchPrintersRequest()).GetAwaiter().GetResult();
            App.Current.Dispatcher.Invoke(delegate
            {
                Printers.Clear();
                foreach (var printer in response.Printers)
                {
                    Printers.Add(printer);
                }
            });
        }

        public string GetSelectedPrinter()
        {
            if (SelectedPrinterIndex < 0 || SelectedPrinterIndex >= Printers.Count)
            {
                return string.Empty;
            }

            var printer = Printers[SelectedPrinterIndex];
            if (string.IsNullOrWhiteSpace(printer))
            {
                return string.Empty;
            }

            return printer;
        }
    }
}