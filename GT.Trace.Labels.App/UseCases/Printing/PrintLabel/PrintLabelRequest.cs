using MediatR;

namespace GT.Trace.Labels.App.UseCases.Printing.PrintLabel
{
    public sealed class PrintLabelRequest : IRequest<PrintLabelResponse>
    {
        public PrintLabelRequest(Dtos.LabelDto label)
        {
            Label = label;
        }

        public Dtos.LabelDto Label { get; set; }
    }
}