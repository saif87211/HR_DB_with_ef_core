using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HR_DB_with_ef_core;
using HR_DB_with_ef_core.Data;
using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Repository;

public class EmployeeRepositary : Repositary<Employee> ,IEmployee
{
    private readonly HRContext _db;
    public EmployeeRepositary(HRContext db) : base(db)
    {
        _db = db;
    }

    // public IQueryable<Employee> Top10EmployeeWithHighestSalary()
    // {
    //     IQueryable<Employee> employeeList = _db.Employees.Where(e => e.Salary > 0).First;
    //     return _db.Employees.Where()
    // }
    public void Update(Employee employee)
    {
        _db.Employees.Update(employee);
    }
}