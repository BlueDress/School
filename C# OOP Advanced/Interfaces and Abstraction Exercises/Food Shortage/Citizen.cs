namespace Food_Shortage
{
    internal class Citizen : IPerson, IBuyer
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

        public string Id
        {
            get;
        }

        public string Birthdate
        {
            get;
        }

        internal Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
