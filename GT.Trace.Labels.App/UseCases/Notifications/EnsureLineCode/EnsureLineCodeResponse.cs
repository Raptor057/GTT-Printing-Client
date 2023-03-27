namespace GT.Trace.Labels.App.UseCases.Notifications.EnsureLineCode
{
    public sealed class EnsureLineCodeResponse
    {
        public EnsureLineCodeResponse(bool isSet)
        {
            IsSet = isSet;
        }

        public bool IsSet { get; }
    }
}