using System;

namespace Animals
{
    public class Tomcat : Cat
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
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = "Male";
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Give me one million b***h");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
