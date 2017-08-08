

namespace Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

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
        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = 0;
            this.color = "n/a";
        }
        public Car(string model, Engine engine, int weight)
            :this(model, engine)
        {
            this.weight = weight;
            this.color = "n/a";
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.weight = 0;
            this.color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }
        public override string ToString()
        {
            if (this.weight == 0)
            {
                return $"{this.model}\n  {this.engine.ToString()}\n  Weight: n/a\n  Color: {this.color}";
            }
            else
            {
                return $"{this.model}\n  {this.engine.ToString()}\n  Weight: {this.weight}\n  Color: {this.color}";
            }
        }
    }
}
