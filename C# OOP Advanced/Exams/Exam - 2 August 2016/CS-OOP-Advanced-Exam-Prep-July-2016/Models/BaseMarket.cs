using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models
{
    public abstract class BaseMarket : IMarket
    {
        private int capacity;

        private IMarket nextInLine;

        private ICollection<IProduct> products;

        public BaseMarket(int capacity, IMarket nextInLine)
        {
            this.capacity = capacity;
            this.nextInLine = nextInLine;
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            if (product.Size + this.products.Sum(p => p.Size) > this.capacity)
            {
                this.nextInLine.AddProduct(product);
            }
            else
            {
                this.products.Add(product);
            }
        }

        public ICollection<IProduct> Products { get { return this.products; } }

        //public int Capacity { get; set; }

        public IMarket NextInLine { get { return this.nextInLine; } }
    }
}