namespace Ch20P06
{
    public class Dog : Animal
    {
        public Dog(int age, string name, string gender) : base(age, name, gender)
        {
        }

        public override string MakeSound()
        {
            return "Woof";
        }
    }
}
