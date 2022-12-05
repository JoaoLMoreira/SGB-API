using SgbProject.Data;
using System.Linq.Expressions;

namespace SgbProject.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected Context context;

        public GenericRepository(Context context)
        {
            this.context = context;
        }

        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public virtual T GetById(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity).Entity;
        }

        public virtual T Remove(T entity)
        {
            return context.Remove(entity).Entity;
        }
    }
}
