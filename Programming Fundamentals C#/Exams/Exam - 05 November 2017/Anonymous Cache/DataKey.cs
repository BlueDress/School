namespace Anonymous_Cache
{
    public class DataKey
    {
        private string name;
        private long size;

        public DataKey(string name, long size)
        {
            this.name = name;
            this.size = size;
        }

        public string Name { get => this.name;  }
        public long Size { get => this.size;  }
    }
}
