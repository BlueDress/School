using System;

namespace Define_an_Interface_IPerson
{
    public class Citizen : IPerson
    {
        public int Age
        {
            get;
        }

        public string Name
        {
            get;
        }

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
