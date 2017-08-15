using Avatar.Controller;
using System;
using System.Linq;

namespace Avatar
{
    public class StartUp
    {
        public static void Main()
        {
            ReadAndPrintData();
        }

        private static void ReadAndPrintData()
        {
            var controller = new NationsBuilder();
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Quit"))
                {
                    break;
                }
                else
                {
                    var commands = input.Split().ToList();
                    var command = commands[0];
                    var type = commands[1];
                    commands.RemoveAt(0);

                    switch (command)
                    {
                        case "Bender":
                            controller.AssignBender(commands);
                            break;
                        case "Monument":
                            controller.AssignMonument(commands);
                            break;
                        case "War":
                            controller.IssueWar(type);
                            break;
                        case "Status":
                            Console.WriteLine(controller.GetStatus(type)); 
                            break;
                    }
                }
            }

            Console.WriteLine(controller.GetWarsRecord()); 
        }
    }
}
