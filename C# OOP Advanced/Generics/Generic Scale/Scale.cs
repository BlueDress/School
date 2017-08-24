using System;

namespace Generic_Scale
{
    public class Scale<T>
            where T : IComparable
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier(T left, T right) 
        {
            if (left.CompareTo(right) > 0)
            {
                return left;
            }
            else if (left.CompareTo(right) < 0)
            {
                return right;
            }
            else
            {
                return default(T);
            }
        }
    }
}
