using Inferno_Infinity.Entities.Gems;
using System.Collections.Generic;

namespace Inferno_Infinity.Entities.Weapons
{
    public class Sword : Weapon
    {
        public Sword(string name, WeaponRarity weaponRarity) : base(name, weaponRarity)
        {
            this.MinDamage = 4;
            this.MaxDamage = 6;
            this.Sockets = new List<Gem>(new Gem[3]);
        }
    }
}
