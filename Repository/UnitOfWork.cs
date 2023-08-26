using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_DB_with_ef_core.Data;

namespace HR_DB_with_ef_core.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HRContext _db;
        public IEmployee Employee{get; private set;}

        public UnitOfWork(HRContext db)
        {
            _db = db;
            Employee = new EmployeeRepositary(db);
        }

        public void Complete()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}