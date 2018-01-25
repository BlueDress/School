using System.Collections.Generic;

namespace ProductsShop.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<CategoryProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CategoryProduct> Products { get; set; }
    }
}
