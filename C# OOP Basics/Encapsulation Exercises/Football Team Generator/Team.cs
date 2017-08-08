

using System;
using System.Collections.Generic;

namespace Football_Team_Generator
{
    public class Team
    {
        private string name;
        private int rating;
        private List<Player> players;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Equals(null) || value.Equals(" ") || value.Equals(string.Empty))
                {
                    throw new ArgumentException("A name should not be empty. ");
                }

                this.name = value;
            }
        }

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public int Rating()
        {
            var rating = 0d;

            foreach (var player in players)
            {
                rating += (player.Endurance + player.Sprint + player.Dribble + player.Passing + player.Shooting) / 5;
            }

            return (int)Math.Round(rating);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            if (this.players.Contains(player))
            {
                this.players.Remove(player);
            }
            else
            {
                throw new ArgumentException($"Player {player.Name} is not in {this.Name} team. ");
            }
        }
    }
}
