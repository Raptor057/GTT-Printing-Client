namespace GT.Trace.PrintingCompanion
{
    public sealed class PrintingResponse
    {
        public static PrintingResponse OK => new PrintingResponse(true, "OK");

        public static PrintingResponse Fail(string message) => new PrintingResponse(false, message);

        private PrintingResponse(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public string Message { get; }

        public bool IsSuccess { get; }
    }
}