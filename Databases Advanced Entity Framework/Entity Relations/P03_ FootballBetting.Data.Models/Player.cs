using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    public class Player
    {
        public Player()
        {
            this.PlayerStatistic = new List<PlayerStatistic>();
        }

        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string SquadNumber { get; set; }
        public bool IsInjured { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistic { get; set; }
    }
}
