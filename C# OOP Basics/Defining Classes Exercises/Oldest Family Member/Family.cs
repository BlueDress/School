

using System.Collections.Generic;

namespace Oldest_Family_Member
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get
            {
                return this.people;
            }
            set
            {
                this.people = value;
            }
        }

        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember()
        {
            var maxAge = -1;
            var oldestPerson = new Person();

            foreach (var person in people)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldestPerson = person;
                }
            }

            return oldestPerson;
        }
    }
}
