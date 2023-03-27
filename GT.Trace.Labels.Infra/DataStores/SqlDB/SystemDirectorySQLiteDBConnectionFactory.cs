using SQLite;
using System;
using System.IO;

namespace GT.Trace.Labels.Infra.DataStores.SqlDB
{
    internal sealed class SystemDirectorySQLiteDBConnectionFactory : ISQLiteDBConnectionFactory
    {
        private readonly string _connectionString;

        public SystemDirectorySQLiteDBConnectionFactory()
        {
            _connectionString = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
        }

        public SQLiteConnection GetOpenConnection()
        {
            return new SQLiteConnection(_connectionString);
        }
    }
}