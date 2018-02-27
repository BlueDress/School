using CameraBazaar.Services.Models;

namespace CameraBazaar.Services.Contracts
{
    public interface IUserService
    {
        UserDetailsModel GetUserDetails(string username);

        EditUserModel GetUserForEdit(string username);

        void EditUser(string username, string email, string newPassword, string phone);
    }
}
