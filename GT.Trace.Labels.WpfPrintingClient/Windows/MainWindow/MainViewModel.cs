using GT.Trace.Labels.App;
using GT.Trace.Labels.App.Services;
using GT.Trace.Labels.WpfPrintingClient.Settings;
using GT.Trace.Labels.WpfPrintingClient.Windows.MainWindow;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.WpfPrintingClient
{
    public sealed class MainViewModel : IDisposable
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        private readonly IMessageBusService _messageBus;

        private readonly IEtiMovementsNotificationsService _etiMovements;

        private readonly IPackagingNotificationsService _packaging;

        private readonly IPointsOfUseNotificationsService _pointsOfUse;

        private readonly PendingRequestListProcessor _processor;

        private readonly LineCode _lineCode;

        public MainViewModel(PendingRequestListProcessor processor, IMessageBusService messageBus,
            IEtiMovementsNotificationsService etiMovements,
            IPointsOfUseNotificationsService pointsOfUse,
            IPackagingNotificationsService packaging,
            PrintingConfiguration printingConfiguration,
            PrintingRequestList printingRequests,
            LineCode lineCode,
            ArchiveViewModel archiveViewModel)
        {
            Archive = archiveViewModel;

            WindowTitle = $"Cliente de Impresión \\ Línea {lineCode.Value}";
            printingConfiguration.Initialize();
            Events = new ObservableCollection<EventItemViewModel>();
            PrintingConfiguration = printingConfiguration;
            PrintingRequests = printingRequests;

            _lineCode = lineCode;
            _processor = processor;
            _etiMovements = etiMovements;
            _packaging = packaging;
            _pointsOfUse = pointsOfUse;
            _messageBus = messageBus;
            _messageBus.OnMessage += (message) =>
            {
                App.Current.Dispatcher.Invoke(delegate
                {
                    const int MaxMessages = 50;
                    Events.Insert(0, new EventItemViewModel(message));
                    while (Events.Count > MaxMessages)
                    {
                        Events.RemoveAt(MaxMessages);
                    }
                });
            };

            _cts.Token.ThrowIfCancellationRequested();
            _ = Task.Run(_etiMovements.StartAsync, _cts.Token);
            _ = Task.Run(_packaging.StartAsync, _cts.Token);
            _ = Task.Run(_pointsOfUse.StartAsync, _cts.Token);

            SelectedPrintingRequestIndex = -1;

            _processor.Run();
        }

        public ArchiveViewModel Archive { get; }

        public string WindowTitle { get; }

        public int SelectedPrintingRequestIndex { get; set; }

        public PrintingRequestList PrintingRequests { get; }

        public ObservableCollection<EventItemViewModel> Events { get; }

        public PrintingConfiguration PrintingConfiguration { get; }

        public void Dispose()
        {
            _processor.Dispose();
            _cts.Cancel();
            _cts.Dispose();
        }
    }
}