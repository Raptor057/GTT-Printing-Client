using GT.Trace.Labels.App.Dtos;
using GT.Trace.Labels.App.Persistence.UseCases.AddLabel;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GT.Trace.Labels.App.Notifications.UseCases.ParseContainerComplete
{
    internal sealed class ParseContainerCompleteHandler : IRequestHandler<ParseContainerCompleteRequest>
    {
        private readonly IMediator _mediator;

        public ParseContainerCompleteHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(ParseContainerCompleteRequest request, CancellationToken cancellationToken)
        {
            var data = JsonConvert.DeserializeObject<ContainerCompleteDto>(request.JsonData);

            var request2 = new AddLabelRequest<JuniorLabelDto>(
                new JuniorLabelDto
                {
                    ApprovalDate = data.ApprovalDate,
                    Customer = $"{data.CustomerNo} {data.CustomerName}",
                    CustomerPartNo = data.CustomerPartNo,
                    Date = data.Date,
                    JulianDate = $"{data.Date.Year - 2000}{data.Date.DayOfYear:000}",
                    LineCode = data.LineCode,
                    PartDescription = data.PartDescription,
                    PartNo = data.PartNo,
                    PurchaseOrderNo = data.PurchaseOrderNo,
                    Revision = data.Revision,
                    Approver = data.ApprovalUser,
                    CreationTime = DateTime.Now,
                    Quantity = data.Quantity,
                });

            await _mediator.Send(request2).ConfigureAwait(false);

            return Unit.Value;
        }
    }
}