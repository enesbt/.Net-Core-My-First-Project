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
    public class ContactMeRepository : GenericRepository<ContactMe>, IContactMeDal
    {
        readonly PetDbContext _petDbContext;
        public ContactMeRepository(PetDbContext dbContext) : base(dbContext)
        {
            _petDbContext = dbContext;
        }

        public List<ContactMe> ListWithMember(Expression<Func<ContactMe, bool>> filter)
        {
            return _petDbContext.ContactMes.Where(filter).ToList();
        }
    }
}
