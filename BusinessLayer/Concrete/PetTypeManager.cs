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
    public class PetTypeManager : IPetTypeService
    {
        readonly IPetType _petType;

        

        public PetTypeManager(IPetType petType)
        {
            _petType = petType;
        }

        public List<PetType> GetActiveType(bool status)
        {
            return _petType.GetActiveType(x => x.Status == status);
        }

        public PetType GetById(int id)
        {
            return _petType.Get(x => x.PetTypeId == id);
        }

        public PetType GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<PetType> GetList()
        {
            return _petType.GetAll();
        }

        public List<PetType> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetType> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(PetType model)
        {
            _petType.Add(model);
        }

        public void TRemove(PetType model)
        {
            _petType.Delete(model);
        }

        public void TUpdate(PetType model)
        {
            _petType.Update(model);
        }
    }
}
