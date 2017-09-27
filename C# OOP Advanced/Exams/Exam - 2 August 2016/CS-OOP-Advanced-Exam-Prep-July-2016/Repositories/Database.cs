using CS_OOP_Advanced_Exam_Prep_July_2016.Entities.Markets;
using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Repositories
{
    public class Database : IDatabase
    {
        private IList<IProduct> products;
        private IMarket store;

        public Database()
        {
            this.products = new List<IProduct>();
            this.store = new Store(15, new Bazaar(30, new Mall(int.MaxValue, null)));
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public IEnumerable<IProduct> GetProductsBySizeNameType(int size, string name, string type)
        {
            return this.products.Where(p => p.Size == size && p.Name.Equals(name) && p.GetType().Name.Equals(type));
        }

        public IEnumerable<IProduct> GetProductsBySizeName(int size, string name)
        {
            return this.products.Where(p => p.Size == size && p.Name.Equals(name));
        }

        public IProduct GetProductById(int id)
        {
            return this.products.FirstOrDefault(p => p.Id == id);
        }

        public string EditProductInfo(int id, string newName, int newSize)
        {
            var productToEdit = this.GetProductById(id);

            if (productToEdit == null)
            {
                return $"Product {id} does not exist";
            }

            productToEdit.Name = newName;
            productToEdit.Size = newSize;

            return $"Product {id} successfully edited";
        }

        public void AddProductToMarket(string marketType, int productId)
        {
            var currentMarket = this.store;

            while (!currentMarket.GetType().Name.Equals(marketType))
            {
                currentMarket = currentMarket.NextInLine;
            }

            currentMarket.AddProduct(this.GetProductById(productId));
        }

        public IEnumerable<IProduct> GetMarketInfo(string marketType)
        {
            var currentMarket = this.store;

            while (!currentMarket.GetType().Name.Equals(marketType))
            {
                currentMarket = currentMarket.NextInLine;
            }

            return currentMarket.Products;
        }
    }
}