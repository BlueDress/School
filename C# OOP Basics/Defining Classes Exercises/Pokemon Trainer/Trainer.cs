

using System.Collections.Generic;

namespace Pokemon_Trainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Badges
        {
            get
            {
                return this.badges;
            }
            set
            {
                this.badges = value;
            }
        }
        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }
        public Trainer()
        {
            this.pokemons = new List<Pokemon>();
            this.badges = 0;
        }
    }
}
