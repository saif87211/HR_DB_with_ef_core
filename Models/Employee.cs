using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HR_DB_with_ef_core.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        
        [MaxLength(50)]
        public string LastName { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        
        [Required]
        public DateOnly HireDate { get; set; }
        
        public int Salary { get; set; }
    }
}