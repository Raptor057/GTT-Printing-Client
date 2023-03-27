using GT.Trace.Labels.Infra.DataStores.SqlDB.Entities;
using System;

namespace GT.Trace.Labels.Infra.DataStores.SqlDB
{
    internal sealed class SQLiteSettingsDao
    {
        private readonly ISQLiteDBConnectionFactory _connections;

        public SQLiteSettingsDao(ISQLiteDBConnectionFactory connections)
        {
            _connections = connections;
            using (SQLite.SQLiteConnection con = _connections.GetOpenConnection())
            {
                _ = con.CreateTable<Setting>();
            }
        }

        public Setting Get(string key)
        {
            using (SQLite.SQLiteConnection con = _connections.GetOpenConnection())
            {
                Setting setting = con.Table<Setting>().FirstOrDefault(item => item.Key == key);
                if (setting == null)
                {
                    return new Setting { Key = key };
                }
                return setting;
            }
        }

        public bool Set(string key, string value)
        {
            int affectedRecords = 0;
            using (SQLite.SQLiteConnection con = _connections.GetOpenConnection())
            {
                Setting setting = con.Table<Setting>().FirstOrDefault(item => item.Key == key);
                if (setting != null)
                {
                    setting.Value = value;
                    affectedRecords = con.Update(setting);
                }
                else
                {
                    affectedRecords = con.Insert(new Setting { Key = key, Value = value });
                }
            }
            return affectedRecords > 0;
        }
    }
}