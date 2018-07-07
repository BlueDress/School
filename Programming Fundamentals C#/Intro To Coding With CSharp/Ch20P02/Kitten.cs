namespace Ch20P06
{
    public class Kitten : Feline
    {
        public Kitten(int age, string name, string gender) : base(age, name, gender)
        {
        }

        public override string MakeSound()
        {
            return "Purr";
        }
    }
}
