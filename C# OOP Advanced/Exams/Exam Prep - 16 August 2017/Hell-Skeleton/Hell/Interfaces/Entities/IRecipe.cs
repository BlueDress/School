using System.Collections.Generic;

namespace Hell.Interfaces.Entities
{
    public interface IRecipe
    {
        IList<string> RequiredItems { get; }

        string Name { get; }

        long StrengthBonus { get; }

        long AgilityBonus { get; }

        long IntelligenceBonus { get; }

        long HitPointsBonus { get; }

        long DamageBonus { get; }
    }
}
