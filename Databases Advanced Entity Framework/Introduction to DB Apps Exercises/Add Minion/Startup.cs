using System;
using System.Data.SqlClient;
using System.IO;

namespace Add_Minion
{
    public class Startup
    {
        public static void Main()
        {
            var minionData = Console.ReadLine().Split();
            var minionName = minionData[1];
            var minionAge = int.Parse(minionData[2]);
            var minionTown = minionData[3];

            //var villainData = Console.ReadLine().Split();
            //var villainName = villainData[1];

            var checkTownQuerry = File.ReadAllText("../../CheckTown.sql");
            var getTownQuerry = File.ReadAllText("../../GetTownId.sql");
            var insertIntoTownsQuerry = File.ReadAllText("../../InsertIntoTown.sql");
            var insertIntoMinionsQuerry = File.ReadAllText("../../InsertIntoMinions.sql");

            var sqlConnection = new SqlConnection("Server=LETUM;Integrated Security=true;");
            sqlConnection.Open();

            var checkTownCommand = new SqlCommand(checkTownQuerry, sqlConnection);
            var getTownCommand = new SqlCommand(getTownQuerry, sqlConnection);
            var insertIntoTownsCommand = new SqlCommand(insertIntoTownsQuerry, sqlConnection);
            var insertIntoMinionsCommand = new SqlCommand(insertIntoMinionsQuerry, sqlConnection);

            var checkParameter = new SqlParameter("@townName", minionTown);
            var getParameter = new SqlParameter("@townName", minionTown);
            var insertIntoParameter = new SqlParameter("@townName", minionTown);
            var insertIntoNameParameter = new SqlParameter("@name", minionName);
            var insertIntoAgeParameter = new SqlParameter("@age", minionAge);

            checkTownCommand.Parameters.Add(checkParameter);
            getTownCommand.Parameters.Add(getParameter);
            insertIntoTownsCommand.Parameters.Add(insertIntoParameter);

            using (sqlConnection)
            {
                var townName = checkTownCommand.ExecuteScalar();

                if (townName == null)
                {
                    insertIntoTownsCommand.ExecuteNonQuery();
                    Console.WriteLine($"Town {minionTown} was added to the database.");
                }

                var townId = int.Parse(getTownCommand.ExecuteScalar().ToString());
                var insertIntoTownParameter = new SqlParameter("@townId", townId);

                insertIntoMinionsCommand.Parameters.AddRange(new[] { insertIntoNameParameter, insertIntoAgeParameter, insertIntoTownParameter });

                insertIntoMinionsCommand.ExecuteNonQuery();
                Console.WriteLine($"Successfully added {minionName}");
            }
        }
    }
}
