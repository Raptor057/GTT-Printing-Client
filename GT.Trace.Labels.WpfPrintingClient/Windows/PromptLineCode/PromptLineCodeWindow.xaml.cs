using GT.Trace.Labels.App.UseCases.Notifications.EnsureLineCode;
using GT.Trace.Labels.App.UseCases.Persistence.SaveLineCode;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace GT.Trace.Labels.WpfPrintingClient.Windows.PromptLineCode
{
    /// <summary>
    /// Interaction logic for PromptLineCodeWindow.xaml
    /// </summary>
    public partial class PromptLineCodeWindow : Window
    {
        private readonly IMediator _mediator;

        public PromptLineCodeWindow(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string lineCode = LineCodeInput.Text.Trim();
            if (!string.IsNullOrWhiteSpace(lineCode))
            {
                SaveLineCodeResponse response = _mediator.Send(new SaveLineCodeRequest(lineCode)).GetAwaiter().GetResult();
                if (response.IsSuccess)
                {
                    DialogResult = true;
                    Close();
                }
            }
            _ = LineCodeInput.Focus();
        }
    }
}