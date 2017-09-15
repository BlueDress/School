using Hell.Interfaces.Entities;
using System.Collections.Generic;

namespace Hell.Entities.Miscellaneous
{
    public class HeroComparator : IComparer<IHero>
    {
        public int Compare(IHero firstHero, IHero secondHero)
        {
            return firstHero.PrimaryStats.CompareTo(secondHero.PrimaryStats) != 0 ? firstHero.PrimaryStats.CompareTo(secondHero.PrimaryStats) : firstHero.SecondaryStats.CompareTo(secondHero.SecondaryStats);
        }
    }
}
