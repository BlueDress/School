using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace NewsSystem.Data.Models
{
    public class User : IdentityUser
    {
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
