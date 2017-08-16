

using Paw_Inc.Entities.Animals;
using System.Collections.Generic;

namespace Paw_Inc.Entities.Centres
{
    public class CleansingCenter : Centre
    {
        public List<Animal> Cleansed { get; set; }
        public CleansingCenter(string name) : base(name)
        {
            this.Cleansed = new List<Animal>();
        }

        public List<Animal> Clean()
        {
            foreach (var animal in this.Animals)
            {
                animal.CleansingStatus = true;
                Cleansed.Add(animal);
            }
            var cleansedAnimals = new List<Animal>();
            cleansedAnimals.AddRange(this.Animals);
            this.Animals.Clear();
            return cleansedAnimals;
        }
    }
}
