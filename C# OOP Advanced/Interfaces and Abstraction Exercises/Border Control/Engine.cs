using System;

namespace Border_Control
{
    internal class Engine
    {
        private EntrantsOperationController controller;

        internal Engine()
        {
            this.controller = new EntrantsOperationController();
        }

        internal void Run()
        {
            ReadData();
            PrintFakeIds();
        }

        private void PrintFakeIds()
        {
            var idCheck = Console.ReadLine();

            foreach (var entrant in this.controller.Entrants)
            {
                if (this.controller.FakeId(entrant.ID, idCheck))
                {
                    Console.WriteLine(entrant.ID);
                }
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
                    var entrantData = input.Split();

                    if (entrantData.Length == 3)
                    {
                        this.controller.RegisterPerson(entrantData);
                    }
                    else
                    {
                        this.controller.RegisterRobot(entrantData);
                    }
                }
            }
        }
    }
}
