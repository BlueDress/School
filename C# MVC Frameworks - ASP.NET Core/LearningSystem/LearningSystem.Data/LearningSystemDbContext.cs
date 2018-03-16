using LearningSystem.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearningSystem.Data
{
    public class LearningSystemDbContext : IdentityDbContext<User>
    {
        public LearningSystemDbContext(DbContextOptions<LearningSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Course>().HasOne(c => c.Trainer).WithMany(u => u.CoursesTraining).HasForeignKey(c => c.TrainerId);

            builder.Entity<Article>().HasOne(a => a.Author).WithMany(u => u.Articles).HasForeignKey(a => a.AuthorId);

            builder.Entity<StudentCourses>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<Course>().HasMany(c => c.Students).WithOne(sc => sc.Course).HasForeignKey(sc => sc.CourseId);

            builder.Entity<User>().HasMany(u => u.CoursesAttending).WithOne(sc => sc.Student).HasForeignKey(sc => sc.StudentId);

            base.OnModelCreating(builder);
        }
    }
}
