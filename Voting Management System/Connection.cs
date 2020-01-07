namespace Voting_Management_System
{
    class Connection
    {
        private static string Server = "localhost";
        private static string Database = "tshs_sms";
        private static string Username = "root";
        private static string Password = "";
        private static string Port = "3306";
        private static string Connstr = "";
        public static string GetConnectionStr()
        {
            return Connstr = "SERVER=" + Server + ";" + "DATABASE=" + Database + ";" + "UID=" + Username + ";" + "PASSWORD=" + Password + ";" + "PORT=" + Port + ";";
        }
        public static void SetServer(string Server)
        {
            Connection.Server = Server;
        }
        public static void SetDatabase(string Database)
        {
            Connection.Database = Database;
        }
        public static void SetUid(string Username)
        {
            Connection.Username = Username;
        }
        public static void SetPassword(string Password)
        {
            Connection.Password = Password;
        }
        public static void SetPort(string Port)
        {
            Connection.Port = Port;
        }
    }
}
