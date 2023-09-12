using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Data;
using HR_DB_with_ef_core.Repository;
using static System.Console;
using HR_DB_with_ef_core;

using (var db = new UnitOfWork(new HRContext()))
{
    var employeeis = db.Employee.GetAll();

    foreach (var item in employeeis)
    {
        WriteLine($"Name: {item.FirstName} {item.LastName}, joinning Date: {item.HireDate}");
    }
}
