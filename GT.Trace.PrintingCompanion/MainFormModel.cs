using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Persistence.UseCases.FetchNewLabels;
using GT.Trace.Labels.Templates.UseCases.PrintJuniorLabel;
using MediatR;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace GT.Trace.PrintingCompanion
{
    public class Notifications
    {
        public Notifications()
        {
            Events = new BindingList<string>()
            {
                RaiseListChangedEvents = true
            };
        }

        public BindingList<string> Events { get; }

        public void Add(string message)
        {
            Events.Insert(0, $"{DateTime.Now:HH:mm:ss}. {message}");
            if (Events.Count > 50)
            {
                Events.RemoveAt(51);
            }
        }
    }

    public sealed class MainFormModel
    {
        private readonly IMediator _mediator;

        private readonly Notifications _notifications;

        public MainFormModel(IMediator mediator, Notifications notifications)
        {
            _mediator = mediator;
            _notifications = notifications;

            PrintingRequests = new BindingList<BaseLabelDto>()
            {
                RaiseListChangedEvents = true
            };

            Events = new BindingList<string>()
            {
                RaiseListChangedEvents = true
            };

            PrintingConfiguration = new PrintingConfiguration
            {
                JrLabelCopies = 1,
                MasterLabelCopies = 1,
                MaterialReturnsCopies = 1,
                PickingLabelCopies = 2,
                SubAssemblyEtiCopies = 1,
                WipLabelCopies = 1
            };
        }

        private void OnEventLog(string message)
        {
            Events.Insert(0, message);
        }

        public PrintingConfiguration PrintingConfiguration { get; }

        public BindingList<BaseLabelDto> PrintingRequests { get; }

        public BindingList<string> Events { get; }

        public async Task Initialize()
        {
            var response = await _mediator.Send(new FetchNewLabelsRequest()).ConfigureAwait(false);
            foreach (var label in response.Labels)
            {
                PrintingRequests.Add(label);
            }
        }

        public async Task PrintLabel(int labelIndex)
        {
            var label = PrintingRequests[labelIndex];
            var request = new PrintJuniorLabelRequest();
            //try
            //{
            //    // FIX
            //    var config = PrintingConfiguration[request.RequestType];
            //    request.TotalCopies = config.TotalCopies;
            //    request.PrinterName = config.PrinterName;
            //    var response = await _mediator.Send(request).ConfigureAwait(false);
            //    if (response.IsSuccess)
            //    {
            //        Events.Insert(0, $"Se envió {request.Name} a la impresora {request.PrinterName}.");
            //    }
            //    else
            //    {
            //        Events.Insert(0, response.Message);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Events.Insert(0, $"{ex.Message}\n\n{ex}");
            //}
        }
    }
}