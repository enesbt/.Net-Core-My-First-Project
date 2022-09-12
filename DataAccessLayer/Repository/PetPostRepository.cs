using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class PetPostRepository : GenericRepository<PetPost>, IPetPostDal
    {
        private readonly PetDbContext _dbContext;

        public PetPostRepository(PetDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext; 
        }

       
        public List<PetPost> ListActivePost(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Where(filter).Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                .Include(x => x.PetType).Include(x => x.PetAge).ToList();
        }

        public PetPost GetPostAllValue(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                 .Include(x => x.PetType).Include(x => x.PetAge).FirstOrDefault(filter);
        }
        public List<PetPost> ListWithMember(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Where(filter).Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                 .Include(x => x.PetType).Include(x => x.PetAge).ToList();
        }

        public PetPost GetPost(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Include(x => x.ContactMes).Include(x => x.Complains).FirstOrDefault(filter);
        }

        public List<PetPost> ListWithAge(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Where(x => x.Status == true).Where(filter).Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                 .Include(x => x.PetType).ToList();
        }

        public List<PetPost> ListWithBreed(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Where(x => x.Status == true).Where(filter).Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                .Include(x => x.PetType).ToList();
        }

        public List<PetPost> ListWithCategory(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Where(x => x.Status == true).Where(filter).Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                 .Include(x => x.PetType).ToList();
        }

        public List<PetPost> ListWithType(Expression<Func<PetPost, bool>> filter)
        {
            return _dbContext.PetPosts.Where(x => x.Status == true).Where(filter).Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                .Include(x => x.PetType).ToList();
        }
        public List<PetPost> ListWithValues()
        {
            return _dbContext.PetPosts.Include(x => x.Category).Include(x => x.City).Include(x => x.PetBreed)
                .Include(x => x.PetType).Include(x => x.PetAge).ToList();
        }
    }
}
