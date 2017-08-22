using System;
using System.Linq;

namespace Military_Elite
{
    internal class Engine
    {
        private MilitaryOperationsController controller;

        internal Engine()
        {
            this.controller = new MilitaryOperationsController();
        }

        internal void Run()
        {
            ReadData();
            PrintSoldiersData();
        }

        private void PrintSoldiersData()
        {
            foreach (var soldier in this.controller.Soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        private void ReadData()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    var commands = input.Split().ToList();
                    var command = commands[0];
                    commands.RemoveAt(0);
                    var soldierData = commands.ToArray();

                    switch (command)
                    {
                        case "Private":
                            this.controller.RegisterPrivate(soldierData);
                            break;
                        case "LeutenantGeneral":
                            this.controller.RegisterLeutenantGeneral(soldierData);
                            break;
                        case "Engineer":
                            if (soldierData[4].Equals("Airforces") || soldierData[4].Equals("Marines"))
                            {
                                this.controller.RegisterEngineer(soldierData);
                            }
                            break;
                        case "Commando":
                            if (soldierData[4].Equals("Airforces") || soldierData[4].Equals("Marines"))
                            {
                                this.controller.RegisterCommando(soldierData);
                            }
                            break;
                        case "Spy":
                            this.controller.RegisterSpy(soldierData);
                            break;
                    }
                }
            }
        }
    }
}
