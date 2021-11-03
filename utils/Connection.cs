namespace LoucaLiza.utils
{
    static class Connection
    {
        private const string server = "localhost";
        private const string database = "finance-control";
        private const string user = "root";
        private const string password = "root";

        static public string connectionString = $"server={server};User Id={user};database={database};password={password}";
    }
}
