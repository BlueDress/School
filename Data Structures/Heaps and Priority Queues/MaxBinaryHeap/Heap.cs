using System;

namespace MaxBinaryHeap
{
    public static class Heap<T> where T : IComparable<T>
    {
        public static void Sort(T[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var index = i;

                while (true)
                {
                    if (index >= arr.Length / 2)
                    {
                        break;
                    }

                    if (arr.Length > 2 * index + 2 && arr[2 * index + 1].CompareTo(arr[2 * index + 2]) <= 0 && arr[index].CompareTo(arr[2 * index + 2]) <= 0)
                    {
                        Swap(arr, index, 2 * index + 2);

                        index = 2 * index + 2;
                    }
                    else if (arr[index].CompareTo(arr[2 * index + 1]) <= 0)
                    {
                        Swap(arr, index, 2 * index + 1);

                        index = 2 * index + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, i, 0);

                var index = 0;

                while (true)
                {
                    if (2 * index + 2 >= i)
                    {
                        break;
                    }

                    if (arr.Length > 2 * index + 2 && arr[2 * index + 1].CompareTo(arr[2 * index + 2]) <= 0 && arr[index].CompareTo(arr[2 * index + 2]) <= 0)
                    {
                        Swap(arr, index, 2 * index + 2);

                        index = 2 * index + 2;
                    }
                    else if (arr[index].CompareTo(arr[2 * index + 1]) <= 0)
                    {
                        Swap(arr, index, 2 * index + 1);

                        index = 2 * index + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void Swap(T[] arr, int childIndex, int parentIndex)
        {
            var temp = arr[childIndex];
            arr[childIndex] = arr[parentIndex];
            arr[parentIndex] = temp;
        }
    }
}
