using Hell.Interfaces.Entities;
using System.Collections.Generic;

namespace Hell.Entities.Items
{
    public class Recipe : AbstractItem, IRecipe
    {
        private IList<string> requiredItems;

        public Recipe(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus, params string[] commonItemNames) : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
        {
            this.requiredItems = commonItemNames;
        }

        public IList<string> RequiredItems
        {
            get
            {
                return this.requiredItems;
            }
        }
    }
}
