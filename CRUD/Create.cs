using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Data;
using static System.Console;

public class Create
{
    /// <summary>
    /// Inserting record in to Employee table.
    /// </summary>
    /// <param name="firstName">Firstname of employee</param>
    /// <param name="lastName">Last name of an employee</param>
    /// <param name="email">Email address</param>
    /// <param name="phoneNumber">Mobile no.</param>
    /// <param name="hireDate">Date of joining(yyyy-mm-dd)</param>
    /// <param name="salary">Can be null</param>
    /// <param name="jobId"></param>
    public static void InsertingEmployee(string firstName, string lastName, string email, string phoneNumber, string hireDate, int salary, int jobId)
    {
        using (var db = new HRContext())
        {
            var newEmployee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                HireDate = DateOnly.Parse(hireDate),
                Salary = salary,
                JobId = jobId,
            };

            db.Employees.Add(newEmployee);
            db.SaveChanges();

            WriteLine($"New Employee is added");
        }
    }

    /// <summary>
    /// Insert record in to the Jobs Table
    /// </summary>
    /// <param name="jobTitle">Job postion in Oragnization(required)</param>
    /// <param name="minSalary">minimum Salary of that position</param>
    /// <param name="maxSalary">Maximun salary of that postion</param>
    public static void InsertingJobs(string jobTitle, int? minSalary, int? maxSalary)
    {
        using (var db = new HRContext())
        {
            var job = new Job
            {
                JobTitle = jobTitle,
                MinSalary = minSalary,
                MaxSalary = maxSalary
            };

            db.Jobs.Add(job);
            db.SaveChanges();

            WriteLine("New job is added");
        }
    }
}