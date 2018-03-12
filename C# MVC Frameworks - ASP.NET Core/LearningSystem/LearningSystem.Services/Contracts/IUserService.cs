using LearningSystem.Services.Models.Users;
using System.Collections.Generic;

namespace LearningSystem.Services.Contracts
{
    public interface IUserService
    {
        IEnumerable<AdminListAllUsersModel> GetAllUsers();
    }
}
