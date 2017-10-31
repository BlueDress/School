using System.Collections.Generic;

namespace CODE_Phoenix_Oscar_Romeo_November
{
    public class Creature
    {
        private string name;
        private List<Creature> squadMates;

        public Creature(string name)
        {
            this.name = name;
            this.squadMates = new List<Creature>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public List<Creature> SquadMates
        {
            get
            {
                return this.squadMates;
            }
        }
    }
}
