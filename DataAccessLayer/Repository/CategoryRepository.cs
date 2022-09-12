using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        private readonly PetDbContext _dbContext;
        public CategoryRepository(PetDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Category> GetActiveCategory(Expression<Func<Category, bool>> filter)
        {
            return _dbContext.Categories.Where(filter).ToList();
        }
    }
}
