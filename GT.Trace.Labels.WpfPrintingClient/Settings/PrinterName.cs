namespace GT.Trace.Labels.WpfPrintingClient
{
    public sealed class PrinterName
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(Value)
                ? "[ Seleccionar... ]"
                : Value;
        }
    }
}