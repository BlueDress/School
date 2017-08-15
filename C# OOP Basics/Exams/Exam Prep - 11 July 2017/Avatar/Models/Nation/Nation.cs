

namespace Avatar.Models.Nation
{
    using Avatar.Models.Monument;
    using Avatar.Models.Bender;
    using System.Collections.Generic;
    using System.Text;
    using System;
    using System.Linq;

    public class Nation
    {
        private List<Bender> benders;
        private List<Monument> monuments;

        public List<Bender> Benders { get { return this.benders; }  }
        public List<Monument> Monuments { get { return this.monuments; } }

        public Nation()
        {
            this.benders = new List<Bender>();
            this.monuments = new List<Monument>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            if (benders.Count == 0)
            {
                sb.AppendLine("Benders: None");
            }
            else
            {
                sb.AppendLine("Benders:");
                sb.AppendLine(string.Join(Environment.NewLine, benders));
            }

            if (monuments.Count == 0)
            {
                sb.AppendLine("Monuments: None");
            }
            else
            {
                sb.AppendLine("Monuments:");
                sb.AppendLine(string.Join(Environment.NewLine, monuments));
            }

            return sb.ToString();
        }

        public double GetTotalPower()
        {
            var totalBendersPower = benders.Sum(b => b.TotalPower);
            var monumentBonusPower = monuments.Sum(m => m.Affinity);

            return (totalBendersPower * monumentBonusPower) / 100 + totalBendersPower;
        }
    }
}
