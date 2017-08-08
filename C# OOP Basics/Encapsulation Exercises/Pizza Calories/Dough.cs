

using System;

namespace Pizza_Calories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            set
            {
                if (!value.Equals("white") && !value.Equals("wholegrain"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                };

                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            set
            {
                if (!value.Equals("crispy") && !value.Equals("chewy") && !value.Equals("homemade"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                };

                this.bakingTechnique = value;
            }
        }

        private double Weight
        {
            set
            {
                if (value < 1 || 200 < value)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                };

                this.weight = value;
            }
        }

        public double TotalCalories()
        {
            var flourTypeModifier = 0d;
            var bakingTechniqueModifier = 0d;

            if (this.flourType.Equals("white"))
            {
                flourTypeModifier = 1.5;
            }
            else
            {
                flourTypeModifier = 1;
            }

            if (this.bakingTechnique.Equals("chrispy"))
            {
                bakingTechniqueModifier = 0.9;
            }
            else if (this.bakingTechnique.Equals("chewy"))
            {
                bakingTechniqueModifier = 1.1;
            }
            else
            {
                bakingTechniqueModifier = 1;
            }

            return this.weight * 2 * flourTypeModifier * bakingTechniqueModifier;
        }
    }
}
