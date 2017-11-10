using System.Data.SqlClient;

namespace CreateDatabase
{
    public class Startup
    {
        public static void Main()
        {
            var sqlConnection = new SqlConnection("Server=LETUM;Integrated Security=true;");
            sqlConnection.Open();

            var command = "create database MinionsDB";
            var createDBCommand = new SqlCommand(command, sqlConnection);

            using (sqlConnection)
            {
                createDBCommand.ExecuteNonQuery();
            }
        }
    }
}
