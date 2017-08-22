using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    internal class Commando : Soldier, IPrivate, ISpecialisedSoldier, ICommando
    {
        public string Corps
        {
            get;
        }

        public List<IMission> Missions
        {
            get;
        }

        public double Salary
        {
            get;
        }

        public Commando(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Corps = corps;
            this.Missions = new List<IMission>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");

            if (this.Missions.Count > 0)
            {
                sb.AppendLine("Missions:");

                foreach (var mission in this.Missions)
                {
                    sb.AppendLine($"  {mission.ToString()}");
                }
            }
            else
            {
                sb.Append("Missions:");
            }

            return sb.ToString();
        }
    }
}
