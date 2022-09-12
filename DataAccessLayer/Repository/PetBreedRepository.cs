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
    public class PetBreedRepository : GenericRepository<PetBreed>, IPetBreedDal
    {
        private readonly PetDbContext _petDbContext;
        public PetBreedRepository(PetDbContext dbContext) : base(dbContext)
        {
            _petDbContext = dbContext;
        }

        public List<PetBreed> GetActiveBreed(Expression<Func<PetBreed, bool>> filter)
        {
            return _petDbContext.PetBreeds.Where(filter).ToList();
        }
    }
}
