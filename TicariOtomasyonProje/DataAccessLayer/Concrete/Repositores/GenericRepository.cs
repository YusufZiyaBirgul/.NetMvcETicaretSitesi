using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositores
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _obj;

        public GenericRepository()
        {
            _obj = c.Set<T>();
        }
        public void Delete(T p)
        {
            var deleteEntity = c.Entry(p);
            deleteEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _obj.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var insertEntity = c.Entry(p);
            insertEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _obj.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _obj.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updateEntity = c.Entry(p);
            updateEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
