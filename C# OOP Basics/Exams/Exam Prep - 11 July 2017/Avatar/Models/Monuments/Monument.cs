

namespace Avatar.Models.Monument
{
    public abstract class Monument
    {
        private string name;
        private int affinity;

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Affinity { get { return this.affinity; } set { this.affinity = value; } }

        public Monument(string name, int affinity)
        {
            this.Name = name;
            this.Affinity = affinity;
        }

        public override string ToString()
        {
            var name = this.GetType().Name;
            var index = name.IndexOf("Monument");
            name = name.Insert(index, " ");

            return $"###{name}: {this.Name}, ";
        }
    }
}
