using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TrainerId { get; set; }
        public User Trainer { get; set; }

        public ICollection<StudentCourses> Students { get; set; } = new List<StudentCourses>();
    }
}