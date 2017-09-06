using System.Linq;

namespace Collection_Hierarchy
{
    public class AddRemoveCollection : Collection, IAdder, IRemover
    {
        public int Add(string item)
        {
            this.StringCollection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            var result = this.StringCollection.Last();
            this.StringCollection.RemoveAt(this.StringCollection.Count - 1);
            return result;
        }
    }
}
