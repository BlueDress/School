using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Cache
{
    public class DataSet
    {
        private string name;
        private List<DataKey> dataKeys;

        public DataSet(string name)
        {
            this.name = name;
            this.dataKeys = new List<DataKey>();
        }

        public string Name { get => this.name; }
        public List<DataKey> DataKeys { get => this.dataKeys; }

        public long GetDataKeySize()
        {
            return this.dataKeys.Sum(x => x.Size);
        }
    }
}
