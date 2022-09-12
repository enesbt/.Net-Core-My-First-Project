using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ComplainRepository : GenericRepository<Complain>, IComplainDal
    {
        public ComplainRepository(PetDbContext dbContext) : base(dbContext)
        {
        }
    }
}
