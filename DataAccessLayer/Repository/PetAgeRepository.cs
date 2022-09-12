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
    public class PetAgeRepository : GenericRepository<PetAge>, IPetAgeDal
    {
        private readonly PetDbContext _petDbContext;
        public PetAgeRepository(PetDbContext dbContext) : base(dbContext)
        {
            _petDbContext = dbContext;
        }

        public List<PetAge> GetActiveAge(Expression<Func<PetAge, bool>> filter)
        {
            return _petDbContext.PetAges.Where(filter).ToList();
        }
    }
}
