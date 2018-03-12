using LearningSystem.Services.Models.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LearningSystem.Web.Areas.Admin.Models
{
    public class AddUserToRoleModel
    {
        public IEnumerable<AdminListAllUsersModel> Users { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
