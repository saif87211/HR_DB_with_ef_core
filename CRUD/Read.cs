using HR_DB_with_ef_core.Data;
using ConsoleTables;                //Nuget Package ConsoleTables

namespace HR_DB_with_ef_core.CRUD
{
    public class Read
    {
        /// <summary>
        /// Print All employee records in the form of table.
        /// </summary>
        public static void GetAllEmployees()
        {
            using (var db = new HRContext())
            {
                Console.WriteLine(nameof(db.Employees));

                var table = new ConsoleTable(
                    "Employee Id", "Job Id",
                    "First Name", "Last Name",
                    "Email", "PhoneNumber",
                    "HireDate", "Salary");

                var Employees = db.Employees.ToList();

                foreach (var employee in Employees)
                {
                    table.AddRow(
                        employee.EmployeeId, employee.JobId,
                        employee.FirstName, employee.LastName,
                        employee.Email, employee.PhoneNumber,
                        employee.HireDate, employee.Salary);
                }

                table.Write(); //print table
            }
        }

        /// <summary>
        /// Print All Job Record in the form of table.
        /// </summary>
        public static void GetAllJobs()
        {
            using (var db = new HRContext())
            {
                Console.WriteLine(nameof(db.Employees));

                var table = new ConsoleTable(
                    "Job Id", "Job Title",
                    "Min Salry", "Min Salary");

                var Jobs = db.Jobs.ToList();

                foreach (var job in Jobs)
                {
                    table.AddRow(
                        job.JobId, job.JobTitle,
                        job.MinSalary, job.MaxSalary);
                }

                table.Write(); //print table
            }
        }
    }
}