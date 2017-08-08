

using System;

namespace Google
{
    public class Parent
    {
        private string name;
        private DateTime birthDate;

        public Parent(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{this.name} {this.birthDate.ToString("dd/MM/yyyy")}";
        }
    }
}
