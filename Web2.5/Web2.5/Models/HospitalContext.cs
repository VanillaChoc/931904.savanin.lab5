#nullable disable
using Microsoft.EntityFrameworkCore;

namespace Web2._5.Models
{
    public class HospitalContext : DbContext
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public HospitalContext(DbContextOptions<HospitalContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
