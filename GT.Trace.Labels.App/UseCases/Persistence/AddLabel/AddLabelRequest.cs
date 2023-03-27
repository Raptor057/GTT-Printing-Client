using MediatR;

namespace GT.Trace.Labels.App.Persistence.UseCases.AddLabel
{
    public sealed class AddLabelRequest<T> : IRequest<AddLabelResponse<T>>
        where T : class
    {
        public AddLabelRequest(T labelData)
        {
            LabelData = labelData;
        }

        public T LabelData { get; }
    }
}