using System;
using System.Linq;

namespace Equality_Logic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public override bool Equals(object obj)
        {
            var person = (Person)obj;
            return this.Name == person.Name && this.Age == person.Age;
        }

        public override int GetHashCode()
        {
            var hashCode = this.Name.Length * 10000;
            hashCode = this.Name.Aggregate(hashCode, (current, letter) => current + letter);
            hashCode += this.Age * 10000;
        
            return hashCode;
        }

        public int CompareTo(Person person)
        {
            if (this.Name.CompareTo(person.Name) == 0 && this.Age.CompareTo(person.Age) == 0)
            {
                return 0;
            }
            else
            {
                if (this.Name.CompareTo(person.Name) == 0)
                {
                    return this.Age.CompareTo(person.Age);
                }

                return this.Name.CompareTo(person.Name);
            }
        }
    }
}
