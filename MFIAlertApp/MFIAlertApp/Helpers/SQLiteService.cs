using PCLStorage;
using SQLite;
using MFIAlertApp.Interfaces;

namespace MFIAlertApp.Helpers
{
    /// <summary>
    /// SQLite service. Get connection and etc.
    /// </summary>
    public class SQLiteService : ISQLite
    {
        public SQLite.SQLiteConnection GetConnection(string databaseName)
        {
            SQLiteConnection sqlitConnection;
            var sqliteFilename = databaseName;
            IFolder folder = FileSystem.Current.LocalStorage;
            string path = PortablePath.Combine(folder.Path.ToString(), sqliteFilename);
            sqlitConnection = new SQLite.SQLiteConnection(path);
            return sqlitConnection;
        }
    }
}
