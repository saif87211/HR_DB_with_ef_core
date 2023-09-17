using System;
using HR_DB_with_ef_core.Models;
namespace HR_DB_with_ef_core.Repository.IRepository
{
    public interface IDepartment: IRepositary<Department>
    {
        void Update(Department department);
    }
}