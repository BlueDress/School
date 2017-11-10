using System.Data.SqlClient;
using System.IO;

namespace PopulateDatabase
{
    public class Startup
    {
        public static void Main()
        {
            var sqlConnection = new SqlConnection("Server=LETUM;Integrated Security=true;");
            sqlConnection.Open();

            var querry = File.ReadAllText("../../InitialSetupMinionsDB.sql");
            var populateMinionsDBCommand = new SqlCommand(querry, sqlConnection);

            using (sqlConnection)
            {
                populateMinionsDBCommand.ExecuteNonQuery();
            }
        }
    }
}
