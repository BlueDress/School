

using System.Collections.Generic;

namespace Family_Tree
{
    public class Person
    {
        private string name;
        private string birthDate;
        private List<Person> parents;
        private List<Person> children;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }
        public List<Person> Parents
        {
            get
            {
                return this.parents;
            }
            set
            {
                this.parents = value;
            }
        }
        public List<Person> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                this.children = value;
            }
        }
        public Person(string name, string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.parents = new List<Person>();
            this.children = new List<Person>();
        }
        public override string ToString()
        {
            return $"{this.name} {this.birthDate}";
        }
    }
}
