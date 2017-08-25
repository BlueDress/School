using System;

namespace Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person otherPerson)
        {
            if (this.name.CompareTo(otherPerson.name) != 0)
            {
                return this.name.CompareTo(otherPerson.name);
            }
            else
            {
                if (this.age.CompareTo(otherPerson.age) != 0)
                {
                    return this.age.CompareTo(otherPerson.age);
                }
                else
                {
                    return this.town.CompareTo(otherPerson.town);
                }
            }
        }
    }
}
