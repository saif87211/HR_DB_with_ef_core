using HR_DB_with_ef_core.CRUD;
using HR_DB_with_ef_core.Data;
using HR_DB_with_ef_core.Repository;
using static System.Console;

using (var unitOfWork = new UnitOfWork(new HRContext()))
{
    var employee = unitOfWork.Employee.GetFirstOrDefault(e=>e.EmployeeId == 5);

    WriteLine($"Name of an Employee: {employee.FirstName} {employee.LastName} ");
}