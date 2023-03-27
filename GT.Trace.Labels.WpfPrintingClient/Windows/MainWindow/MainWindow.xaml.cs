using GT.Trace.Labels.App.Services;
using System;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;

namespace GT.Trace.Labels.WpfPrintingClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly NotifyIcon _trayIcon;

        public MainWindow(MainViewModel viewModel, IMessageBusService messageBus)
        {
            InitializeComponent();
            DataContext = viewModel;

            _trayIcon = new NotifyIcon()
            {
                Visible = false,
                Icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location)
            };
            _trayIcon.Click += (sender, e) =>
            {
                WindowState = WindowState.Normal;
                OnStateChanged(e);
            };
            messageBus.OnMessage += ShowBalloonTooltip;
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
            {
                Visibility = Visibility.Hidden;
                ShowInTaskbar = false;
                _trayIcon.Visible = true;
                ShowBalloonTooltip("La aplicación continúa ejecutándose.");
            }
            else
            {
                _trayIcon.Visible = false;
                Visibility = Visibility.Visible;
                ShowInTaskbar = true;
                Focus();
            }

            base.OnStateChanged(e);
        }

        private void ShowBalloonTooltip(string message)
        {
            if (_trayIcon.Visible)
            {
                App.Current.Dispatcher.Invoke(delegate
                {
                    _trayIcon.ShowBalloonTip(2000, Title, message, ToolTipIcon.Info);
                });
            }
        }
    }
}