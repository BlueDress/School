

namespace Avatar.Models.Monument
{
    public class AirMonument : Monument
    {
        

        public AirMonument(string name, int affinity) : base(name, affinity)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"Air Affinity: {this.Affinity}";
        }
    }
}
