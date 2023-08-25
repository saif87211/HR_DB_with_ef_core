using System;
using HR_DB_with_ef_core.Models;

namespace HR_DB_with_ef_core.Repository
{
    public interface IEmployee : IRepositary<Employee>
    {
        void Update(Employee employee);
        void Save();
    }
}