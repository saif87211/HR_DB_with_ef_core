using System;
using HR_DB_with_ef_core.Data;
using HR_DB_with_ef_core.Models;
using HR_DB_with_ef_core.Repository.IRepository;

namespace HR_DB_with_ef_core.Repository
{
    public class JobRepositary : Repositary<Job>, IJob
    {
        private readonly HRContext _db;
        public JobRepositary(HRContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Job job)
        {
            _db.Jobs.Update(job);
        }
    }
}