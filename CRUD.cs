using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Data;
using static System.Console;

public class CRUD
{
    /// <summary>
    /// Inserting record to databse
    /// </summary>
    /// <param name="firstName">Firstname of employee</param>
    /// <param name="lastName">Last name of an employee</param>
    /// <param name="email">Email address</param>
    /// <param name="phoneNumber">Mobile no.</param>
    /// <param name="hireDate">Date of joining</param>
    /// <param name="salary">Can be null</param>
    /// <param name="jobId"></param>
    public static void InsertingEmployee(string firstName, string lastName, string email, int phoneNumber, DateOnly hireDate, int salary, int jobId)
    {
        using (var db = new HRContext())
        {
            var newEmployee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                HireDate = hireDate,
                Salary = salary,
                JobId = jobId,
            };

            db.Employees.Add(newEmployee);
            WriteLine($"New Employee is added");
        }
    }

    public static void InsertingJobs(string jobTitle, int? maxSalary, int? minSalary)
    {
        using (var db = new HRContext())
        {
            var job = new Job
            {
                JobTitle = jobTitle,
                MaxSalary = maxSalary,
                MinSalary = minSalary
            };

            db.Jobs.Add(job);
            WriteLine("New employee is added");
        }
    }
}