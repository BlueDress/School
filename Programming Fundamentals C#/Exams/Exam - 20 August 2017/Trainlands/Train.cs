using System.Collections.Generic;

namespace Trainlands
{
    public class Train
    {
        private string name;
        private List<Wagon> wagons;

        public Train(string name)
        {
            this.name = name;
            this.wagons = new List<Wagon>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public List<Wagon> Wagons
        {
            get
            {
                return this.wagons;
            }
        }
    }
}
