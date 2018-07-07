namespace Ch20P06
{
    public class Tomcat : Feline
    {
        public Tomcat(int age, string name, string gender) : base(age, name, gender)
        {
            this.Gender = "Male";
        }

        public override string MakeSound()
        {
            return "Hiss";
        }
    }
}
