using System;
using System.Linq;

namespace Pet_Clinics
{
    public class Engine
    {
        private ClinicsOperationsController controller;

        public Engine()
        {
            this.controller = new ClinicsOperationsController();
        }

        public void Run()
        {
            ReadData();
        }

        private void ReadData()
        {
            var numberOfCommandLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommandLines; i++)
            {
                var commandArgs = Console.ReadLine().Split().ToList();
                var command = commandArgs[0];
                commandArgs.RemoveAt(0);

                switch (command)
                {
                    case "Create":
                        if (commandArgs[0].Equals("Pet"))
                        {
                            commandArgs.RemoveAt(0);
                            this.controller.CreatePet(commandArgs.ToArray());
                        }
                        else
                        {
                            commandArgs.RemoveAt(0);
                            this.controller.CreateClinic(commandArgs.ToArray());
                        }
                        break;
                    case "Add":
                        Console.WriteLine(this.controller.Add(commandArgs[0], commandArgs[1])); 
                        break;
                    case "Release":
                        Console.WriteLine(this.controller.Release(commandArgs[0])); 
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(this.controller.HasEmptyRooms(commandArgs[0])); 
                        break;
                    case "Print":
                        if (commandArgs.Count == 1)
                        {
                            this.controller.Print(commandArgs[0]);
                        }
                        else
                        {
                            this.controller.Print(commandArgs[0], int.Parse(commandArgs[1]));
                        }
                        break;
                }
            }
        }
    }
}
