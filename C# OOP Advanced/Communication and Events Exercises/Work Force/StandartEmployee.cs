namespace Work_Force
{
    public class StandartEmployee : Employee
    {
        public StandartEmployee(string name) : base(name)
        {
            this.WorkHoursPerWeek = 40;
        }
    }
}
