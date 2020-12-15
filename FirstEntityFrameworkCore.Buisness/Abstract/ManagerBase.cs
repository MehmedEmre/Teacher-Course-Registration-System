using FirstEntityFrameworkCore.DAC.Abstract;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.DAC.EntityFrameworkCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Buisness.Abstract
{
    public class ManagerBase<T> : IDataAccess<T> where T:class
    {

        Repository<T> repo = new Repository<T>();

        public T Find(Expression<Func<T, bool>> where)
        {
            return repo.Find(where);
        }

        public int Insert(T obj)
        {
            return repo.Insert(obj);
        }

        public List<T> List()
        {
            return repo.List();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return repo.List(where);
        }

        public List<Lessons> ListWithSub()
        {
            return repo.ListWithSub();
        }


        public IQueryable ListQueryable()
        {
            return repo.ListQueryable();
        }

        public int Save()
        {
            return repo.Save();
        }

        public int Remove(T obj)
        {
            return repo.Remove(obj);
        }
        public int Update(T obj)
        {
            return repo.Update(obj);
        }

   
    }
}
