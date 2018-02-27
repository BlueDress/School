using CameraBazaar.Services.Models;

namespace CameraBazaar.Web.Models.Users
{
    public class UserDetailsViewModel
    {
        public UserDetailsModel User { get; set; }

        public bool IsCurrentUser { get; set; }
    }
}
