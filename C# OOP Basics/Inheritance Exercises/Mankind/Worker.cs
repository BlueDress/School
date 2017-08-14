

using System;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workingHoursPerDay;

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                };
                this.weekSalary = value;
            }
        }

        public int WorkingHoursPerDay
        {
            get { return this.workingHoursPerDay; }
            set
            {
                if (value < 1 || 12 < value)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                };
                this.workingHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workingHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHoursPerDay = workingHoursPerDay;
        }

        private decimal SalaryPerHour()
        {
            return this.weekSalary / (5 * this.workingHoursPerDay);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(base.FirstName).Append("Last Name: ").AppendLine(base.LastName).Append("Week Salary: ").AppendLine($"{this.weekSalary:f2}").Append("Hours per day: ").AppendLine($"{this.workingHoursPerDay:f2}").Append("Salary per hour: ").AppendLine($"{SalaryPerHour():f2}");
            return sb.ToString();
        }
    }
}
