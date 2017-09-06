using Inferno_Infinity.Entities.Gems;
using System.Collections.Generic;
using System.Linq;

namespace Inferno_Infinity.Entities.Weapons
{
    [Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho, Svetlio")]
    public abstract class Weapon
    {
        private string name;
        private int minDamage;
        private int maxDamage;
        private int strength;
        private int agility;
        private int vitality;
        private List<Gem> sockets;
        private WeaponRarity weaponRarity;

        public Weapon(string name, WeaponRarity weaponRarity)
        {
            this.name = name;
            this.weaponRarity = weaponRarity;
        }

        public List<Gem> Sockets { get { return this.sockets; } set { this.sockets = value; } }
        public string Name { get { return this.name; } }
        protected int MinDamage { set { this.minDamage = value; } }
        protected int MaxDamage { set { this.maxDamage = value; } }


        public override string ToString()
        {
            this.CalculateStats();
            return $"{this.name}: {this.minDamage}-{this.maxDamage} Damage, +{this.strength} Strength, +{this.agility} Agility, +{this.vitality} Vitality";
        }

        private void CalculateStats()
        {
            this.strength = this.sockets.Where(s => s != null).Sum(s => s.Strength);
            this.agility = this.sockets.Where(s => s != null).Sum(s => s.Agility);
            this.vitality = this.sockets.Where(s => s != null).Sum(s => s.Vitality);

            this.minDamage = ((int)this.weaponRarity * this.minDamage) + (this.strength * 2) + this.agility;
            this.maxDamage = ((int)this.weaponRarity * this.maxDamage) + (this.strength * 3) + (this.agility * 4);
        }
    }
}
