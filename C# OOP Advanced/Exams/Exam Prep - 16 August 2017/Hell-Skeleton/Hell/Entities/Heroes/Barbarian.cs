using Hell.Interfaces.Entities;

namespace Hell.Entities.Heroes
{
    public class Barbarian : AbstractHero
    {
        public Barbarian(string name, IInventory inventory) : base(name, inventory)
        {
            this.Strength = 90;
            this.Agility = 25;
            this.Intelligence = 10;
            this.HitPoints = 350;
            this.Damage = 150;
        }
    }
}
