

using System;

namespace Google
{
    public class Child
    {
        private string name;
        private DateTime birthDate;

        public Child(string name, DateTime birthDate)
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
