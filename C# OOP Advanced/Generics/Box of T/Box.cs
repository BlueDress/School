using System.Collections.Generic;
using System.Linq;

namespace Box_of_T
{
    public class Box<T>
    {
        private IList<T> collection;

        public Box()
        {
            this.collection = new List<T>();
        }

        public void Add(T element)
        {
            this.collection.Add(element);
        }

        public int Count { get { return this.collection.Count; } }

        public T Remove()
        {
            var lastElement = this.collection.LastOrDefault();
            this.collection.RemoveAt(this.collection.Count - 1);
            return lastElement;
        }
    }
}
