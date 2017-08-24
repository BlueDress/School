namespace Generic_Array_Creator
{
    public static class ArrayCreator<T>
    {
        public static T[] Create(int length, T item)
        {
            var array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}
