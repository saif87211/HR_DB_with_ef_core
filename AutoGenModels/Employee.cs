using System;
using System.Collections.Generic;

namespace HR_DB_with_ef_core.AutoGenModels;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string HireDate { get; set; } = null!;

    public long JobId { get; set; }

    public string LastName { get; set; } = null!;

    public long PhoneNumber { get; set; }

    public long Salary { get; set; }

    public virtual Job Job { get; set; } = null!;
}
