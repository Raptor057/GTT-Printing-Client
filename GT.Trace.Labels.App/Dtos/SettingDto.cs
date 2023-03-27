using System;

namespace GT.Trace.Labels.App.Dtos
{
    public class SettingDto
    {
        public SettingDto(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }

        public string Value { get; set; }
    }

    public class SettingDto<T> : SettingDto
    {
        public SettingDto(string key, T value)
            : base(key, Convert.ToString(value))
        { }

        public new T Value => (T)Convert.ChangeType(base.Value, typeof(T));

        public void SetValue(T value) => base.Value = value.ToString();
    }
}