using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessBase<T>:IRepository<T> where T:class
    {
         WebHazirlikEntities db;

         public BusinessBase() {

             db = new WebHazirlikEntities();
         }


        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry<T>(entity).CurrentValues.SetValues(entity);
            db.SaveChanges();
        }

        public void Remove(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> query)
        {
            return db.Set<T>().Where(query);
        }
    }
}
