namespace Firebank
{
    static class Functions
    {
        private static readonly string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;MultipleActiveResultSets=true;";
        public static System.Data.SqlClient.SqlConnection db = new System.Data.SqlClient.SqlConnection(ConnectionString);
        public static void Alert(string msg, Notifications.enmType type)
        {
            Notifications notifier = new Notifications();
            notifier.showAlert(msg, type);
        }
    }
}
