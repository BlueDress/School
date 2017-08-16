
namespace Paw_Inc.Entities.Animals
{
    public class Cat : Animal
    {
        public int IQ { get; set; }

        public Cat(string name, int age, string adoptionCentre, int iq) : base(name, age, adoptionCentre)
        {
            this.IQ = iq;
        }
    }
}
