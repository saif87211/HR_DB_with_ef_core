using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HR_DB_with_ef_core.Models
{
    public class Employee
    {
        [Key]
        [Column(Order = 1)]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(Order = 2)]
        public string FirstName { get; set; } = null!;

        [MaxLength(50)]
        [Column(Order = 3)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Column(Order = 4)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Column(Order = 5)]
        public string PhoneNumber { get; set; }

        [Required]
        [Column(Order = 6)]
        public DateOnly HireDate { get; set; }

        public int? Salary { get; set; }

        [Column(Order = 7)]
        public int JobId { get; set; }
        public Job Job { get; set; } = null!;

        public int DepartmentId { get; set; }
        // public Department Department { get; set; } = null!;
    }
}