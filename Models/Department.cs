using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HR_DB_with_ef_core.Models;

public class Department
{
    [Key]
    public int DepartmentId { get; set; }
    [MaxLength(50)]
    public string DepartmentName { get; set; } = null!;

    public int LocationId { get; set; }
    public required Location Location { get; set; }

    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}