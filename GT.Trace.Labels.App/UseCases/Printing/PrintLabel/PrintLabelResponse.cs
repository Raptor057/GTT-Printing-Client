namespace GT.Trace.Labels.App.UseCases.Printing.PrintLabel
{
    public sealed class PrintLabelResponse
    {
        public PrintLabelResponse(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public string Message { get; }

        public bool IsSuccess { get; }
    }
}