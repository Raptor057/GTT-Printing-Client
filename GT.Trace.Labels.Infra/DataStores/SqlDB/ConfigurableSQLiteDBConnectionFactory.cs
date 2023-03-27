using Microsoft.Extensions.Configuration;
using SQLite;

namespace GT.Trace.Labels.Infra.DataStores.SqlDB
{
    public sealed class ConfigurableSQLiteDBConnectionFactory : ISQLiteDBConnectionFactory
    {
        private readonly string _connectionString;

        public ConfigurableSQLiteDBConnectionFactory(IConfigurationRoot configuration)
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        public SQLiteConnection GetOpenConnection()
        {
            return new SQLiteConnection(_connectionString);
        }
    }
}