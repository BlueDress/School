

namespace Paw_Inc.Entities.Animals
{
    public class Dog : Animal
    {
        public int AmountOFComands { get; set; }

        public Dog(string name, int age, string adoptionCentre, int amountOfCommands) : base(name, age, adoptionCentre)
        {
            this.AmountOFComands = amountOfCommands;
        }
    }
}
