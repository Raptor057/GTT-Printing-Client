namespace GT.Trace.Labels.App.UseCases.Persistence.SaveLineCode
{
    public sealed class SaveLineCodeResponse
    {
        public SaveLineCodeResponse(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; }
    }
}