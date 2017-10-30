namespace Pokemon_Evolution
{
    public class Pokemon
    {
        private string pokemonName;
        private string evolutionType;
        private int evolutionIndex;

        public Pokemon(string pokemonName, string evolutionType, int evolutionIndex)
        {
            this.pokemonName = pokemonName;
            this.evolutionType = evolutionType;
            this.evolutionIndex = evolutionIndex;
        }

        public string PokemonName
        {
            get
            {
                return this.pokemonName;
            }
        }

        public string EvolutionType
        {
            get
            {
                return this.evolutionType;
            }
        }

        public int EvolutionIndex
        {
            get
            {
                return this.evolutionIndex;
            }
        }
    }
}
