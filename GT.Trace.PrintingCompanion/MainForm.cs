using GT.Trace.Labels.Templates.UseCases;
using GT.Trace.Labels.Templates.UseCases.PrintJuniorLabel;
using GT.Trace.Labels.Templates.UseCases.PrintMasterLabel;
using GT.Trace.Labels.Templates.UseCases.PrintPickingLabel;
using GT.Trace.Labels.Templates.UseCases.PrintReturnLabel;
using GT.Trace.Labels.Templates.UseCases.PrintSubAssemblyEti;
using GT.Trace.Labels.Templates.UseCases.PrintWipLabel;
using GT.Trace.PrintingCompanion.SignalR;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT.Trace.PrintingCompanion
{
    public partial class MainForm : Form
    {
        public const string NotepadExeProcessName = "notepad.exe";

        private static string ExtractListBoxContent(ListBox listBox)
        {
            var sb = new StringBuilder();
            foreach (var item in listBox.Items)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        private static void ShowTextInNotepad(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                var fileName = Path.GetTempFileName();
                File.WriteAllText(fileName, text);
                Process.Start(NotepadExeProcessName, fileName);
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        private readonly EtiMovementsSignalRClient _etiMovements;

        private readonly PointsOfUseSignalRClient _pointsOfUse;

        private readonly PackagingSignalRClient _packaging;

        //private readonly MessageBus _messageBus;

        private readonly IMediator _mediator;

        private readonly MainFormModel _model;

        private readonly Notifications _notifications;

        public MainForm(Notifications notifications, MainFormModel model, IMediator mediator, EtiMovementsSignalRClient etiMovements, PointsOfUseSignalRClient pointsOfUse, IConfigurationRoot configuration, PackagingSignalRClient packaging)
        {
            InitializeComponent();

            _notifications = notifications;

            _model = model;

            PrintingRequestList.DataSource = _model.PrintingRequests;

            EventsListBox.DataSource = notifications.Events;

            PrintingConfigurationPropertyGrid.SelectedObject = _model.PrintingConfiguration;

            _model.Initialize().GetAwaiter().GetResult();

            _etiMovements = etiMovements;
            _pointsOfUse = pointsOfUse;
            _mediator = mediator;
            _packaging = packaging;

            Task.Run(() => _etiMovements.Start());
            Task.Run(() => _pointsOfUse.Start());
            Task.Run(() => _packaging.Start());

            //propertyGrid1.Enabled = Wmi.UserIsRunningAsAdmin;
            //_messageBus.Register<PrintReturnLabelRequest>("OnMaterialReturned", OnPrintMaterialReturnLabelRequest);
            //_messageBus.Register<PrintSubAssemblyEtiRequest>("OnSubAssemblyCreated", OnPrintSubAssemblyEtiRequest);
            //_messageBus.Register<PrintJuniorLabelRequest>("OnContainerComplete", OnPrintJuniorLabelRequest);
            //_messageBus.Register<PrintMasterLabelRequest>("OnPalletComplete", OnPrintMasterLabelRequest);
            //_messageBus.Register<PrintPickingLabelRequest>("OnUnitPicked", OnPrintPickingLabelRequest);
            //_messageBus.Register<PrintWipLabelRequest>("OnWip", OnPrintWipLabelRequest);
            //_messageBus.Register<string>("SignalR", OnEventLog);
            //_messageBus.Register<string>("Message", OnEventLog);

            Text = $"Printing - GT Trace \\ Línea {Properties.Settings.Default.LineCode}";
        }

        private void OnEventLog(string message)
        {
            HandleNewEventLog(message);
        }

        private void OnPrintWipLabelRequest(PrintWipLabelRequest request)
        {
            HandleNewPrintingRequest(request);
        }

        private void OnPrintMaterialReturnLabelRequest(PrintReturnLabelRequest request)
        {
            HandleNewPrintingRequest(request);
        }

        private void OnPrintSubAssemblyEtiRequest(PrintSubAssemblyEtiRequest request)
        {
            HandleNewPrintingRequest(request);
        }

        private void OnPrintJuniorLabelRequest(PrintJuniorLabelRequest request)
        {
            HandleNewPrintingRequest(request);
        }

        private void OnPrintMasterLabelRequest(PrintMasterLabelRequest request)
        {
            HandleNewPrintingRequest(request);
        }

        private void OnPrintPickingLabelRequest(PrintPickingLabelRequest request)
        {
            HandleNewPrintingRequest(request);
        }

        private void SafeInvoke(MethodInvoker invoker)
        {
            if (InvokeRequired)
            {
                Invoke(invoker);
            }
            else
            {
                invoker();
            }
        }

        private void HandleNewEventLog(string message, ToolTipIcon level = ToolTipIcon.Info)
        {
            //ShowBalloonTip("Información", message, level);
            //SafeInvoke(delegate
            //{
            //    EventsListBox.Items.Insert(0, $"{DateTime.Now:HH:mm:ss} - {message}");
            //});
        }

        private void HandleNewPrintingRequest(PrintingRequest request)
        {
            SafeInvoke(delegate
            {
                PrintingRequestQueueList.Items.Add(request);
                for (var i = PrintingRequestQueueList.Items.Count; i > 500; i--)
                {
                    PrintingRequestQueueList.Items.RemoveAt(i);
                }
            });
            TryProcessQueue();
        }

        private void TryProcessQueue()
        {
            if (PrintingRequestQueueList.Items.Count > 0)
            {
                QueueProcessingTimer.Enabled = false;
                var bw = new BackgroundWorker();
                bw.DoWork += PrintLabels;
                bw.RunWorkerCompleted += UpdateQueue;
                bw.RunWorkerAsync();
            }
        }

        private void QueueProcessingTimer_Tick(object sender, EventArgs e)
        {
            TryProcessQueue();
        }

        private List<PrintingRequest> _requestsToDelete;

        private void PrintLabels(object sender, EventArgs args)
        {
            //_requestsToDelete = new List<PrintingRequest>();
            //var copy = new PrintingRequest[PrintingRequestQueueList.Items.Count];
            //PrintingRequestQueueList.Items.CopyTo(copy, 0);
            //foreach (PrintingRequest request in copy)
            //{
            //    try
            //    {
            //        // FIX
            //        var config = (propertyGrid1.SelectedObject as PrintingConfiguration)?[request.RequestType];
            //        request.TotalCopies = config.TotalCopies;
            //        request.PrinterName = config.PrinterName;
            //        var response = _mediator.Send(request).GetAwaiter().GetResult();
            //        if (response.IsSuccess)
            //        {
            //            HandleNewEventLog($"Se envió {request.Name} a la impresora {request.PrinterName}.");
            //            _requestsToDelete.Add(request);
            //        }
            //        else
            //        {
            //            HandleNewEventLog(response.Message, ToolTipIcon.Warning);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        HandleNewEventLog($"{ex.Message}\n\n{ex}");
            //    }
            //}
        }

        private void UpdateQueue(object sender, EventArgs args)
        {
            foreach (var request in _requestsToDelete)
            {
                SafeInvoke(delegate { PrintingRequestQueueList.Items.Remove(request); });
            }
            SafeInvoke(delegate { QueueProcessingTimer.Enabled = true; });
        }

        protected override void OnClosed(EventArgs e)
        {
            _pointsOfUse.Dispose();
            _etiMovements.Dispose();
            base.OnClosed(e);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //ShowInTaskbar = false;
                AppNotifyIcon.Visible = true;
                ShowBalloonTip("Información", "La aplicación continúa ejecutándose.");
            }
        }

        private void AppNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ShowInTaskbar = true;
            AppNotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void ShowBalloonTip(string title, string text, ToolTipIcon icon = ToolTipIcon.Info)
        {
            if (AppNotifyIcon.Visible)
            {
                AppNotifyIcon.BalloonTipIcon = icon;
                AppNotifyIcon.BalloonTipText = text;
                AppNotifyIcon.BalloonTipTitle = title;
                AppNotifyIcon.ShowBalloonTip(1000);
            }
        }

        private void ExitMenuOption_Click(object sender, EventArgs e)
        {
            if (Confirm("Click OK to continue...", "Exit Application")) Close();
        }

        private void ViewEventLogMenuOption_Click(object sender, EventArgs e)
        {
            //TryShowListBoxContentInNotepad(EventsListBox);
        }

        private void PrintingRequestsMenuOption_Click(object sender, EventArgs e)
        {
            TryShowListBoxContentInNotepad(PrintingRequestQueueList);
        }

        private void TryShowListBoxContentInNotepad(ListBox listBox)
        {
            try
            {
                ShowTextInNotepad(ExtractListBoxContent(listBox));
            }
            catch (Win32Exception ex)
            {
                Alert(ex.Message, $"{NotepadExeProcessName} not found");
            }
        }

        private bool Confirm(string text, string caption) =>
            MessageBox.Show(this, text, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;

        private void Alert(string text, string caption) =>
            MessageBox.Show(this, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void PrintingRequestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrintingRequestList.SelectedIndex >= 0)
            {
                _model.PrintLabel(PrintingRequestList.SelectedIndex).GetAwaiter().GetResult();
            }
        }
    }
}