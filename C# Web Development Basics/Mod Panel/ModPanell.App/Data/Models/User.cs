using ModPanell.App.Data.Models.PositionType;
using System.Collections.Generic;

namespace ModPanell.App.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsApproved { get; set; }

        public List<Post> Posts { get; set; }

        public Position Position { get; set; }
    }
}
