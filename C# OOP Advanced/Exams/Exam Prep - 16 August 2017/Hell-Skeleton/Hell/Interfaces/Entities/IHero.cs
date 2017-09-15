using System.Collections.Generic;

namespace Hell.Interfaces.Entities
{
    public interface IHero
    {
        void AddCommonItem(IItem commonItem);

        void AddRecipe(IRecipe recipe);

        string Name { get; }

        long HitPoints { get; set; }

        long Damage { get; set; }

        long Strength { get; set; }

        long Agility { get; set; }

        long Intelligence { get; set; }

        IInventory Inventory { get; }

        long PrimaryStats { get; }

        long SecondaryStats { get; }

        ICollection<IItem> Items { get; }
    }
}
