using System;

namespace Explicit_Interfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name { get; }
        public string Country { get; }
        public int Age { get; }

        string IResident.Name
        {
            get
            {
                return this.Name;
            }
        }

        string IPerson.Name
        {
            get
            {
                return this.Name;
            }
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
