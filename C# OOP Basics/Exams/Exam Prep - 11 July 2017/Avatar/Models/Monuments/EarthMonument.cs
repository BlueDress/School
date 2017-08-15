

namespace Avatar.Models.Monument
{
    public class EarthMonument : Monument
    {
        public EarthMonument(string name, int affinity) : base(name, affinity)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"Earth Affinity: {this.Affinity}";
        }
    }
}
