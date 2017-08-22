using System;
using System.Linq;

namespace Birthday_Celebrations
{
    internal class Engine
    {
        private BirthdateController controller;

        internal Engine()
        {
            this.controller = new BirthdateController();
        }

        internal void Run()
        {
            ReadData();
            PrintBirthDates();
        }

        private void PrintBirthDates()
        {
            var yearCheck = Console.ReadLine();

            foreach (var birthdayCelebrator in this.controller.BirthdayCelebrators)
            {
                if (this.controller.HasBirthday(birthdayCelebrator.Birthdate, yearCheck))
                {
                    Console.WriteLine(birthdayCelebrator.Birthdate);
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
                    var commands = input.Split().ToList();
                    var command = commands[0];
                    commands.RemoveAt(0);
                    var birthdateCelebrantData = commands.ToArray();
                    switch (command)
                    {
                        case "Citizen":
                            this.controller.RegisterPerson(birthdateCelebrantData);
                            break;
                        case "Pet":
                            this.controller.RegisterPet(birthdateCelebrantData);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
