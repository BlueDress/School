using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;
using System.IO;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        
        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = File.ReadAllText("C:\\Program Files (x86)\\Notepad++\\Instructions.txt");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(e =>
            {
                e.HasKey(s => s.StudentId);

                e.Property(s => s.Name).IsRequired().IsUnicode().HasMaxLength(100);

                e.Property(s => s.PhoneNumber).IsRequired(false).IsUnicode(false).HasColumnType("CHAR(10)");

                e.Property(s => s.RegisteredOn).IsRequired().HasColumnType("datetime2");

                e.Property(s => s.BirthDay).IsRequired(false).HasColumnType("datetime2");
            });

            modelBuilder.Entity<Course>(e =>
            {
                e.HasKey(c => c.CourseId);

                e.Property(c => c.Name).IsRequired().IsUnicode().HasMaxLength(80);

                e.Property(c => c.Description).IsRequired(false).IsUnicode();

                e.Property(c => c.StartDate).IsRequired().HasColumnType("datetime2");

                e.Property(c => c.EndDate).IsRequired().HasColumnType("datetime2");

                e.Property(c => c.Price).IsRequired();
            });

            modelBuilder.Entity<Resource>(e =>
            {
                e.HasKey(r => r.ResourceId);

                e.Property(r => r.Name).IsRequired().IsUnicode().HasMaxLength(50);

                e.Property(r => r.Url).IsRequired().IsUnicode(false);

                e.Property(r => r.ResourceType).IsRequired();

                e.HasOne(r => r.Course).WithMany(c => c.Recourses).HasForeignKey(r => r.CourseId);
            });

            modelBuilder.Entity<Homework>(e =>
            {
                e.ToTable("HomeworkSubmissions");

                e.HasKey(h => h.HomeworkId);

                e.Property(h => h.Content).IsRequired().IsUnicode(false);

                e.Property(h => h.ContentType).IsRequired(false);

                e.Property(h => h.SubmissionTime).IsRequired().HasColumnType("datetime2");

                e.HasOne(h => h.Student).WithMany(s => s.HomeworkSubmissions).HasForeignKey(h => h.StudentId);

                e.HasOne(h => h.Course).WithMany(s => s.HomeworkSubmissions).HasForeignKey(h => h.CourseId);
            });

            modelBuilder.Entity<StudentCourse>(e =>
            {
                e.ToTable("StudentCourses");

                e.HasKey(sc => new { sc.StudentId, sc.CourseId });

                e.HasOne(sc => sc.Student).WithMany(s => s.CourseEnrollments).HasForeignKey(sc => sc.StudentId);

                e.HasOne(sc => sc.Course).WithMany(c => c.StudentsEnrolled).HasForeignKey(sc => sc.CourseId);
            });
        }
    }
}
