namespace Collection_Hierarchy
{
    public class AddCollection : Collection, IAdder
    {
        public int Add(string item)
        {
            this.StringCollection.Add(item);
            return this.StringCollection.Count - 1;
        }
    }
}
