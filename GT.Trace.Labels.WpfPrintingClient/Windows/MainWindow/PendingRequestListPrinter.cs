using GT.Trace.Labels.App.Services;
using GT.Trace.Labels.App.UseCases.Printing.PrintLabel;
using MediatR;
using System;
using System.ComponentModel;
using System.Threading;

namespace GT.Trace.Labels.WpfPrintingClient
{
    public sealed class PendingRequestListPrinter : IDisposable
    {
        public delegate void PrintCompleteEventHandler();

        public event PrintCompleteEventHandler OnPrintComplete;

        private readonly BackgroundWorker _worker;

        private readonly PrintingRequestList _printingRequests;

        private readonly IMediator _mediator;

        private readonly IMessageBusService _messageBus;

        public PendingRequestListPrinter(PrintingRequestList printingRequests, IMediator mediator, IMessageBusService messageBus)
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += HandleWorkerDoWork;
            _worker.RunWorkerCompleted += HandleWorkerRunWorkerCompleted;

            _printingRequests = printingRequests;
            _mediator = mediator;
            _messageBus = messageBus;
        }

        private void HandleWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            while (_printingRequests.Count > 0)
            {
                _messageBus.PassMessage($"Imprimiendo peticion #{_printingRequests[0].LabelID}.");
                PrintLabelResponse response = _mediator.Send(new PrintLabelRequest(_printingRequests[0])).GetAwaiter().GetResult();
                _messageBus.PassMessage(response.Message);
                _printingRequests.SafeRemoveAt(0);
            }
        }

        private void HandleWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnPrintComplete?.Invoke();
        }

        public bool TryRun()
        {
            if (!_worker.IsBusy)
            {
                _worker.RunWorkerAsync();
                return true;
            }
            return false;
        }

        public bool TryCancel()
        {
            if (_worker.IsBusy)
            {
                _worker.CancelAsync();
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            _worker.Dispose();
        }
    }
}