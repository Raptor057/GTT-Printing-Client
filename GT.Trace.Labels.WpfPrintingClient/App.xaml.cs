using GT.Trace.Labels.App;
using GT.Trace.Labels.Infra;
using GT.Trace.Labels.WpfPrintingClient.Settings;
using GT.Trace.Labels.WpfPrintingClient.Windows.PrinterSelection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using MediatR;
using GT.Trace.Labels.App.UseCases.Notifications.EnsureLineCode;
using GT.Trace.Labels.WpfPrintingClient.Windows.PromptLineCode;
using System;
using GT.Trace.Labels.WpfPrintingClient.Windows.MainWindow;

namespace GT.Trace.Labels.WpfPrintingClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
            Dispatcher.UnhandledException += Application_DispatcherUnhandledException;

            Services = new ServiceCollection()
                .AddAppServices()
                .AddInfraServices()
                .AddTransient<PendingRequestListUpdater>()
                .AddTransient<PendingRequestListPrinter>()
                .AddTransient<PendingRequestListProcessor>()
                .AddSingleton<PrintingRequestList>()
                .AddSingleton<PrintingConfiguration>()
                .AddSingleton(
                    new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", false, true)
                    .Build())
                .AddTransient<PromptLineCodeWindow>()
                .AddTransient<MainWindow>()
                .AddTransient<MainViewModel>()
                .AddTransient<ArchiveViewModel>()
                .AddTransient<PrinterSelectionWindow>()
                .AddTransient<PrinterSelectionViewModel>()
                .BuildServiceProvider();

            EnsureLineCodeResponse response = Services.GetService<IMediator>().Send(new EnsureLineCodeRequest()).GetAwaiter().GetResult();
            if (!response.IsSet)
            {
                Window dialog = Services.GetService<PromptLineCodeWindow>();
                bool result = dialog.ShowDialog() ?? false;
                if (!result)
                {
                    return;
                }
            }
            Services.GetService<MainWindow>().Show();
        }

        public ServiceProvider Services { get; private set; }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }

        private static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            MessageBox.Show(args.ExceptionObject.ToString());
        }
    }
}