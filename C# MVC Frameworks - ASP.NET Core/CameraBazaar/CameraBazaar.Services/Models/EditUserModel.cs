namespace CameraBazaar.Services.Models
{
    public class EditUserModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string NewPassword { get; set; }

        public string CurrentPassword { get; set; }

        public string Phone { get; set; }
    }
}
