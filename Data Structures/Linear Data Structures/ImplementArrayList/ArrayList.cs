using System;

namespace ImplementArrayList
{
    public class ArrayList<T>
    {
        private T[] collection;

        public ArrayList()
        {
            this.collection = new T[2];
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
            if (this.Count == this.collection.Length)
            {
                this.Resize();
            }

            this.collection[this.Count++] = item;
        }

        public T RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var item = this.collection[index];

            this.Shift(index);
            this.Count--;

            if (this.Count <= this.collection.Length / 4)
            {
                Shrink();
            }

            return item;
        }

        private void Resize()
        {
            var newCollection = new T[this.collection.Length * 2];

            for (int i = 0; i < this.collection.Length; i++)
            {
                newCollection[i] = this.collection[i];
            }

            this.collection = newCollection;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.collection[i] = this.collection[i + 1];
            }
        }

        private void Shrink()
        {
            var newCollection = new T[this.collection.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                newCollection[i] = this.collection[i];
            }

            this.collection = newCollection;
        }
    }
}
