

namespace Google
{
    public class Car
    {
        private string model;
        private double speed;

        public Car(string model, double speed)
        {
            this.model = model;
            this.speed = speed;
        }
        public override string ToString()
        {
            return $"{this.model} {this.speed}";
        }
    }
}
