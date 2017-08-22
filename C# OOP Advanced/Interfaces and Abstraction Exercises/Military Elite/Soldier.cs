namespace Military_Elite
{
    public abstract class Soldier : ISoldier
    {
        public string FirstName
        {
            get;
        }

        public string Id
        {
            get;
        }

        public string LastName
        {
            get;
        }

        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
