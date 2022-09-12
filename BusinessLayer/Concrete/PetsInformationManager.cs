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
    public class PetsInformationManager : IPetsInformationService
    {
        readonly IPetsInformationDal _petsInformationDal;

        public PetsInformationManager(IPetsInformationDal petsInformationDal)
        {
            _petsInformationDal = petsInformationDal;
        }

        public PetsInformation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public PetsInformation GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<PetsInformation> GetList()
        {
            return _petsInformationDal.GetAll();
        }

        public List<PetsInformation> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetsInformation> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(PetsInformation model)
        {
            _petsInformationDal.Add(model);
        }

        public void TRemove(PetsInformation model)
        {
            _petsInformationDal.Delete(model);
        }

        public void TUpdate(PetsInformation model)
        {
            _petsInformationDal.Update(model);
        }
    }
}
