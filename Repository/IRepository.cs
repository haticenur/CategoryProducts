using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public interface IRepository<T> 
    {
       void Add(T entity);

       void Update(T entiy);

       void Remove(T entity);

       List<T> GetAll();

       IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T,bool>> query);


    }
}
