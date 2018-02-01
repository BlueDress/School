namespace DirectoryTraversal
{
    internal class MyFile
    {
        public MyFile(string name, int size)
        {
            this.Size = size;
            this.Name = name;
        }

        public int Size { get; set; }

        public string Name { get; set; }
    }
}