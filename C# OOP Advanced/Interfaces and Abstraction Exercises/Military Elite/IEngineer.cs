using System.Collections.Generic;

namespace Military_Elite
{
    public interface IEngineer
    {
        List<IRepair> Repairs { get; }
    }
}
