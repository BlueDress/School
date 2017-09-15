using Hell.Interfaces.Entities;

namespace Hell.Entities.Items
{
    public class CommonItem : AbstractItem, IItem
    {
        public CommonItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus, long hitPointsBonus, long damageBonus) : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
        {
        }
    }
}
