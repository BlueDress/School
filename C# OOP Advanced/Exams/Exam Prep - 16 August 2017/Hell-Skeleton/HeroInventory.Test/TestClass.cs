using Hell.Entities.Items;
using NUnit.Framework;

namespace HeroInventoryClass.Test
{
    [TestFixture]
    public class TestClass
    {
        private HeroInventory inventory;

        [SetUp]
        public void TestInit()
        {
            this.inventory = new HeroInventory();
        }

        [Test]
        public void TestAddCommonItemMethod()
        {
            this.inventory.AddCommonItem(new CommonItem("item1", 10, 11, 12, 13, 14));
            this.inventory.AddCommonItem(new CommonItem("item2", 0, 0, 0, 0, 0));

            Assert.AreEqual(2, this.inventory.CommonItems.Count);
        }

        [Test]
        public void TestAddRecipeItemMethod()
        {
            this.inventory.AddRecipeItem(new Recipe("recipe", 20, 21, 22, 23, 24, new string[2] { "item1", "item2"}));

            Assert.AreEqual(1, this.inventory.RecipeItems.Count);
        }

        [Test]
        public void TestCalculationOFStrengthBonus()
        {
            this.inventory.AddCommonItem(new CommonItem("item1", 10, 11, 12, 13, 14));
            Assert.AreEqual(10, this.inventory.TotalStrengthBonus);
        }

        [Test]
        public void TestCalculationOFAgilityBonus()
        {
            this.inventory.AddCommonItem(new CommonItem("item1", 10, 11, 12, 13, 14));
            Assert.AreEqual(11, this.inventory.TotalAgilityBonus);
        }

        [Test]
        public void TestCalculationOFIntelligenceBonus()
        {
            this.inventory.AddCommonItem(new CommonItem("item1", 10, 11, 12, 13, 14));
            Assert.AreEqual(12, this.inventory.TotalIntelligenceBonus);
        }

        [Test]
        public void TestCalculationOFHitPointsBonus()
        {
            this.inventory.AddCommonItem(new CommonItem("item1", 10, 11, 12, 13, 14));
            Assert.AreEqual(13, this.inventory.TotalHitPointsBonus);
        }

        [Test]
        public void TestCalculationOFDamageBonus()
        {
            this.inventory.AddCommonItem(new CommonItem("item1", 10, 11, 12, 13, 14));
            Assert.AreEqual(14, this.inventory.TotalDamageBonus);
        }
    }
}
