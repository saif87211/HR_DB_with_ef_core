using System;

namespace HR_DB_with_ef_core.Repository;

public interface IUnitOfWork
{
    IEmployee Employee { get;}
    void Complete();
}