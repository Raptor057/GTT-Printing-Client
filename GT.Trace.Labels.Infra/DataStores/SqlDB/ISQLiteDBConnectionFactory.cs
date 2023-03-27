using SQLite;

namespace GT.Trace.Labels.Infra.DataStores.SqlDB
{
    public interface ISQLiteDBConnectionFactory
    {
        SQLiteConnection GetOpenConnection();
    }
}