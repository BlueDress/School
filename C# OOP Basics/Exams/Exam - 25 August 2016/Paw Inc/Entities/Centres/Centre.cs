

using Paw_Inc.Entities.Animals;
using System.Collections.Generic;

namespace Paw_Inc.Entities.Centres
{
    public abstract class Centre
    {
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }

        public Centre(string name)
        {
            this.Name = name;
            this.Animals = new List<Animal>();
        }
    }
}
