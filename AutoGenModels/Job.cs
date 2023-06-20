using System;
using System.Collections.Generic;

namespace HR_DB_with_ef_core.AutoGenModels;

public partial class Job
{
    public long JobId { get; set; }

    public string JobTitle { get; set; } = null!;

    public long MinSalary { get; set; }

    public long MaxSalary { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
