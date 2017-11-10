using System;
using System.Data.SqlClient;
using System.IO;

namespace Get_Villains_Names
{
    public class Startup
    {
        public static void Main()
        {
            var sqlConnection = new SqlConnection("Server=LETUM;Integrated Security=true;");
            sqlConnection.Open();

            var querry = File.ReadAllText("../../VillainsWhitMoreThanOneMinion.sql");
            var getVillainsCommand = new SqlCommand(querry, sqlConnection);

            using (sqlConnection)
            {
                var reader = getVillainsCommand.ExecuteReader();

                using (reader)
                {
                    while (true)
                    {
                        if (!reader.Read())
                        {
                            break;
                        }

                        var villainName = reader["Name"].ToString();
                        var minionsCount = int.Parse(reader["MinionsCount"].ToString());

                        Console.WriteLine($"{villainName} {minionsCount}");
                    }
                }
            }
        }
    }
}
