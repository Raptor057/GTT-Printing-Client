using GT.Trace.Labels.Templates.Services;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GT.Trace.PrintingCompanion
{
    public partial class SelectPrinterForm : Form
    {
        private readonly PrintService _printService;

        public SelectPrinterForm(PrinterName selectedPrinter, PrintService printService)
        {
            InitializeComponent();

            _printService = printService;

            SelectedPrinter = selectedPrinter;
        }

        public PrinterName SelectedPrinter { get; private set; }

        private void SelectPrinterForm_Load(object sender, EventArgs e)
        {
            foreach (string printerName in _printService.GetInstalledPrintersOnline())
            {
                _ = InstalledPrintersListBox.Items.Add(printerName);
            }
            if (SelectedPrinter != null)
            {
                _ = InstalledPrintersListBox.FindString(SelectedPrinter?.Value);
            }
            StatusLabel.Text = $"Printers found: {InstalledPrintersListBox.Items.Count}";
        }

        private void InstalledPrintersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstalledPrintersListBox.SelectedIndex >= 0)
            {
                SelectedPrinter = new PrinterName(InstalledPrintersListBox.SelectedItem.ToString());
            }
            else
            {
                SelectedPrinter = null;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void InstalledPrintersListBox_DoubleClick(object sender, EventArgs e)
        {
            Finish();
        }

        private void Finish()
        {
            if (SelectedPrinter != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                InstalledPrintersListBox.Focus();
            }
        }
    }
}