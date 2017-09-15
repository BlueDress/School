using Hell.Interfaces.Entities;

namespace Hell.Entities.Heroes
{
    public class Wizard : AbstractHero
    {
        public Wizard(string name, IInventory inventory) : base(name, inventory)
        {
            this.Strength = 25;
            this.Agility = 25;
            this.Intelligence = 100;
            this.HitPoints = 100;
            this.Damage = 250;
        }
    }
}
