using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.ContactId == id);
        }

        public Contact GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetAll();
        }

        public List<Contact> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact model)
        {
            _contactDal.Add(model);
        }

        public void TRemove(Contact model)
        {
            _contactDal.Delete(model);
        }

        public void TUpdate(Contact model)
        {
            _contactDal.Update(model);
        }
    }
}
