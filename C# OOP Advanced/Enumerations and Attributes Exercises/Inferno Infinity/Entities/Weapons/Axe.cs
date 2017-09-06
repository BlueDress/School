using Inferno_Infinity.Entities.Gems;
using System.Collections.Generic;

namespace Inferno_Infinity.Entities.Weapons
{
    public class Axe : Weapon
    {
        public Axe(string name, WeaponRarity weaponRarity) : base(name, weaponRarity)
        {
            this.MinDamage = 5;
            this.MaxDamage = 10;
            this.Sockets = new List<Gem>(new Gem[4]);
        }
    }
}
