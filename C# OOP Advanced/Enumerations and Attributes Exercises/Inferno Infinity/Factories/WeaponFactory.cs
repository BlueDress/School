using Inferno_Infinity.Entities.Weapons;

namespace Inferno_Infinity.Factories
{
    public static class WeaponFactory
    {
        public static Weapon GetWeapon(string name, string weaponType, WeaponRarity weaponRarity)
        {
            if (weaponType.Equals("Axe"))
            {
                return new Axe(name, weaponRarity);
            }
            else if (weaponType.Equals("Sword"))
            {
                return new Sword(name, weaponRarity);
            }
            else
            {
                return new Knife(name, weaponRarity);
            }
        }
    }
}
