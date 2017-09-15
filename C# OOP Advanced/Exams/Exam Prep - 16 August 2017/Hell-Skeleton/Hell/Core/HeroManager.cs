using Hell.Entities.Items;
using Hell.Interfaces.Core;
using Hell.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class HeroManager : IManager
{
    private SortedSet<IHero> heroes;

    public HeroManager(SortedSet<IHero> heroes)
    {
        this.heroes = heroes;
    }

    public string AddHero(IList<string> arguments)
    {
        string heroName = arguments[0];
        string heroType = arguments[1];

        Type heroClass = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name.Equals(heroType));
        var constructors = heroClass.GetConstructors();
        IHero hero = (IHero)constructors[0].Invoke(new object[] { heroName, new HeroInventory() });
        this.heroes.Add(hero);

        return string.Format($"Created {heroType} - {heroName}");
    }

    public string AddItemToHero(IList<string> arguments)
    {
        string itemName = arguments[0];
        string heroName = arguments[1];
        long strengthBonus = long.Parse(arguments[2]);
        long agilityBonus = long.Parse(arguments[3]);
        long intelligenceBonus = long.Parse(arguments[4]);
        long hitPointsBonus = long.Parse(arguments[5]);
        long damageBonus = long.Parse(arguments[6]);

        IHero hero = this.heroes.First(h => h.Name.Equals(heroName));

        if (arguments.Count == 7)
        {
            IItem commonItem = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus);
            hero.AddCommonItem(commonItem);
            return $"Added item - {itemName} to Hero - {heroName}";
        }
        else
        {
            IRecipe recipe = new Recipe(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus, arguments.Skip(7).ToArray());
            hero.AddRecipe(recipe);
            return $"Added recipe - {itemName} to Hero – {heroName}";
        }
    }

    public string Inspect(IList<string> arguments)
    {
        string heroName = arguments[0];

        IHero hero = this.heroes.First(h => h.Name.Equals(heroName));

        return GenerateHeroInfo(hero);
    }

    private string GenerateHeroInfo(IHero hero)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Hero: {hero.Name}, Class: {hero.GetType().Name}");
        sb.AppendLine($"HitPoints: {hero.HitPoints}, Damage: {hero.Damage}");
        sb.AppendLine($"Strength: {hero.Strength}");
        sb.AppendLine($"Agility: {hero.Agility}");
        sb.AppendLine($"Intelligence: { hero.Intelligence}");

        if (hero.Inventory.CommonItems.Count == 0 && hero.Inventory.RecipeItems.Count == 0)
        {
            sb.AppendLine("Items: None");
        }
        else
        {
            foreach (var item in hero.Inventory.CommonItems)
            {
                sb.AppendLine("Items:");
                sb.AppendLine($"###Item: {item.Key}");
                sb.AppendLine($"###+{item.Value.StrengthBonus} Strength");
                sb.AppendLine($"###+{item.Value.AgilityBonus} Agility");
                sb.AppendLine($"###+{item.Value.IntelligenceBonus} Intelligence");
                sb.AppendLine($"###+{item.Value.HitPointsBonus} HitPoints");
                sb.AppendLine($"###+{item.Value.DamageBonus} Damage");
            }
        }

        return sb.ToString();
    }

    public string Quit(IList<string> args)
    {
        var sb = new StringBuilder();
        var counter = 1;
        foreach (var hero in this.heroes)
        {

            sb.AppendLine($"{counter++}. {hero.GetType().Name}: {hero.Name}");
            sb.AppendLine($"###HitPoints: {hero.HitPoints}");
            sb.AppendLine($"###Damage: {hero.Damage}");
            sb.AppendLine($"###Strength: {hero.Strength}");
            sb.AppendLine($"###Agility: {hero.Agility}");
            sb.AppendLine($"###Intelligence: {hero.Intelligence}");

            if (hero.Inventory.CommonItems.Count == 0)
            {
                sb.AppendLine("###Items: None");
            }
            else
            {
                sb.AppendLine($"###Items: {string.Join(", ", hero.Items.Select(i => i.Name))}");
            }
        }

        return sb.ToString();
    }
}