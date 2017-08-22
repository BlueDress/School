namespace Food_Shortage
{
    internal class Rebel : IBuyer, IPerson
    {
        public int Age
        {
            get;
        }

        public int Food
        {
            get;

            set;
        }

        public string Name
        {
            get;
        }

        public string Group
        {
            get;
        }

        internal Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
