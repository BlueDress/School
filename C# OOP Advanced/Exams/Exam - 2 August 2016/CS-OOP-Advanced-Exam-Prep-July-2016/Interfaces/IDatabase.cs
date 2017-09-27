using System.Collections.Generic;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces
{
    public interface IDatabase
    {
        void AddProduct(IProduct product);

        IEnumerable<IProduct> GetProductsBySizeNameType(int size, string name, string type);

        IEnumerable<IProduct> GetProductsBySizeName(int size, string name);

        IProduct GetProductById(int id);

        string EditProductInfo(int id, string newName, int newSize);

        void AddProductToMarket(string marketType, int productId);

        IEnumerable<IProduct> GetMarketInfo(string marketType);
    }
}