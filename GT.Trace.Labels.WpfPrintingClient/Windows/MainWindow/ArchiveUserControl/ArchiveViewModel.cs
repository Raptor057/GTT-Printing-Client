using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Services;
using GT.Trace.Labels.App.UseCases.Persistence.FindLabels;
using GT.Trace.Labels.App.UseCases.Printing.PrintLabel;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GT.Trace.Labels.WpfPrintingClient.Windows.MainWindow
{
    public sealed class ArchiveViewModel : INotifyPropertyChanged
    {
        public sealed class ButtonCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            private readonly Action _commandHandler;

            public ButtonCommand(Action commandHandler) => _commandHandler = commandHandler;

            public bool CanExecute(object parameter) => true;

            public void Execute(object parameter) => _commandHandler?.Invoke();
        }

        private readonly IMediator _mediator;

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly IMessageBusService _messageBus;

        public ArchiveViewModel(IMediator mediator, IMessageBusService messageBus)
        {
            _mediator = mediator;
            _messageBus = messageBus;
            ApplyFilterCommand = new ButtonCommand(OnApplyFilterCommand);
            PrintSelectedLabelCommand = new ButtonCommand(OnPrintSelectedLabelCommand);
        }

        public bool CanPrintSelectedLabel => SelectedLabelIndex >= 0;

        public DateTime Date { get; set; } = DateTime.Now;

        public PrintingRequestList PrintingRequests { get; } = new PrintingRequestList();

        private int _selectedLabelIndex = -1;

        public int SelectedLabelIndex
        {
            get => _selectedLabelIndex;
            set
            {
                if (_selectedLabelIndex != value)
                {
                    _selectedLabelIndex = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanPrintSelectedLabel)));
                }
            }
        }

        public ICommand ApplyFilterCommand { get; }

        public ICommand PrintSelectedLabelCommand { get; }

        public Dictionary<string, int> LabelTypeOptions { get; } = new Dictionary<string, int>
        {
            { "ATEQ", (int)LabelTypes.Ateq },
            { "Individual", (int)LabelTypes.Individual },
            { "Junior", (int)LabelTypes.Junior },
            { "Master", (int)LabelTypes.Master },
            { "Parcial", (int)LabelTypes.Partial },
            { "Picking", (int)LabelTypes.Picking },
            { "Retorno", (int)LabelTypes.Return },
            { "Sub Ensamble", (int)LabelTypes.SubAssembly },
            { "WIP", (int)LabelTypes.Wip }
        };

        public string SelectedLabelTypes { get; set; } = "1,2,3,4,5,6,7,8,9";

        public void OnApplyFilterCommand()
        {
            IEnumerable<LabelTypes> selectedLabelTypes = SelectedLabelTypes.Split(',').Select(item => (LabelTypes)int.Parse(item));

            PrintingRequests.Clear();
            FindLabelsResponse response = _mediator.Send(new FindLabelsRequest(Date, selectedLabelTypes)).GetAwaiter().GetResult();
            foreach (LabelDto label in response.Labels)
            {
                PrintingRequests.SafeAdd(label);
            }
            SelectedLabelIndex = -1;
        }

        public void OnPrintSelectedLabelCommand()
        {
            if (SelectedLabelIndex >= 0 && SelectedLabelIndex < PrintingRequests.Count)
            {
                _ = Task.Run(() =>
                {
                    var label = PrintingRequests[SelectedLabelIndex];
                    var response = _mediator.Send(new PrintLabelRequest(label)).GetAwaiter().GetResult();
                    _messageBus.PassMessage(response.Message);
                });
            }
        }
    }
}