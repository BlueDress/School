using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace ImplementFirstLastList
{
    public class FirstLastList<T> : IFirstLastList<T> where T : IComparable<T>
    {
        private IList<T> listElements;
        private OrderedBag<T> orderedElements;

        public FirstLastList()
        {
            this.listElements = new List<T>();
            this.orderedElements = new OrderedBag<T>();
        }

        public int Count
        {
            get
            {
                return this.listElements.Count;
            }
        }

        public void Add(T element)
        {
            this.listElements.Add(element);
            this.orderedElements.Add(element);
        }

        public void Clear()
        {
            this.listElements.Clear();
            this.orderedElements.Clear();
        }

        public IEnumerable<T> First(int count)
        {
            ValidateCount(count);

            return this.listElements.Take(count);
        }

        public IEnumerable<T> Last(int count)
        {
            ValidateCount(count);

            return this.listElements.Skip(this.Count - count);
        }

        public IEnumerable<T> Max(int count)
        {
            ValidateCount(count);

            return this.orderedElements.Take(this.Count - count);
        }

        public IEnumerable<T> Min(int count)
        {
            ValidateCount(count);

            return this.orderedElements.Take(count);
        }

        public int RemoveAll(T element)
        {
            this.listElements = this.listElements.Where(e => !e.Equals(element)).ToList();
            return this.orderedElements.RemoveAll(e => e.Equals(element)).Count;
        }

        private void ValidateCount(int count)
        {
            if (count < 0 || this.Count < count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
