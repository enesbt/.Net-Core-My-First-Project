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
    public class PetAgeManager : IPetAgeService
    {
        readonly IPetAgeDal _petAgeDal;

        public PetAgeManager(IPetAgeDal petAgeDal)
        {
            _petAgeDal = petAgeDal;
        }

        public List<PetAge> GetActiveAge(bool status)
        {
            return _petAgeDal.GetActiveAge(x => x.Status == status);
        }


        public PetAge GetById(int id)
        {
            return _petAgeDal.Get(x => x.PetAgeId == id);
        }

        public PetAge GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<PetAge> GetList()
        {
            return _petAgeDal.GetAll();
        }

        public List<PetAge> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetAge> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(PetAge model)
        {
            _petAgeDal.Add(model);
        }

        public void TRemove(PetAge model)
        {
            _petAgeDal.Delete(model);
        }

        public void TUpdate(PetAge model)
        {
            _petAgeDal.Update(model);
        }
    }
}
