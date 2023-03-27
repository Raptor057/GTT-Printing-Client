using GT.Trace.Labels.Templates.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GT.Trace.Labels.WpfPrintingClient
{
    /// <summary>
    /// Interaction logic for PrinterSelectionWindow.xaml
    /// </summary>
    public partial class PrinterSelectionWindow : Window
    {
        private readonly PrintService _printService;

        public PrinterSelectionWindow(PrinterName selectedPrinter, PrintService printService)
        {
            InitializeComponent();

            _printService = printService;

            SelectedPrinter = selectedPrinter;
        }

        public PrinterName SelectedPrinter { get; private set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string printerName in _printService.GetInstalledPrintersOnline())
            {
                _ = InstalledPrintersListBox.Items.Add(printerName);
            }
            if (SelectedPrinter != null)
            {
                _ = InstalledPrintersListBox.SelectedItem = SelectedPrinter;
            }
            StatusLabel.Content = $"Printers found: {InstalledPrintersListBox.Items.Count}";
        }

        private void InstalledPrintersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPrinter = InstalledPrintersListBox.SelectedIndex >= 0
                ? new PrinterName(InstalledPrintersListBox.SelectedItem.ToString())
                : null;
        }

        private void Finish()
        {
            DialogResult = SelectedPrinter != null;
            if (DialogResult ?? false)
            {
                _ = InstalledPrintersListBox.Focus();
            }
        }

        private void InstalledPrintersListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Finish();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            Finish();
        }
    }
}