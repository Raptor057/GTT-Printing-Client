namespace GT.Trace.Labels.App.Persistence.UseCases.AddLabel
{
    public sealed class AddLabelResponse<T>
        where T : class
    {
        public AddLabelResponse(T labelData = null)
        {
            LabelData = labelData;
        }

        public bool IsSuccess
        { get { return LabelData != null; } }

        public T LabelData { get; }
    }
}