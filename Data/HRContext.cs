using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HR_DB_with_ef_core.Models;

namespace HR_DB_with_ef_core.Data
{
    public class HRContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public HRContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("HRConnection");

            optionsBuilder.UseSqlite(connectionString);
        }
    }
}