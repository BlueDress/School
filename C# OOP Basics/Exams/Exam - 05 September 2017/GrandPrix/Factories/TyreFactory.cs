using GrandPrix.Models.Tyres;
using System.Collections.Generic;

namespace GrandPrix.Factories
{
    public class TyreFactory
    {
        public static Tyre GetTyre(List<string> tyreArguments)
        {
            var type = tyreArguments[0];
            var hardness = double.Parse(tyreArguments[1]);

            if (type.Equals("Hard"))
            {
                return new HardTyre(hardness);
            }
            else if (type.Equals("Ultrasoft"))
            {
                var grip = double.Parse(tyreArguments[2]);

                return new UltrasoftTyre(hardness, grip);
            }
            else
            {
                return null;
            }
        }
    }
}
