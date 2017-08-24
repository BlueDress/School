using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_List
{
    public class CustomList<T> 
        where T : IComparable
    {
        private IList<T> collection;

        public CustomList()
        {
            this.collection = new List<T>();
        }

        public void Add(T element)
        {
            this.collection.Add(element);
        }

        public void Swap(int indexOfFirstElement, int indexOfSecondElement)
        {
            var firstElement = this.collection[indexOfFirstElement];
            this.collection[indexOfFirstElement] = this.collection[indexOfSecondElement];
            this.collection[indexOfSecondElement] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            var countOfElementsGreater = 0;

            foreach (var item in this.collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    countOfElementsGreater++;
                }
            }

            return countOfElementsGreater;
        }

        public T Remove(int indexOfElementToBeRemoved)
        {
            var removedElement = this.collection[indexOfElementToBeRemoved];
            this.collection.RemoveAt(indexOfElementToBeRemoved);
            return removedElement;
        }

        public bool Contains(T element)
        {
            if (this.collection.Contains(element))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Max()
        {
            return this.collection.Max();
        }

        public T Min()
        {
            return this.collection.Min();
        }

        public void Print()
        {
            foreach (var element in this.collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
