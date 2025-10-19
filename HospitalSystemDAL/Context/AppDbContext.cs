using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSystemDAL.Entites;

namespace HospitalSystemDAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//i looked into how to seed initial data
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Clinic>().HasData(
                new Clinic { Id = 1, Name = "Downtown Clinic", openingHours = "9 AM - 5 PM" },
                new Clinic { Id = 2, Name = "Uptown Clinic", openingHours = "10 AM - 6 PM" }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Dr. Ahmed Hassan",
                    Gender = 'M',
                    Specialty = "Cardiology",
                    phoneNumber = "01098765432",
                    Address = "Nasr City, Cairo",
                    ClinicId = 1
                },
                new Doctor
                {
                    Id = 2,
                    Name = "Dr. Mona Ibrahim",
                    Gender = 'F',
                    Specialty = "Dermatology",
                    phoneNumber = "01055555555",
                    Address = "Heliopolis, Cairo",
                    ClinicId = 1
                }
            );


            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    PatientId = 1,
                    Name = "Sara Mohamed",
                    Gender = 'F',
                    DateOfBirth = new DateTime(1995, 5, 10),
                    phoneNumber = "01011122334",
                    Address = "Giza, Egypt"
                },
                new Patient
                {
                    PatientId = 2,
                    Name = "Omar Khaled",
                    Gender = 'M',
                    DateOfBirth = new DateTime(1990, 12, 1),
                    phoneNumber = "01099998888",
                    Address = "Maadi, Cairo"
                }
            );


            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Heba Ali",
                    Gender = 'F',
                    Position = "Receptionist",
                    phoneNumber = "01044444444",
                    Address = "Dokki, Giza",
                    Salary = 7500
                },
                new Employee
                {
                    Id = 2,
                    Name = "Khaled Hassan",
                    Gender = 'M',
                    Position = "Accountant",
                    phoneNumber = "01033333333",
                    Address = "Cairo",
                    Salary = 9000
                }
            );


            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    Id = 1,
                    ReservationDate = DateTime.Now.AddDays(2),
                    PatientId = 1,
                    DoctorId = 1,
                    ClinicId = 1,
                    EmployeeId = 1
                },
                new Reservation
                {
                    Id = 2,
                    ReservationDate = DateTime.Now.AddDays(3),
                    PatientId = 2,
                    DoctorId = 2,
                    ClinicId = 1,
                    EmployeeId = 2
                }
            );
        }
    }
}
