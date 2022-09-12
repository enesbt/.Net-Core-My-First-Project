using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer.Concrete
{
    public class PetPostManager : IPetPostService
    {
        readonly IPetPostDal _petPostDal;

        public PetPostManager(IPetPostDal petPostDal)
        {
            _petPostDal = petPostDal;
        }

     
        public List<PetPost> GetListActivePost(bool name)
        {
            return _petPostDal.ListActivePost(x => x.Status == name);
        }

        public PetPost GetPostValues(int id)
        {
            return _petPostDal.GetPostAllValue(x => x.PetPostId == id);
        }

        public List<PetPost> GetListMebmerPost(string name)
        {
            return _petPostDal.ListWithMember(x => x.Name == name);
        }
        public List<PetPost> GetListAge(int id)
        {
            return _petPostDal.ListWithAge(x => x.PetAgeId == id);
           
        }

        public List<PetPost> GetListBreed(int id)
        {
            return _petPostDal.ListWithBreed(x => x.PetBreedId == id);
          
        }


        public List<PetPost> GetListCategory(int id)
        {
            return _petPostDal.ListWithCategory(x => x.CategoryId == id);
        
            
        }

        public List<PetPost> GetListType(int id)
        {
            return _petPostDal.ListWithType(x => x.PetTypeId == id);
          
          
        }
        public List<PetPost> GetListByValues()
        {
            return _petPostDal.ListWithValues();
        }

        public List<PetPost> GetListSlider()
        {
            return _petPostDal.ListActivePost(x=>x.Status==true).OrderByDescending(x => x.PostTime).Take(8).ToList();
        }
        public List<PetPost> GetListByCategory(int id)
        {
            return _petPostDal.GetAll(x => x.CategoryId == id);
           
        }
        public List<PetPost> GetListByAge(int id)
        {
            return _petPostDal.GetAll(x => x.PetAgeId == id);
            
        }

        public List<PetPost> GetListByPetBreed(int id)
        {
            return _petPostDal.GetAll(x => x.PetBreedId == id);
          
        }

        public List<PetPost> GetListByPetType(int id)
        {
            return _petPostDal.GetAll(x => x.PetTypeId == id);
           
            
        }
        public PetPost GetById(int id)
        {
            return _petPostDal.GetPost(x => x.PetPostId == id);
        }

        public PetPost GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<PetPost> GetList()
        {
            return _petPostDal.GetAll();
        }

        public List<PetPost> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PetPost> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(PetPost model)
        {
            _petPostDal.Add(model);
        }

        public void TRemove(PetPost model)
        {
            _petPostDal.Delete(model);
        }

        public void TUpdate(PetPost model)
        {
            _petPostDal.Update(model);
        }
    }
}
