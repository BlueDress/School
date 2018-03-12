using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public ICollection<StudentCourses> CoursesAttending { get; set; } = new List<StudentCourses>();

        public ICollection<Article> Articles { get; set; } = new List<Article>();

        public ICollection<Course> CoursesTraining { get; set; } = new List<Course>();
    }
}
