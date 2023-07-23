using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_DB_with_ef_core.Models;

public class Dependent
{
    [Column(Order = 1)]
    public int DependentId { get; set; }

    [MaxLength(50)]
    [Column(Order = 2)]
    public string FirstName { get; set; } = null!;

    [MaxLength(50)]
    [Column(Order = 3)]
    public string LastName { get; set; } = null!;

    [MaxLength(25)]
    [Column(Order = 4)]
    public string Child { get; set; } = null!;

    public int EmployeeId { get; set; }
    // public Employee Employee { get; set; } = null!;
}
