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
    public class PetBreedManager : IPetBreedService
    {
        readonly IPetBreedDal _petBreedDal;

        public PetBreedManager(IPetBreedDal petBreedDal)
        {
            _petBreedDal = petBreedDal;
        }

        public List<PetBreed> GetActiveBreed(bool status)
        {
            return _petBreedDal.GetActiveBreed(x => x.Status == status);
        }

        public PetBreed GetById(int id)
        {
            return _petBreedDal.Get(x => x.PetBreedId == id);
        }

        public PetBreed GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<PetBreed> GetList()
        {
            return _petBreedDal.GetAll();
        }

        public List<PetBreed> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetBreed> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(PetBreed model)
        {
            _petBreedDal.Add(model);
        }

        public void TRemove(PetBreed model)
        {
            _petBreedDal.Delete(model);
        }

        public void TUpdate(PetBreed model)
        {
            _petBreedDal.Update(model);
        }
    }
}
