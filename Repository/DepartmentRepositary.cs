using System;
using HR_DB_with_ef_core.Data;
using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Repository.IRepository;

namespace HR_DB_with_ef_core.Repository
{
    public class DepartmentRepositary : Repositary<Department>,IDepartment
    {
        private readonly HRContext _db;
        public DepartmentRepositary(HRContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Department department)
        {
            _db.Departments.Update(department);
        }
    }
}