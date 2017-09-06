using System;
using System.Collections.Generic;

namespace Explicit_Interfaces
{
    public class Startup
    {
        public static void Main()
        {
            var citizens = new List<Citizen>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                var citizenInfo = input.Split();
                var name = citizenInfo[0];
                var country = citizenInfo[1];
                var age = int.Parse(citizenInfo[2]);

                var citizen = new Citizen(name, country, age);
                citizens.Add(citizen);
            }

            foreach (var citizen in citizens)
            {
                var person = (IPerson)citizen;
                var resident = (IResident)citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
