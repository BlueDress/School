using System.Collections.Generic;
using System.Text;

namespace Generic_Swap_Method_Integers
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

        public void Swap(int indexOfFirstElement, int indexOfSecondElement)
        {
            var firstElement = this.collection[indexOfFirstElement];
            this.collection[indexOfFirstElement] = this.collection[indexOfSecondElement];
            this.collection[indexOfSecondElement] = firstElement;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in this.collection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString();
        }
    }
}
