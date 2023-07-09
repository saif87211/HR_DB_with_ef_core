using HR_DB_with_ef_core.Data;
using static System.Console;

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
                WriteLine(nameof(db.Employees));

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
                WriteLine("\n\n");
            }
        }

        /// <summary>
        /// Print All Job Record in the form of table.
        /// </summary>
        public static void GetAllJobs()
        {
            using (var db = new HRContext())
            {
                WriteLine(nameof(db.Jobs));

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
                WriteLine("\n\n");
            }
        }

        /// <summary>
        /// Print All Job Record in the form of table.
        /// </summary>
        public static void GetAllDepartments()
        {
            using (var db = new HRContext())
            {
                WriteLine(nameof(db.Departments));

                var table = new ConsoleTable(
                    "Department Id",
                    "Department Name",
                    "Lcoation Id"
                );

                var Departments = db.Departments.ToList();

                foreach (var item in Departments)
                {
                    table.AddRow(
                        item.DepartmentId,
                        item.DepartmentName,
                        item.LocationId
                    );
                }

                table.Write();
                WriteLine("\n\n");
            }
        }

        /// <summary>
        /// Print All Location Record in the form of table.
        /// </summary>
        public static void GetAllLocation()
        {
            using (var db = new HRContext())
            {
                WriteLine(nameof(db.Locations));

                var table = new ConsoleTable(
                    "Location Id",
                    "Address",
                    "Postal Code",
                    "City"
                );

                var Locations = db.Locations.ToList();

                foreach (var item in Locations)
                {
                    table.AddRow(
                        item.LocationId,
                        item.Address,
                        item.PostalCode,
                        item.City
                    );
                }

                table.Write();
                WriteLine("\n\n");
            }
        }


    }
}