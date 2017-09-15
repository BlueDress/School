namespace Work_Force
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name) : base(name)
        {
            this.WorkHoursPerWeek = 20;
        }
    }
}
