

namespace Avatar.Models.Monument
{
    public class FireMonument : Monument
    {
        public FireMonument(string name, int affinity) : base(name, affinity)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"Fire Affinity: {this.Affinity}";
        }
    }
}
