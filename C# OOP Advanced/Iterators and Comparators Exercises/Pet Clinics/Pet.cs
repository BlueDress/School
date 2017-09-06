namespace Pet_Clinics
{
    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public Pet(string name, int age, string kind)
        {
            this.name = name;
            this.age = age;
            this.kind = kind;
        }

        public string Name { get { return this.name; } }

        public override string ToString()
        {
            return $"{this.Name} {this.age} {this.kind}";
        }
    }
}
