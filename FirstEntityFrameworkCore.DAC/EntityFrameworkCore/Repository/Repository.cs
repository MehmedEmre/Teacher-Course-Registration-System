using FirstEntityFrameworkCore.DAC.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FirstEntityFrameworkCore.DAC.EntityFrameworkCore.Repository
{
    public class Repository<T>: RepositoryBase ,IDataAccess<T> where T:class
    {

        private DbSet<T> objectSet;

        public Repository()
        {

            objectSet = db.Set<T>();

        }

        public List<T> List()
        {
            return objectSet.ToList();
        }

        public List<T> List(Expression<Func<T,bool>> where)
        {
            return objectSet.Where(where).ToList();
        }

        public IQueryable ListQueryable()
        {
            return objectSet.AsQueryable();
        }


        public T Find(Expression<Func<T,bool>> where)
        {
            return objectSet.FirstOrDefault(where);
        }

        public int Insert(T obj)
        {
            objectSet.Add(obj);

            return Save();
        }

        public int Update(T obj)
        {
            return Save();
        }
        public int Remove(T obj)
        {
            objectSet.Remove(obj);
            return Save();
        }

        public int Save()
        {

            return db.SaveChanges();
        }

    }
}
