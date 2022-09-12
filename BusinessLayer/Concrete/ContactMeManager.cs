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
    public class ContactMeManager : IContactMeService
    {
        readonly IContactMeDal _contactMeDal;
        public ContactMeManager(IContactMeDal contactMeDal)
        {
            _contactMeDal = contactMeDal;
        }

        public List<ContactMe> GetMessageMember(string name)
        {
           return _contactMeDal.ListWithMember(x=>x.PetPost.Name==name);
        }
        public ContactMe GetById(int id)
        {
            return _contactMeDal.Get(x => x.ContactMeId == id);
        }

        public ContactMe GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<ContactMe> GetList()
        {
            return _contactMeDal.GetAll();
        }

        public List<ContactMe> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactMe> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(ContactMe model)
        {
            _contactMeDal.Add(model);
        }

        public void TRemove(ContactMe model)
        {
            _contactMeDal.Delete(model);
        }

        public void TUpdate(ContactMe model)
        {
            _contactMeDal.Update(model);
        }
    }
}
