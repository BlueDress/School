
namespace Avatar.Models.Monument
{
    public class WaterMonument : Monument
    {
        public WaterMonument(string name, int affinity) : base(name, affinity)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"Water Affinity: {this.Affinity}";
        }
    }
}
