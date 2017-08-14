using System;

namespace Animals
{
    public class Kittens : Cat
    {
        private string gender;

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }
        public Kittens(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = "Female";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
