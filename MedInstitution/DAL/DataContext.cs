using MedInstitution.Models;
using Microsoft.EntityFrameworkCore;

namespace MedInstitution.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=MedInstitution;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}