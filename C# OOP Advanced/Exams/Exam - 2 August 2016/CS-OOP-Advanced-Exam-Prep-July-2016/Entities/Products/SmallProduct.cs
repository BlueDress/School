using CS_OOP_Advanced_Exam_Prep_July_2016.Models;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Entities.Products
{
    public class SmallProduct : BaseProduct
    {
        public SmallProduct(string name, int size, int id) : base(name, size, id)
        {
            this.Size = size / 2;
        }
    }
}