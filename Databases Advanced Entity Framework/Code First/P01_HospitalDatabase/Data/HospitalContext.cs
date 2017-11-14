using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;
using System.IO;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {

        }

        public HospitalContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PatientMedicament> PatientsMedicaments { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

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
            modelBuilder.Entity<Patient>(e =>
            {
                e.HasKey(p => p.PatientId);

                e.Property(p => p.FirstName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

                e.Property(p => p.LastName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

                e.Property(p => p.Address)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(250);

                e.Property(p => p.Email)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(80);

                e.Property(p => p.HasInsurance)
                .HasDefaultValue(true);
            });

            modelBuilder.Entity<Visitation>(e =>
            {
                e.HasKey(v => v.VisitationId);

                e.Property(v => v.Date)
                .IsRequired()
                .HasColumnType("DATETIME2")
                .HasDefaultValueSql("GETDATE()");

                e.Property(v => v.Comments)
                .IsRequired(false)
                .IsUnicode()
                .HasMaxLength(250);

                e.HasOne(v => v.Patient)
                .WithMany(p => p.Visitations)
                .HasForeignKey(v => v.PatientId)
                .HasConstraintName("FK_Visitation_Patient");

                e.HasOne(v => v.Doctor)
                .WithMany(d => d.Visitations)
                .HasForeignKey(v => v.DoctorId)
                .HasConstraintName("FK_Visitation_Doctor");
            });

            modelBuilder.Entity<Diagnose>(e =>
            {
                e.HasKey(d => d.DiagnoseId);

                e.Property(d => d.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

                e.Property(d => d.Comments)
                .IsRequired(false)
                .IsUnicode()
                .HasMaxLength(250);

                e.HasOne(d => d.Patient)
                .WithMany(p => p.Diagnoses)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK_Diagnose_Patient");
            });

            modelBuilder.Entity<Medicament>(e =>
            {
                e.HasKey(m => m.MedicamentId);

                e.Property(m => m.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            });

            modelBuilder.Entity<PatientMedicament>(e =>
            {
                e.HasKey(pm => new { pm.PatientId, pm.MedicamentId });

                e.HasOne(pm => pm.Medicament)
                .WithMany(m => m.Prescriptions)
                .HasForeignKey(pm => pm.MedicamentId);

                e.HasOne(pm => pm.Patient)
                .WithMany(p => p.Prescriptions)
                .HasForeignKey(pm => pm.PatientId);
            });

            modelBuilder.Entity<Doctor>(e =>
            {
                e.HasKey(d => d.DoctorId);

                e.Property(d => d.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);

                e.Property(d => d.Specialty)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(100);
            });
        }
    }
}
