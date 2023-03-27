using System;
using System.Threading;

namespace GT.Trace.Labels.WpfPrintingClient
{
    public sealed class PendingRequestListProcessor : IDisposable
    {
        private readonly PendingRequestListPrinter _printer;

        private readonly PendingRequestListUpdater _updater;

        public PendingRequestListProcessor(PendingRequestListPrinter printer, PendingRequestListUpdater updater)
        {
            _printer = printer;
            _updater = updater;

            _printer.OnPrintComplete += _printer_OnPrintComplete;
            _updater.OnUpdateComplete += _updater_OnUpdateComplete;
        }

        private void _updater_OnUpdateComplete()
        {
            _ = _printer.TryRun();
        }

        private void _printer_OnPrintComplete()
        {
            new Thread((ThreadStart)delegate
            {
                Thread.Sleep(10000);
                Run();
            }).Start();
        }

        public void Run()
        {
            _ = _updater.TryRun();
        }

        public void Cancel()
        {
            _ = _updater.TryCancel();
            _ = _printer.TryCancel();
        }

        public void Dispose()
        {
            _updater.Dispose();
            _printer.Dispose();
        }
    }
}