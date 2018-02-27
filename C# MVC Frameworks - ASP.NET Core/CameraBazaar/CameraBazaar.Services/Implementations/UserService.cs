using CameraBazaar.Data;
using CameraBazaar.Services.Contracts;
using CameraBazaar.Services.Models;
using System.Linq;

namespace CameraBazaar.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly CameraBazaarDbContext db;

        public UserService(CameraBazaarDbContext db)
        {
            this.db = db;
        }

        public UserDetailsModel GetUserDetails(string username)
        {
            return this.db.Users.Where(u => u.UserName.Equals(username)).Select(u => new UserDetailsModel
            {
                Username = u.UserName,
                Email = u.Email,
                Phone = u.PhoneNumber,
                Cameras = u.AddedCameras.Select(c => new ListAllCamerasModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    Make = c.Make,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl,
                    IsInStock = c.Quantity > 0 ? true : false
                }),
            }).First();
        }

        public EditUserModel GetUserForEdit(string username)
        {
            return this.db.Users.Where(u => u.UserName.Equals(username)).Select(u => new EditUserModel
            {
                Username = u.UserName,
                Email = u.Email,
                Phone = u.PhoneNumber,
                CurrentPassword = u.PasswordHash
            }).First();
        }

        public void EditUser(string username, string email, string newPassword, string phone)
        {
            var user = this.db.Users.First(u => u.UserName.Equals(username));

            user.Email = email;
            user.PasswordHash = newPassword;
            user.PhoneNumber = phone;

            this.db.SaveChanges();
        }
    }
}
