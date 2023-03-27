namespace GT.Trace.PrintingCompanion
{
    public sealed class PrinterName
    {
        public PrinterName(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public override string ToString()
        {
            return Value;
        }
    }
}