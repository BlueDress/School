namespace Ch20P06
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private string gender;

        public Animal(int age, string name, string gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"{this.Name} is {this.Age} years old and it is {this.Gender}";
        }
    }
}
