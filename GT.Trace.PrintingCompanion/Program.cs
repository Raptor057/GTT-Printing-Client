using GT.Trace.Labels.App;
using GT.Trace.Labels.Infra;
using GT.Trace.Labels.Templates.Services;
using GT.Trace.PrintingCompanion.SignalR;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SqlServer.Data.Tools.ExceptionMessageBox;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace GT.Trace.PrintingCompanion
{
    internal static class Program
    {
        #region - single instance code -

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        // Add "global\" in front of the EventName, then only one instance is allowed on the
        // whole system, including other users. But the application can not be brought
        // into view, of course.
        private static string SingleAppComEventName = "Make up some unique name here, suggestion: use a GUID";

        private static BackgroundWorker singleAppComThread = null;
        private static EventWaitHandle threadComEvent = null;

        private static void CreateInterAppComThread()
        {
            singleAppComThread = new BackgroundWorker();
            singleAppComThread.WorkerReportsProgress = false;
            singleAppComThread.WorkerSupportsCancellation = true;
            singleAppComThread.DoWork += new DoWorkEventHandler(singleAppComThread_DoWork);
            singleAppComThread.RunWorkerAsync();
        }

        private static void singleAppComThread_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            WaitHandle[] waitHandles = new WaitHandle[] { threadComEvent };

            while (!worker.CancellationPending)
            {
                // check every second for a signal.
                if (WaitHandle.WaitAny(waitHandles, 1000) == 0)
                {
                    // The user tried to start another instance. We can't allow that,
                    // so bring the other instance back into view and enable that one.
                    // That form is created in another thread, so we need some thread sync magic.
                    if (Application.OpenForms.Count > 0)
                    {
                        Form mainForm = Application.OpenForms[0];
                        mainForm.Invoke(new SetFormVisableDelegate(ThreadFormVisable), mainForm);
                    }
                }
            }
        }

        /// <summary>
        /// When this method is called using a Invoke then this runs in the thread
        /// that created the form, which is nice.
        /// </summary>
        /// <param name="frm"></param>
        private delegate void SetFormVisableDelegate(Form frm);

        private static void ThreadFormVisable(Form frm)
        {
            if (frm != null)
            {
                // display the form and bring to foreground.
                frm.Visible = true;
                frm.WindowState = FormWindowState.Normal;
                frm.Show();
                SetForegroundWindow(frm.Handle);
            }
        }

        #endregion - single instance code -

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Add handler to handle the exception raised by main threads
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            // Add handler to handle the exception raised by additional threads
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            #region - single instance code -

            try
            {
                // another instance is already running
                threadComEvent = EventWaitHandle.OpenExisting(SingleAppComEventName);
                threadComEvent.Set();  // signal the other instance.
                threadComEvent.Close();
                return;    // return immediatly.
            }
            catch { /* An exception will be thrown if a handle to another instance is not found so we just ignore it */ }

            // Create the Event handle
            threadComEvent = new EventWaitHandle(false, EventResetMode.AutoReset, SingleAppComEventName);
            CreateInterAppComThread();

            #endregion - single instance code -

            var services = new ServiceCollection()
                .AddSingleton<Notifications>()
                .AddAppServices()
                .AddInfraServices()
                .AddSingleton(
                    new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", false, true)
                    .Build())
                .AddTransient<MainForm>()
                .AddTransient<MainFormModel>()
                .AddSingleton<MessageBus>()
                .AddSingleton<PackagingSignalRClient>()
                .AddSingleton<PointsOfUseSignalRClient>()
                .AddSingleton<EtiMovementsSignalRClient>()
                .AddSingleton<PrintService>()
                .AddMediatR(typeof(MainForm).Assembly)
                .AddMediatR(typeof(Labels.Templates.UseCases.PrintingRequest).Assembly)
                .BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.LineCode))
            {
                Properties.Settings.Default.LineCode = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el código de la línea correspondiente:", "Código de Línea", "");
                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.LineCode))
                {
                    return;
                }
                Properties.Settings.Default.Save();
            }

            //var request = new Labels.App.Notifications.UseCases.ParseContainerComplete.ParseContainerCompleteRequest("");
            //services.GetService<IMediator>().Send(request).GetAwaiter().GetResult();

            Application.Run(services.GetService<MainForm>());

            #region - single instance code -

            // End the communication thread.
            singleAppComThread.CancelAsync();
            while (singleAppComThread.IsBusy)
                Thread.Sleep(50);
            threadComEvent.Close();

            #endregion - single instance code -
        }

        private static void Application_ThreadException
        (object sender, System.Threading.ThreadExceptionEventArgs e)
        {// All exceptions thrown by the main thread are handled over this method
            ShowExceptionDetails("Thread Exception", e.Exception);
        }

        private static void CurrentDomain_UnhandledException
            (object sender, UnhandledExceptionEventArgs e)
        {
            // All exceptions thrown by additional threads are handled in this method
            ShowExceptionDetails("Unhandled Exception", e.ExceptionObject as Exception);

            // Suspend the current thread for now to stop the exception from throwing.
            Thread.CurrentThread.Suspend();
        }

        private static void ShowExceptionDetails(string source, Exception ex)
        {
            if (ex is ReflectionTypeLoadException)
            {
                var typeLoadException = ex as ReflectionTypeLoadException;
                var loaderExceptions = typeLoadException.LoaderExceptions;
                for (var i = 0; i < loaderExceptions.Length; i++)
                {
                    ShowExceptionMessageBox($"Loader Exception #{i + 1} de {loaderExceptions.Length}", loaderExceptions[i]);
                }
            }
            else
            {
                ShowExceptionMessageBox(source, ex);
            }
        }

        private static void ShowExceptionMessageBox(string source, Exception ex)
        {
            var exTop = new ApplicationException(ex.Message, ex)
            {
                Source = source
            };
            var box = new ExceptionMessageBox(exTop);
            box.Show(null);
        }

        public static void AddApplicationToStartup()
        {
            const string fullPathEnvVar = "%appdata%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\StartMyClickOnceApp.bat";
            string fullPath = Environment.ExpandEnvironmentVariables(fullPathEnvVar);

            const string publisherName = "General Transmissions";

            if (!File.Exists(fullPath))
            {
                string[] mystrings =
                {
                $@"@echo off
if exist ""%appdata%\Microsoft\Windows\Start Menu\Programs\<PublisherName>\<ApplicationName>.appref-ms"" (
""%appdata%\Microsoft\Windows\Start Menu\Programs\{publisherName}\<ApplicationName>.appref-ms""
) else (
(goto) 2>nul & del ""%~f0""
)"
            };
                //write the file to the Startup folder
                File.WriteAllLines(fullPath, mystrings);
            }
        }
    }
}