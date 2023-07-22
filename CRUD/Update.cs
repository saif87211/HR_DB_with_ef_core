using HR_DB_with_ef_core;
using HR_DB_with_ef_core.Data;
using static System.Console;

namespace HR_DB_with_ef_core.CRUD;


public enum EmployeeColumn
{
    FirstName, LastName, EmailAddress, PhoneNumber, HireDate, Salary, JobId
}
public enum JobColumn
{
    JobTitle, MinSalary, MaxSalary
}
public enum DepartmentColumn
{
    DepartmentName, LocationId
}
public enum LocationColumn
{
    Address, PostalCode, City
}

public class Update
{
    /// <summary>
    /// Update recored of employee table id you provided 
    /// </summary>
    /// <param name="employeeId">Employee id from the table</param>
    /// <param name="column">Enum value use it Like 'EmployeeColumn.FirsName'</param>
    /// <param name="value">Value for update. For Hire Date Write in (yyyy-mm-dd) format</param>
    public static void UpdateEmployee(int employeeId, EmployeeColumn column, string value)
    {
        using (var db = new HRContext())
        {
            var Employee = db.Employees.First(p => p.EmployeeId == employeeId);
            if (Employee != null)
            {
                switch (column)
                {
                    case EmployeeColumn.FirstName:
                        Employee.FirstName = value;
                        break;
                    case EmployeeColumn.LastName:
                        Employee.LastName = value;
                        break;
                    case EmployeeColumn.EmailAddress:
                        Employee.Email = value;
                        break;
                    case EmployeeColumn.PhoneNumber:
                        Employee.PhoneNumber = value;
                        break;
                    case EmployeeColumn.HireDate:
                        Employee.HireDate = DateOnly.Parse(value);
                        break;
                    case EmployeeColumn.Salary:
                        Employee.Salary = Int32.Parse(value);
                        break;
                    case EmployeeColumn.JobId:
                        Employee.JobId = Int32.Parse(value);
                        break;
                }
                db.SaveChanges();
                WriteLine("Data is Updated in Employee Table\n");
            }
            else
            {
                WriteLine("Id is not found in Table\n");
            }
        }
    }

    /// <summary>
    /// Update recored of Job table id you provided 
    /// </summary>
    /// <param name="jobId">Id of Record </param>
    /// <param name="column">Enum value usage: 'JobColumn.JobTitle'</param>
    /// <param name="value">value of column</param>
    public static void UpdateJobs(int jobId, JobColumn column, string value)
    {
        using (var db = new HRContext())
        {
            var job = db.Jobs.First(j => j.JobId == jobId);

            if (job != null)
            {
                switch (column)
                {
                    case JobColumn.JobTitle:
                        job.JobTitle = value;
                        break;

                    case JobColumn.MaxSalary:
                        job.MaxSalary = value;
                        break;

                    case JobColumn.MinSalary:
                        job.MinSalary = value;
                        break;
                }
                db.SaveChanges();
                WriteLine("Data is updated in Job tabel\n");
            }
            else
            {
                WriteLine("Job id is not found in Table\n");
            }
        }
    }

    public static void UpdateDepartment(int id, DepartmentColumn column, string value)
    {
        using (var db = new HRContext())
        {
            var Department = db.Departments.Single(d => d.DepartmentId == id);

            if (Department != null)
            {
                switch (column)
                {
                    case DepartmentColumn.DepartmentName:
                        Department.DepartmentName = value;
                        break;
                    case DepartmentColumn.LocationId:
                        Department.LocationId = Int32.Parse(value);
                        break;
                }
                db.SaveChanges();
                WriteLine("Data is updated in Department Table\n");
            }
            else
            {
                WriteLine("Department Id is not found in Table\n");
            }
        }
    }

    public static void UpdateLocation(int id, LocationColumn column, string value)
    {
        using (var db = new HRContext())
        {
            var Location = db.Locations.First(l => l.LocationId == id);

            if (Location != null)
            {
                switch (column)
                {
                    case LocationColumn.Address:
                        Location.Address = value;
                        break;
                    case LocationColumn.PostalCode:
                        Location.PostalCode = value;
                        break;
                    case LocationColumn.City:
                        Location.City = value;
                        break;
                }
                db.SaveChanges();
                WriteLine("Data is updated in Location Table\n");
            }
            else
            {
                WriteLine("Location id is not found in tabel\n");
            }
        }
    }

}