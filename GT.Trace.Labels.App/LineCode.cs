using GT.Trace.Labels.App.Gateways;

namespace GT.Trace.Labels.App
{
    public sealed class LineCode
    {
        private readonly ISettingsGateway _settings;

        private bool _isInitialized = false;

        private string _value;

        public LineCode(ISettingsGateway settings)
        {
            _settings = settings;
        }

        public string Value
        {
            get
            {
                if (!_isInitialized)
                {
                    _value = _settings.GetLineCode().Value;
                    _isInitialized = true;
                }
                return _value;
            }
        }
    }
}