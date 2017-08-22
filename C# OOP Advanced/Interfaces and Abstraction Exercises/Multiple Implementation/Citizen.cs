using System;

namespace Multiple_Implementation
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public int Age
        {
            get;
        }

        public string Birthdate
        {
            get;
        }

        public string Id
        {
            get;
        }

        public string Name
        {
            get;
        }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}
