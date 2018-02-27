using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CameraBazaar.Data.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Camera> AddedCameras { get; set; } = new List<Camera>();
    }
}
