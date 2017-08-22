namespace Birthday_Celebrations
{
    internal class Citizen : IBirthdayCelebrators
    {
        private string ID
        {
            get;
        }

        private string Name
        {
            get;
        }

        private int Age
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
            this.ID = id;
            this.Birthdate = birthdate;
        }
    }
}
