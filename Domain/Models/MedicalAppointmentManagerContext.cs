using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace MedicalAppointmentManager.Domain.Models
{
    public partial class MedicalAppointmentManagerContext : DbContext
    {
        public MedicalAppointmentManagerContext()
        {
        }

        public MedicalAppointmentManagerContext(DbContextOptions<MedicalAppointmentManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //TODO: Obtener de appsettings.json
                optionsBuilder.UseSqlServer("Data Source=JaViDesktop\\SQLEXPRESS;Initial Catalog=MedicalAppointmentManager;User Id=mamapi;Password=sqlmamapi!1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeId");

                entity.Property(e => e.PatientId).HasColumnName("PatientId");

                entity.Property(e => e.DateTime)
                    .IsRequired()
                    .HasColumnName("DateTime")
                    .HasColumnType("datetime2");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("Place")
                    .HasMaxLength(500)
                    .IsFixedLength();

                entity.Property(e => e.Requirements)
                    .IsRequired()
                    .HasColumnName("Requirements")
                    .IsFixedLength();

                entity.Property(e => e.Observations)
                    .IsRequired()
                    .HasColumnName("Observations")
                    .IsFixedLength();

                entity.HasOne(d => d.Employee)
                   .WithMany()
                   .HasForeignKey(d => d.EmployeeId)
                  .HasConstraintName("FK_Appointments_Employees");

                entity.HasOne(d => d.Patient)
                  .WithMany()
                  .HasForeignKey(d => d.PatientId)
                 .HasConstraintName("FK_Appointments_Patients");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("Nif")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FirstName")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LastName")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CollegiateNumber)
                    .IsRequired()
                    .HasColumnName("CollegiateNumber")
                    .IsFixedLength();

                entity.Property(e => e.ConsultationType)
                    .IsRequired()
                    .HasColumnName("ConsultationType")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("Address")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Specialities)
                    .IsRequired()
                    .HasColumnName("Specialities")
                    .HasMaxLength(500)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("Nif")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FirstName")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LastName")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("Phone")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("Company")
                    .HasMaxLength(500)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
