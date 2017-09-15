namespace Work_Force
{
    public abstract class Employee
    {
        private string name;
        private int workHoursPerWeek;

        public Employee(string name)
        {
            this.name = name;
        }

        public int WorkHoursPerWeek { get { return this.workHoursPerWeek; }set { this.workHoursPerWeek = value; } }
        public string Name { get { return this.name; } }
    }
}
