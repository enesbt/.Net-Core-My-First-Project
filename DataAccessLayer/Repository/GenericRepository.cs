using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        PetDbContext dbContext;

        public GenericRepository(PetDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async void Add(T entity)
        {
            await dbContext.AddAsync(entity);
            dbContext.SaveChanges();
        }

        public  void Delete(T entity)
        {
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

        public  T Get(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().Where(expression).ToList();
        }

        public void Update(T entity)
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
