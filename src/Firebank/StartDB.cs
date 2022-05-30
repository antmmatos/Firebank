using System.Data.SqlClient;

namespace Firebank
{
    static class StartDB
    {
        private static readonly string ConnectionString = "Server=devlab.thenotepad.eu;Database=PSI20L_AntonioMatos_2220077;User Id=U2220077;Password=Z20Z9GK0;MultipleActiveResultSets=true;";
        public static SqlConnection db = new SqlConnection(ConnectionString);
    }
}
