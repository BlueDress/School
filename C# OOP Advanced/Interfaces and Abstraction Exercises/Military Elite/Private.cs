namespace Military_Elite
{
    public class Private : Soldier, IPrivate
    {
        public double Salary
        {
            get;
        }

        public Private(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:f2}";
        }
    }
}
