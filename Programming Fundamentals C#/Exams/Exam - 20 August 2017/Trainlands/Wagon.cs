namespace Trainlands
{
    public class Wagon
    {
        private string name;
        private int power;

        public Wagon(string name, int power)
        {
            this.name = name;
            this.power = power;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }
        }
    }
}
