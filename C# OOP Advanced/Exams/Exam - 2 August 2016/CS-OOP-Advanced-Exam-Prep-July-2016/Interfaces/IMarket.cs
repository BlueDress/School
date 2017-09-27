using System.Collections.Generic;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces
{
    public interface IMarket
    {
        IMarket NextInLine { get; }
        ICollection<IProduct> Products { get; }

        void AddProduct(IProduct product);
    }
}