using HR_DB_with_ef_core.Data;
using HR_DB_with_ef_core.Models;
using static System.Console;

namespace HR_DB_with_ef_core.CRUD;

public class Delete
{
    /// <summary>
    /// Delete single record form the table
    /// </summary>
    /// <param name="id">Employee Id</param>
    public static void DeleteEmployee(int id)
    {
        using (var db = new HRContext())
        {
            var employee = db.Employees.First(e => e.EmployeeId == id);

            if (employee != null)
            {
                db.Employees.Remove(employee);
                db.SaveChanges();
                WriteLine("Data is deleted.\n");
            }
            else
            {
                WriteLine("Id is not found in employee Table\n");
            }
        }
    }

    /// <summary>
    /// Delete single record form the table
    /// </summary>
    /// <param name="id">JobId</param>
    public static void DeleteJob(int id)
    {
        using (var db = new HRContext())
        {
            var job = db.Jobs.Single(j => j.JobId == id);

            if (job != null)
            {
                db.Jobs.Remove(job);
                db.SaveChanges();
                WriteLine("Data is deleted.\n");
            }
            else
            {
                WriteLine("Id is not found in job Table\n");
            }
        }
    }

    /// <summary>
    /// Delete single record form the table
    /// </summary>
    /// <param name="id">Department id</param>
    public static void DeleteDepartment(int id)
    {
        using (var db = new HRContext())
        {
            var department = db.Departments.Single(d => d.DepartmentId == id);

            if (department != null)
            {
                db.Departments.Remove(department);
                db.SaveChanges();
                WriteLine("Data is deleted.\n");
            }
            else
            {
                WriteLine("Id is not found in Department Table\n");
            }
        }
    }

    /// <summary>
    /// Delete single record form the table
    /// </summary>
    /// <param name="id">Location Id</param>
    public static void DeleteLocation(int id)
    {
        using (var db = new HRContext())
        {
            var location = db.Locations.Single(l => l.LocationId == id);

            if (location != null)
            {
                db.Locations.Remove(location);
                db.SaveChanges();
                WriteLine("Data is deleted.\n");
            }
            else
            {
                WriteLine("Id is not found in Location Table\n");
            }
        }
    }

    /// <summary>
    /// Delete single record form the table
    /// </summary>
    /// <param name="id">Country Id</param>
    public static void DeleteCountry(int id)
    {
        using (var db = new HRContext())
        {
            var country = db.Countries.Single(c => c.CountryId == id);

            if (country != null)
            {
                db.Countries.Remove(country);
                db.SaveChanges();
                WriteLine("Data is deleted.\n");
            }
            else
            {
                WriteLine("Id is not found in Country Table\n");
            }
        }
    }
    /// <summary>
    /// Delete single record form the table
    /// </summary>
    /// <param name="id">Region Id</param>
    public static void DeleteRegion(int id)
    {
        using (var db = new HRContext())
        {
            var region = db.Regions.Single(r => r.RegionId == id);

            if (region != null)
            {
                db.Regions.Remove(region);
                db.SaveChanges();
                WriteLine("Data is deleted.\n");
            }
            else
            {
                WriteLine("Id is not found in Region Table\n");
            }
        }
    }
    /// <summary>
    /// Delete single record form the table
    /// </summary>
    /// <param name="id">Depedent Id</param>
    public static void DeleteDepedent(int id)
    {
        using (var db = new HRContext())
        {
            var dependent = db.Dependents.Single(d => d.DependentId == id);

            if (dependent != null)
            {
                db.Dependents.Remove(dependent);
                db.SaveChanges();
                WriteLine("Data is deleted.\n");
            }
            else
            {
                WriteLine("Id is not found in Country Table\n");
            }
        }
    }
}