using System;
using System.Data.SqlClient;
using System.IO;

namespace Get_Minion_Names
{
    public class Startup
    {
        public static void Main()
        {
            var villainId = int.Parse(Console.ReadLine());

            var sqlConnection = new SqlConnection("Server=LETUM;Integrated Security=true;");
            sqlConnection.Open();

            var villainNameByIdQuerry = File.ReadAllText("../../SelectVillainNameById.sql");

            var minionsByVillainIdQuerry = File.ReadAllText("../../SelectMinionsNameByVillain.sql");

            var getVillainNameByIdCommand = new SqlCommand(villainNameByIdQuerry, sqlConnection);
            var getMinionsByVillainIdCommand = new SqlCommand(minionsByVillainIdQuerry, sqlConnection);

            var parameterForVillainCommand = new SqlParameter("@villainId", villainId);
            var parameterForMinionsCommand = new SqlParameter("@villainId", villainId);

            getVillainNameByIdCommand.Parameters.Add(parameterForVillainCommand);
            getMinionsByVillainIdCommand.Parameters.Add(parameterForMinionsCommand);

            using (sqlConnection)
            {
                var villainName = getVillainNameByIdCommand.ExecuteScalar();

                if (villainName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in thedatabase.");
                }
                else
                {
                    Console.WriteLine($"Villain: {villainName.ToString()}");

                    var reader = getMinionsByVillainIdCommand.ExecuteReader();

                    using (reader)
                    {
                        var minionNumber = 1;

                        while (true)
                        {
                            if (!reader.Read())
                            {
                                break;
                            }

                            var minionName = reader["Name"].ToString();
                            var minionAge = reader["Age"].ToString();

                            Console.WriteLine($"{minionNumber++}. {minionName} {minionAge}");
                        }
                    }
                }
            }
        }
    }
}
