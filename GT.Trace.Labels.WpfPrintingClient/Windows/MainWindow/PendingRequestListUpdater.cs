using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Persistence.UseCases.FetchNewLabels;
using GT.Trace.Labels.App.Services;
using MediatR;
using System;
using System.ComponentModel;
using System.Linq;

namespace GT.Trace.Labels.WpfPrintingClient
{
    public sealed class PendingRequestListUpdater : IDisposable
    {
        public delegate void UpdateCompleteEventHandler();

        public event UpdateCompleteEventHandler OnUpdateComplete;

        private readonly BackgroundWorker _worker;

        private readonly PrintingRequestList _printingRequests;

        private readonly IMediator _mediator;

        private readonly IMessageBusService _messageBus;

        public PendingRequestListUpdater(PrintingRequestList printingRequests, IMediator mediator, IMessageBusService messageBus)
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += _worker_DoWork;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;

            _printingRequests = printingRequests;
            _mediator = mediator;
            _messageBus = messageBus;
        }

        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _mediator.Send(new FetchNewLabelsRequest()).GetAwaiter().GetResult();
        }

        private void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                _messageBus.PassMessage($"{nameof(PendingRequestListUpdater)}. {e.Error.Message}");
            }
            else if (e.Result is FetchNewLabelsResponse response)
            {
                //_messageBus.PassMessage($"Se encontraron {response.Labels.Count()} etiquetas para imprimir.");
                _printingRequests.SafeClear();
                foreach (LabelDto label in response.Labels)
                {
                    _printingRequests.SafeAdd(label);
                }
            }
            else
            {
                _messageBus.PassMessage($"{nameof(PendingRequestListUpdater)}. El resultado de la operación no es válido.");
            }

            OnUpdateComplete?.Invoke();
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