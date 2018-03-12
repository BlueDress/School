using System;
using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Services.Models.Courses
{
    public class CreateCourseModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TrainerId { get; set; }
    }
}
