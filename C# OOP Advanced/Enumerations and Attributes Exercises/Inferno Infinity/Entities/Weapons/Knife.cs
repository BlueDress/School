using Inferno_Infinity.Entities.Gems;
using System.Collections.Generic;

namespace Inferno_Infinity.Entities.Weapons
{
    public class Knife : Weapon
    {
        public Knife(string name, WeaponRarity weaponRarity) : base(name, weaponRarity)
        {
            this.MinDamage = 3;
            this.MaxDamage = 4;
            this.Sockets = new List<Gem>(new Gem[2]);
        }
    }
}
