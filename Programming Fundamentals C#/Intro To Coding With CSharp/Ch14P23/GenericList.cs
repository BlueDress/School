using System;
using System.Linq;

namespace Ch14P23
{
    public class GenericList<T>
    {
        private T[] collection;

        public GenericList(int capacity)
        {
            this.collection = new T[capacity];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.collection[index];
            }

            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.collection[index] = value;
            }
        }

        public void Add(T item)
        {
            this.collection[this.Count++] = item;
        }

        public void RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            T item = this.collection[index];

            this.ShiftDown(index);
            this.Count--;
        }

        public void AddAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.ShiftUp(index);
            this.Count++;

            T item = this.collection[index];
        }

        public void Clear()
        {
            for (int i = 0; i < this.collection.Length; i++)
            {
                this.collection[i] = default(T);
            }
        }

        public T Find(T value)
        {
            return this.collection.FirstOrDefault(x => x.Equals(value));
        }

        private void ShiftUp(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.collection[i] = this.collection[i + 1];
            }
        }

        private void ShiftDown(int index)
        {
            for (int i = index; i < this.Count - 2; i++)
            {
                this.collection[i + 1] = this.collection[i];
            }
        }
    }
}
