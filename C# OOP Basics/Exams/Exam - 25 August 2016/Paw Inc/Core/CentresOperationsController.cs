

using Paw_Inc.Entities.Animals;
using Paw_Inc.Entities.Centres;
using System.Collections.Generic;
using System.Linq;

namespace Paw_Inc.Core
{
    public class CentresOperationsController
    {
        public List<CleansingCenter> CleansingCentres { get; set; }
        public List<AdoptionCenter> AdoptionCentres { get; set; }
        public List<CastrationCenter> CastrationCentres { get; set; }

        public CentresOperationsController()
        {
            this.AdoptionCentres = new List<AdoptionCenter>();
            this.CleansingCentres = new List<CleansingCenter>();
            this.CastrationCentres = new List<CastrationCenter>();
        }

        public void RegisterCleansingCenter(string name)
        {
            var centre = new CleansingCenter(name);
            this.CleansingCentres.Add(centre);
        }

        public void RegisterAdoptionCenter(string name)
        {
            var centre = new AdoptionCenter(name);
            this.AdoptionCentres.Add(centre);
        }

        public void RegisterCastrationCenter(string name)
        {
            var centre = new CastrationCenter(name);
            this.CastrationCentres.Add(centre);
        }

        public void RegisterDog(string[] dogData)
        {
            var name = dogData[0];
            var age = int.Parse(dogData[1]);
            var amountOfCommands = int.Parse(dogData[2]);
            var adoptionCentre = dogData[3];

            var dog = new Dog(name, age, adoptionCentre, amountOfCommands);

            this.AdoptionCentres.Find(ac => ac.Name.Equals(adoptionCentre)).Animals.Add(dog);
        }

        public void RegisterCat(string[] catData)
        {
            var name = catData[0];
            var age = int.Parse(catData[1]);
            var iq = int.Parse(catData[2]);
            var adoptionCentre = catData[3];

            var cat = new Cat(name, age, adoptionCentre, iq);

            this.AdoptionCentres.Find(ac => ac.Name.Equals(adoptionCentre)).Animals.Add(cat);
        }

        public void SendForCleansing(string adoptionCentreName, string cleansingCenterName)
        {
            var adoptionCentre = this.AdoptionCentres.Find(ac => ac.Name.Equals(adoptionCentreName));
            var animalsSendForCleansing = adoptionCentre.SendForCleansing();

            var cleansingCentre = this.CleansingCentres.Find(cc => cc.Name.Equals(cleansingCenterName));
            cleansingCentre.Animals.AddRange(animalsSendForCleansing);
        }

        public void Cleanse(string cleansingCenterName)
        {
            var cleansingCentre = this.CleansingCentres.Find(cc => cc.Name.Equals(cleansingCenterName));
            var cleansedAnimals = cleansingCentre.Clean();
            foreach (var animal in cleansedAnimals)
            {
                var adoptionCentreName = animal.AdoptionCentre;
                this.AdoptionCentres.Find(ac => ac.Name.Equals(adoptionCentreName)).Animals.Add(animal);
            }
        }

        public void SendForCastration(string adoptionCentreName, string castrationCenterName)
        {
            var adoptionCentre = this.AdoptionCentres.Find(ac => ac.Name.Equals(adoptionCentreName));
            var animalsSendForCastration = adoptionCentre.SendForCastration();

            var castrationCenter = this.CastrationCentres.Find(cc => cc.Name.Equals(castrationCenterName));
            castrationCenter.Animals.AddRange(animalsSendForCastration);
        }

        public void Castrate(string castrationCenterName)
        {
            var castrationCenter = this.CastrationCentres.Find(cc => cc.Name.Equals(castrationCenterName));
            var castratedAnimals = castrationCenter.Castrate();
            foreach (var animal in castratedAnimals)
            {
                var adoptionCentreName = animal.AdoptionCentre;
                this.AdoptionCentres.Find(ac => ac.Name.Equals(adoptionCentreName)).Animals.Add(animal);
            }
        }

        public void Adopt(string adoptionCentreName)
        {
            var adoptionCentre = this.AdoptionCentres.Find(ac => ac.Name.Equals(adoptionCentreName));
            adoptionCentre.Adopt();
        }

        public List<Animal> GetAllAdoptedAnimals()
        {
            var adoptedAnimals = new List<Animal>();

            foreach (var centre in this.AdoptionCentres)
            {
                if (centre.Adopted.Count > 0)
                {
                    adoptedAnimals.AddRange(centre.Adopted);
                }
            }
            return adoptedAnimals.OrderBy(a => a.Name).ToList();
        }

        public List<Animal> GetAllCleansedAnimals()
        {
            var cleansedAnimals = new List<Animal>();

            foreach (var centre in this.CleansingCentres)
            {
                if (centre.Cleansed.Count > 0)
                {
                    cleansedAnimals.AddRange(centre.Cleansed);
                }
            }
            return cleansedAnimals.OrderBy(a => a.Name).ToList();
        }

        public List<Animal> GetAllCastratedAnimals()
        {
            var castratedAnimals = new List<Animal>();

            foreach (var centre in this.CastrationCentres)
            {
                if (centre.Castrated.Count > 0)
                {
                    castratedAnimals.AddRange(centre.Castrated);
                }
            }
            return castratedAnimals.OrderBy(a => a.Name).ToList();
        }

        public int AnimalsWaitingForAdoption()
        {
            var amountOfAnimalsWaitingForAdoption = 0;

            foreach (var centre in this.AdoptionCentres)
            {
                foreach (var animal in centre.Animals)
                {
                    if (animal.CleansingStatus)
                    {
                        amountOfAnimalsWaitingForAdoption++;
                    }
                }
            }
            return amountOfAnimalsWaitingForAdoption;
        }

        public int AnimalsWaitingForCleansing()
        {
            return this.CleansingCentres.Sum(x => x.Animals.Count());
        }
    }
}
