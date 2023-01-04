using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JeeyouHospital.Data;

public partial class HospitalManagementDbContext : DbContext
{
    public HospitalManagementDbContext(DbContextOptions<HospitalManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Specialization> Specializations { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appointm__3214EC07FFE42E18");

            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Patient).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__Appointme__Patie__4AB81AF0");

            entity.HasOne(d => d.Specialization).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.SpecializationId)
                .HasConstraintName("FK__Appointme__Speci__4BAC3F29");

            entity.HasOne(d => d.Staff).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK__Appointme__Staff__49C3F6B7");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patients__3214EC074C01E3DF");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PatientId).HasMaxLength(50);
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Results__3214EC0727560232");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Results).HasMaxLength(300);

            entity.HasOne(d => d.Appointment).WithMany(p => p.Results)
                .HasForeignKey(d => d.AppointmentId)
                .HasConstraintName("FK__Results__Appoint__4F7CD00D");

            entity.HasOne(d => d.Patient).WithMany(p => p.Results)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__Results__Patient__4E88ABD4");
        });

        modelBuilder.Entity<Specialization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Speciali__3214EC07643D0E09");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Staffs__3214EC07BC952471");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.StaffId).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
