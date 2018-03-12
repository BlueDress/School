using LearningSystem.Data;
using LearningSystem.Services.Contracts;
using LearningSystem.Services.Models.Users;
using System.Collections.Generic;
using System.Linq;

namespace LearningSystem.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly LearningSystemDbContext db;

        public UserService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<AdminListAllUsersModel> GetAllUsers()
        {
            return this.db.Users.Select(u => new AdminListAllUsersModel
            {
                Username = u.UserName,
                Name = u.Name,
                Id = u.Id
            });
        }
    }
}
