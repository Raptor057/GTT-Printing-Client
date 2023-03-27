using System.Windows;
using System.Windows.Input;

namespace GT.Trace.Labels.WpfPrintingClient.Windows.PrinterSelection
{
    /// <summary>
    /// Interaction logic for PrinterSelectionWindow.xaml
    /// </summary>
    public partial class PrinterSelectionWindow : Window
    {
        public PrinterSelectionWindow(PrinterSelectionViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public void HandleCancelButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void HandleAcceptButtonClick(object sender, RoutedEventArgs e)
        {
            Accept();
        }

        private void HandlePrintersListMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Accept();
        }

        private void Accept()
        {
            var viewModel = (DataContext as PrinterSelectionViewModel);
            var printer = viewModel.GetSelectedPrinter();
            if (!string.IsNullOrWhiteSpace(printer))
            {
                Tag = printer;
                DialogResult = true;
                Close();
            }
        }
    }
}