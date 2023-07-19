using HR_DB_with_ef_core;
using HR_DB_with_ef_core.Data;
using static System.Console;

namespace HR_DB_with_ef_core.CRUD;


public enum EmployeeColumn
{
    FirstName, LastName, EmailAddress, PhoneNumber, HireDate, Salary, JobId
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
                WriteLine("Id is not found in database");
            }
        }
    }
}