namespace Collection_Hierarchy
{
    public class MyList : Collection, IAdder, IRemover
    {
        public int Used { get { return this.StringCollection.Count; } }

        public int Add(string item)
        {
            this.StringCollection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            var result = this.StringCollection[0];
            this.StringCollection.RemoveAt(0);
            return result;
        }
    }
}
