using Hell.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public abstract class AbstractHero : IHero
{
    private IInventory inventory;
    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    public AbstractHero(string name, IInventory inventory)
    {
        this.Name = name;
        this.inventory = inventory;
    }

    public string Name { get; private set; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.HitPoints + this.Damage; }
    }

    public IInventory Inventory
    {
        get
        {
            return this.inventory;
        }
    }
    
    public ICollection<IItem> Items
    {
        get
        {
            Type type = Type.GetType("HeroInventory");

            var field = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(f => f.GetCustomAttributes().Any(a => a.GetType().Name.Equals("ItemAttribute")));

            Dictionary<string, IItem> commonItems = (Dictionary<string, IItem>)field.GetValue(this.Inventory);

            ICollection<IItem> commonItemCollection = new List<IItem>();

            foreach (var item in commonItems)
            {
                commonItemCollection.Add(item.Value);
            }

            return commonItemCollection;
        }
    }

    public void AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
    }

    public void AddCommonItem(IItem commonItem)
    {
        this.inventory.AddCommonItem(commonItem);
    }
}