using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Data;
using static System.Console;
using HR_DB_with_ef_core;

public class Create
{
    /// <summary>
    /// Inserting record in to Employee table.
    /// </summary>
    /// <param name="employee">employee Object</param>
    public static void InsertingEmployee(Employee employee)
    {
        using (var db = new HRContext())
        {
            db.Employees.Add(employee);
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
    public static void InsertingJobs(string jobTitle, string? minSalary, string? maxSalary)
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

    /// <summary>
    /// Insert record in to the Department table.
    /// </summary>
    /// <param name="departmentName">Department Name</param>
    /// <param name="locationId">Locaton Id</param>
    public static void InsertingDepartment(string departmentName, int locationId)
    {
        using (var db = new HRContext())
        {
            var department = new Department
            {
                DepartmentName = departmentName,
                LocationId = locationId
            };
            db.Departments.Add(department);
            db.SaveChanges();

            WriteLine("New Department is Added");
        }
    }

    /// <summary>
    /// Insert record in Location table.
    /// </summary>
    /// <param name="address">Addrees</param>
    /// <param name="postalCode">Postal code</param>
    /// <param name="city">City Name(Can be null)</param>
    public static void InsertingLocation(string address, string postalCode, string? city, int countryId)
    {
        using (var db = new HRContext())
        {
            var location = new Location
            {
                Address = address,
                PostalCode = postalCode,
                City = city,
                CountryId = countryId
            };

            db.Locations.Add(location);
            db.SaveChanges();

            WriteLine("New Location is added");
        }
    }

    /// <summary>
    /// Insert record in Country table.
    /// </summary>
    /// <param name="countryName">CountryName</param>
    /// <param name="regionId">Region Id</param>
    public static void InsertingCountry(string countryName, int regionId)
    {
        using (var db = new HRContext())
        {
            var country = new Country
            {
                CountryName = countryName,
                RegionId = regionId
            };

            db.Countries.Add(country);
            db.SaveChanges();

            WriteLine("New Country is added");
        }
    }

    /// <summary>
    /// Insert record in Region table.
    /// </summary>
    /// <param name="RegionName">Region Name</param>
    public static void InsertingRegion(string RegionName)
    {
        using (var db = new HRContext())
        {
            var region = new Region
            {
                RegionName = RegionName
            };

            db.Regions.Add(region);
            db.SaveChanges();

            WriteLine("New Region is added");
        }
    }

    /// <summary>
    /// Insert record in Depedent tabel.
    /// </summary>
    /// <param name="firstName">FirstName</param>
    /// <param name="lastName">LastName</param>
    /// <param name="relationship">relationship</param>
    /// <param name="employeeId"></param>
    public static void InsertingDepedent(string firstName, string lastName, string relationship, int employeeId)
    {
        using (var db = new HRContext())
        {
            var department = new Dependent
            {
                FirstName = firstName,
                LastName = lastName,
                RelationsShip = relationship,
                EmployeeId = employeeId
            };

            db.Dependents.Add(department);
            db.SaveChanges();

            WriteLine("New Depedent is added");
        }
    }
}