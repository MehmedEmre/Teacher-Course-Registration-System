using FirstEntityFrameworkCore.DAC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.DAC.Abstract
{
    public interface IDataAccess<T>
    {
         List<T> List();
         List<T> List(Expression<Func<T, bool>> where);
         List<Lessons> ListWithSub();

         IQueryable ListQueryable();
         T Find(Expression<Func<T, bool>> where);
         int Insert(T obj);
         int Update(T obj);
         int Save();
        int Remove(T obj);

    }
}
