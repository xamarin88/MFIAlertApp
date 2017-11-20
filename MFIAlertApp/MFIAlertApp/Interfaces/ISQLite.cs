using SQLite;

namespace MFIAlertApp.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection(string databaseName);
    }
}
