

namespace Paw_Inc.Entities.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool CleansingStatus { get; set; }
        public string AdoptionCentre { get; set; }
        public bool Castrated { get; set; }

        public Animal(string name, int age, string adoptionCentre)
        {
            this.Name = name;
            this.Age = age;
            this.AdoptionCentre = adoptionCentre;
            this.CleansingStatus = false;
            this.Castrated = false;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
