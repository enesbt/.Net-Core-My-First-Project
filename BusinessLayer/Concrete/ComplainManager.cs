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
    public class ComplainManager : IComplainService
    {
        readonly IComplainDal _complainDal;

        public ComplainManager(IComplainDal complainDal)
        {
            _complainDal = complainDal;
        }

        public Complain GetById(int id)
        {
            return _complainDal.Get(x => x.ComplainId == id);
        }

        public Complain GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Complain> GetList()
        {
            return _complainDal.GetAll();
        }

        public List<Complain> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Complain> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Complain model)
        {
            _complainDal.Add(model);
        }

        public void TRemove(Complain model)
        {
            _complainDal.Delete(model);
        }

        public void TUpdate(Complain model)
        {
            _complainDal.Update(model);
        }
    }
}
