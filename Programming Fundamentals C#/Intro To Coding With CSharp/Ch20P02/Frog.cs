namespace Ch20P06
{
    public class Frog : Animal
    {
        public Frog(int age, string name, string gender) : base(age, name, gender)
        {
        }

        public override string MakeSound()
        {
            return "Ribbit";
        }
    }
}
