using System.ComponentModel.DataAnnotations;

namespace HR_DB_with_ef_core.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        public string JobTitle { get; set; } = null!;

        [MaxLength(6)]
        public string? MinSalary { get; set; }

        [MaxLength(6)]
        public string? MaxSalary { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}