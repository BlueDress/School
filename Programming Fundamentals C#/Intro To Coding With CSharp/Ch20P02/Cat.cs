namespace Ch20P06
{
    public class Cat : Feline
    {
        public Cat(int age, string name, string gender) : base(age, name, gender)
        {
            this.Gender = "Female";
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
