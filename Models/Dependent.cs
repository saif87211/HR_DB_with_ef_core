using System.ComponentModel.DataAnnotations;

namespace HR_DB_with_ef_core.Models;

public class Dependent
{
    public int DependentId { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; } = null!;

    [MaxLength(50)]
    public string LastName { get; set; } = null!;

    [MaxLength(25)]
    public string Child { get; set; } = null!;

    public int EmployeeId { get; set; }
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
