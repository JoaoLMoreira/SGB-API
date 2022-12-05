using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SgbProject.Repositories
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Remove(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void SaveChanges();


    }
}
