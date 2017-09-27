using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using CS_OOP_Advanced_Exam_Prep_July_2016.Models;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Entities.Markets
{
    public class Mall : BaseMarket
    {
        private const int Capacity = int.MaxValue;

        public Mall(int capacity, IMarket nextInLine) : base(Capacity, nextInLine)
        {
        }
    }
}