using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MyWebSite.Data
{
    public class RepositoryBase<T> : IRepository<T> where T : class 
    {
        public T Create(T objectInstance)
        {
            throw new NotImplementedException();
        }

        public void Update(T objectInstance)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}