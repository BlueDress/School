namespace Border_Control
{
    internal class Person : IEntrant
    {
        public string ID
        {
            get;
        }

        public string Name
        {
            get;
        }

        internal int Age
        {
            get;
        }

        internal Person(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
    }
}
