using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    internal class LeutenantGeneral : Soldier, IPrivate, ILeutenantGeneral
    {
        public List<Private> PrivatesUnderCommand
        {
            get;
        }

        public double Salary
        {
            get;
        }

        public LeutenantGeneral(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.PrivatesUnderCommand = new List<Private>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()} Salary: {this.Salary:f2}");

            if (this.PrivatesUnderCommand.Count > 0)
            {
                sb.AppendLine("Privates:{}");

                foreach (var privateSoldier in this.PrivatesUnderCommand)
                {
                    sb.AppendLine($"  {privateSoldier.ToString()}");
                }
            }
            else
            {
                sb.Append("Privates:");
            }

            return sb.ToString();
        }
    }
}
