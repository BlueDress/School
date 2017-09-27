using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using CS_OOP_Advanced_Exam_Prep_July_2016.Models;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Entities.Markets
{
    public class Store : BaseMarket
    {
        private const int Capacity = 15;

        public Store(int capacity, IMarket nextInLine) : base(Capacity, nextInLine)
        {
        }
    }
}