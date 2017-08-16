

using Paw_Inc.Entities.Animals;
using System.Collections.Generic;

namespace Paw_Inc.Entities.Centres
{
    public class AdoptionCenter : Centre
    {
        public List<Animal> Adopted { get; set; }

        public AdoptionCenter(string name) : base(name)
        {
            this.Adopted = new List<Animal>();
        }

        public void Adopt()
        {
            foreach (var animal in this.Animals)
            {
                if (animal.CleansingStatus)
                {
                    this.Adopted.Add(animal);
                }
            }

            this.Animals.RemoveAll(animal => animal.CleansingStatus == true);
        }

        public List<Animal> SendForCleansing()
        {
            var animalsToBeCleansed = new List<Animal>();
            for (int i = this.Animals.Count - 1; i >= 0; i--)
            {
                if (!this.Animals[i].CleansingStatus)
                {
                    animalsToBeCleansed.Add(this.Animals[i]);
                    this.Animals.RemoveAt(i);
                }
            }
            return animalsToBeCleansed;
        }

        public List<Animal> SendForCastration()
        {
            var animalsToBeCastrated = new List<Animal>();
            for (int i = this.Animals.Count - 1; i >= 0; i--)
            {
                if (!this.Animals[i].Castrated)
                {
                    animalsToBeCastrated.Add(this.Animals[i]);
                    this.Animals.RemoveAt(i);
                }
            }
            return animalsToBeCastrated;
        }
    }
}
