namespace Threeuple
{
    public class Threeuple<T1, T2, T3>
    {
        private T1 firstItem;
        private T2 secondItem;
        private T3 thirdItem;

        public Threeuple(T1 firstItem, T2 secondItem, T3 thirdItem)
        {
            this.firstItem = firstItem;
            this.secondItem = secondItem;
            this.thirdItem = thirdItem;
        }

        public override string ToString()
        {
            return $"{this.firstItem} -> {this.secondItem} -> {this.thirdItem}";
        }
    }
}
