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
                    "HireDate", "Salary",
                    "DepartmentID", "ManagerId");

                var Employees = db.Employees.ToList();

                foreach (var employee in Employees)
                {
                    table.AddRow(
                        employee.EmployeeId, employee.JobId,
                        employee.FirstName, employee.LastName,
                        employee.Email, employee.PhoneNumber,
                        employee.HireDate, employee.Salary,
                        employee.DepartmentId, employee.ManagerId);
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

        /// <summary>
        /// Print All Country Record in the form of table.
        /// </summary>
        public static void GetAllCountry()
        {
            using (var db = new HRContext())
            {
                WriteLine(nameof(db.Countries));

                var table = new ConsoleTable(
                    "Country Id",
                    "Country Name",
                    "RegionId"
                );

                var Countries = db.Countries.ToList();

                foreach (var item in Countries)
                {
                    table.AddRow(
                        item.CountryId,
                        item.CountryName,
                        item.RegionId
                    );
                }

                table.Write();
                WriteLine("\n\n");
            }
        }
        /// <summary>
        /// Print All Region Record in the form of table.
        /// </summary>
        public static void GetAllRegion()
        {
            using (var db = new HRContext())
            {
                WriteLine(nameof(db.Regions));

                var table = new ConsoleTable(
                    "Region Id",
                    "Region Name"
                );

                var Regions = db.Regions.ToList();

                foreach (var item in Regions)
                {
                    table.AddRow(
                        item.RegionId,
                        item.RegionName
                        );
                }

                table.Write();
                WriteLine("\n\n");
            }
        }
        /// <summary>
        /// Print All Dependent Record in the form of table.
        /// </summary>
        public static void GetAllDepedent()
        {
            using (var db = new HRContext())
            {
                WriteLine(nameof(db.Dependents));

                var table = new ConsoleTable(
                    "Depedent Id",
                    "FirstName",
                    "LastName",
                    "Relationship",
                    "EmployeeId"
                );

                var Dependents = db.Dependents.ToList();

                foreach (var item in Dependents)
                {
                    table.AddRow(
                        item.DependentId,
                        item.FirstName,
                        item.LastName,
                        item.Child,
                        item.EmployeeId
                        );
                }

                table.Write();
                WriteLine("\n\n");
            }
        }
    }
}