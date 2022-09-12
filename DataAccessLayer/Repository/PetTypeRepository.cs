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
    public class PetTypeRepository : GenericRepository<PetType>,IPetType
    {
        private readonly PetDbContext _petDbContext;
        public PetTypeRepository(PetDbContext dbContext) : base(dbContext)
        {
            _petDbContext = dbContext;
        }

        public List<PetType> GetActiveType(Expression<Func<PetType, bool>> filter)
        {
            return _petDbContext.PetTypes.Where(filter).ToList();
        }
    }
}
