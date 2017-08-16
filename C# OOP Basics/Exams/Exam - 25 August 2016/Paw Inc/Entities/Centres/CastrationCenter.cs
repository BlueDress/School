

using Paw_Inc.Entities.Animals;
using System.Collections.Generic;

namespace Paw_Inc.Entities.Centres
{
    public class CastrationCenter : Centre
    {
        public List<Animal> Castrated { get; set; }

        public CastrationCenter(string name) : base(name)
        {
            this.Castrated = new List<Animal>();
        }

        public List<Animal> Castrate()
        {
            foreach (var animal in this.Animals)
            {
                animal.Castrated = true;
                Castrated.Add(animal);
            }
            var castratedAnimals = new List<Animal>();
            castratedAnimals.AddRange(this.Animals);
            this.Animals.Clear();
            return castratedAnimals;
        }
    }
}
