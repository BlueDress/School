

using Avatar.Models.Bender;
using Avatar.Models.Monument;
using Avatar.Models.Nation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Avatar.Controller
{
    public class NationsBuilder
    {
        private Dictionary<string, Nation> nations;
        private List<string> wars;
        
        public NationsBuilder()
        {
            this.nations = new Dictionary<string, Nation>();
            this.wars = new List<string>();
        }
        public void AssignBender(List<string> benderArgs)
        {
            var type = benderArgs[0];
            var name = benderArgs[1];
            var power = int.Parse(benderArgs[2]);
            var secondaryParameter = double.Parse(benderArgs[3]);

            if (!this.nations.ContainsKey(type))
            {
                this.nations[type] = new Nation();
            }
            switch (type)
            {
                case "Air":
                    var airBender =  new AirBender(name, power, secondaryParameter);
                    this.nations[type].Benders.Add(airBender);
                    break;
                case "Earth":
                    var earthBender = new EarthBender(name, power, secondaryParameter);
                    this.nations[type].Benders.Add(earthBender);
                    break;
                case "Fire":
                    var fireBender = new FireBender(name, power, secondaryParameter);
                    this.nations[type].Benders.Add(fireBender);
                    break;
                case "Water":
                    var waterBender = new WaterBender(name, power, secondaryParameter);
                    this.nations[type].Benders.Add(waterBender);
                    break;
            }
        }
        public void AssignMonument(List<string> monumentArgs)
        {
            var type = monumentArgs[0];
            var name = monumentArgs[1];
            var affinity = int.Parse(monumentArgs[2]);

            if (!this.nations.ContainsKey(type))
            {
                this.nations[type] = new Nation();
            }
            switch (type)
            {
                case "Air":
                    var airMonument = new AirMonument(name, affinity);
                    this.nations[type].Monuments.Add(airMonument);
                    break;
                case "Earth":
                    var earthMonument = new EarthMonument(name, affinity);
                    this.nations[type].Monuments.Add(earthMonument);
                    break;
                case "Fire":
                    var fireMonument = new FireMonument(name, affinity);
                    this.nations[type].Monuments.Add(fireMonument);
                    break;
                case "Water":
                    var waterMonument = new WaterMonument(name, affinity);
                    this.nations[type].Monuments.Add(waterMonument);
                    break;
            }
        }
        public string GetStatus(string nationsType)
        {
            return $"{nationsType} Nation{Environment.NewLine}{this.nations[nationsType].ToString()}";
        }
        public void IssueWar(string nationsType)
        {
            this.wars.Add(nationsType);

            var maxPower = nations.Max(n => n.Value.GetTotalPower());

            foreach (var nation in nations)
            {
                if (nation.Value.GetTotalPower() != maxPower)
                {
                    nation.Value.Benders.Clear();
                    nation.Value.Monuments.Clear();
                }
            }
        }
        public string GetWarsRecord()
        {
            var sb = new StringBuilder();

            for (int i = 1; i <= this.wars.Count; i++)
            {
                sb.AppendLine($"War {i} issued by {this.wars[i - 1]}");
            }

            return sb.ToString();
        }

    }
}
