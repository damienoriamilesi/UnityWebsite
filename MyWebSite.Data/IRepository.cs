using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyWebSite.Data
{
    public interface IRepository<T>
    {
        T Create(T objectInstance);
        void Update(T objectInstance);
        IList<T> GetAll();
        IList<T> GetAll(Expression<Func<T, bool>>  expression);
    }
}