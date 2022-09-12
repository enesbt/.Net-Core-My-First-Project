﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>>expression);
        T Get(Expression<Func<T,bool>>expression);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
