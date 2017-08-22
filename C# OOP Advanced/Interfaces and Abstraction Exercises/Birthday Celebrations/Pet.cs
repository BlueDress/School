namespace Birthday_Celebrations
{
    internal class Pet : IBirthdayCelebrators
    {
        private string Name { get; }
        public string Birthdate { get; }

        internal Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
