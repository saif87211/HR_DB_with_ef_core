using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HR_DB_with_ef_core.Models;

namespace HR_DB_with_ef_core.Data
{
    public class HRContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "HR.db");

            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}