using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Clinic.AppModels
{
    public partial class ClinicModel : DbContext
    {
        public ClinicModel()
            : base("name=ClinicModel")
        {
        }

        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Medics> Medics { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genders>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Genders)
                .HasForeignKey(e => e.GenderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medics>()
                .HasMany(e => e.Visits)
                .WithRequired(e => e.Medics)
                .HasForeignKey(e => e.MedicId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patients>()
                .Property(e => e.Height)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Patients>()
                .Property(e => e.Weight)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Patients>()
                .Property(e => e.InvalidnostGroup)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Patients>()
                .HasMany(e => e.Visits)
                .WithRequired(e => e.Patients)
                .HasForeignKey(e => e.PatientId)
                .WillCascadeOnDelete(false);
        }
    }
}
