using SQLite;

namespace GT.Trace.Labels.Infra.DataStores.SqlDB.Entities
{
    internal sealed class Setting
    {
        [PrimaryKey]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}