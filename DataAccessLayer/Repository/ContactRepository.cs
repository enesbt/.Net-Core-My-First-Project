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
    public class ContactRepository : GenericRepository<Contact>, IContactDal
    {
        public ContactRepository(PetDbContext dbContext) : base(dbContext)
        {
        }
    }
}
