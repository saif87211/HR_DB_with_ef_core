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

    public IEnumerable<Employee> EmployeeListJoinYear(int year)
    {
        return _db.Employees.Where(e=>e.HireDate.Year == year).ToList();
    }

    public IEnumerable<Employee> Top10HighestSalryEmployees()
    {
        IEnumerable<Employee> employees = _db.Employees.OrderByDescending(e=>e.Salary).Take(10).ToList();
        return employees;
    }
    
    public void Update(Employee employee)
    {
        _db.Employees.Update(employee);
    }
}