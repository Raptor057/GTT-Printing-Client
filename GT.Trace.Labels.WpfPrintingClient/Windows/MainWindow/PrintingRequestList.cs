using GT.Trace.Labels.App.Dtos;
using System.Collections.ObjectModel;
using System.Threading;

namespace GT.Trace.Labels.WpfPrintingClient
{
    public sealed class PrintingRequestList : ObservableCollection<LabelDto>
    {
        private readonly ReaderWriterLock _lock = new ReaderWriterLock();

        public void SafeRemoveAt(int index)
        {
            _lock.AcquireReaderLock(Timeout.Infinite);
            App.Current?.Dispatcher.Invoke(delegate
            {
                RemoveAt(index);
            });
            _lock.ReleaseReaderLock();
        }

        public void SafeClear()
        {
            _lock.AcquireReaderLock(Timeout.Infinite);
            App.Current?.Dispatcher.Invoke(delegate
            {
                Clear();
            });
            _lock.ReleaseReaderLock();
        }

        public void SafeAdd(LabelDto label)
        {
            _lock.AcquireReaderLock(Timeout.Infinite);
            App.Current?.Dispatcher.Invoke(delegate
            {
                Add(label);
            });
            _lock.ReleaseReaderLock();
        }
    }
}