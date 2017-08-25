using System.Collections.Generic;

namespace Strategy_Pattern
{
    public class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            return firstPerson.Name.Length.CompareTo(secondPerson.Name.Length) != 0 ? firstPerson.Name.Length.CompareTo(secondPerson.Name.Length) : firstPerson.Name.ToLower()[0].CompareTo(secondPerson.Name.ToLower()[0]);
        }
    }
}
