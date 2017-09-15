using System.Collections.Generic;

namespace Hell.Interfaces.Entities
{
    public interface IInventory
    {
        long TotalAgilityBonus { get; }

        long TotalDamageBonus { get; }

        long TotalHitPointsBonus { get; }

        long TotalIntelligenceBonus { get; }

        long TotalStrengthBonus { get; }

        Dictionary<string, IRecipe> RecipeItems { get; }

        Dictionary<string, IItem> CommonItems { get; }

        void AddCommonItem(IItem item);

        void AddRecipeItem(IRecipe recipe);
    }
}
