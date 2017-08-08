
namespace Car_Salesman
{
    public class Engine
    {
        private string model;
        private string power;
        private int displacement;
        private string efficiency;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }
        public int Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }
        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }
        public Engine(string model, string power)
        {
            this.model = model;
            this.power = power;
            this.displacement = 0;
            this.efficiency = "n/a";
        }
        public Engine(string model, string power, int displacement)
            :this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = "n/a";
        }
        public Engine(string model, string power, string efficiency)
            :this(model, power)
        {
            this.displacement = 0;
            this.efficiency = efficiency;
        }
        public Engine(string model, string power, int displacement, string efficiency)
            :this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
        public override string ToString()
        {
            if (this.displacement == 0)
            {
                return $"{this.model}:\n    Power: {this.power}\n    Displacement: n/a\n    Efficiency: {this.efficiency}";
            }
            else
            {
                return $"{this.model}:\n    Power: {this.power}\n    Displacement: {this.displacement}\n    Efficiency: {this.efficiency}";
            }
        }
    }
}
