using System.Collections.Generic;
using System.Linq;

namespace CameraBazaar.Services.Models
{
    public class UserDetailsModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public IEnumerable<ListAllCamerasModel> Cameras { get; set; }

        public int CamerasInStock => this.Cameras.Where(c => c.IsInStock).Count();

        public int CamerasOutOfStock => this.Cameras.Where(c => !c.IsInStock).Count();
    }
}
