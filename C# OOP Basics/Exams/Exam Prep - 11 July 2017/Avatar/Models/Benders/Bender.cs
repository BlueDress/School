

namespace Avatar.Models.Bender
{
    public abstract class Bender
    {
        private string name;
        private int power;
        private double totalPower;

        public double TotalPower { get { return this.totalPower; } set { this.totalPower = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Power { get { return this.power; } set { this.power = value; } }

        public Bender(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public override string ToString()
        {
            var name = this.GetType().Name;
            var index = name.IndexOf("Bender");
            name = name.Insert(index, " ");

            return $"###{name}: {this.Name}, Power: {this.Power}, ";
        }
    }
}
