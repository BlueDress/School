using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    internal class Engineer : Soldier, IPrivate, IEngineer, ISpecialisedSoldier
    {
        public string Corps
        {
            get;
        }

        public List<IRepair> Repairs
        {
            get;
        }

        public double Salary
        {
            get;
        }

        public Engineer(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Corps = corps;
            this.Repairs = new List<IRepair>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");

            if (this.Repairs.Count > 0)
            {
                sb.AppendLine("Repairs:");

                foreach (var repair in this.Repairs)
                {
                    sb.AppendLine($"  {repair.ToString()}");
                }
            }
            else
            {
                sb.Append("Repairs:");
            }

            return sb.ToString();
        }
    }
}
