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
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetActiveCategory(bool status)
        {
            return _categoryDal.GetActiveCategory(x=>x.Status==status);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public Category GetById(string id)
        {
            return _categoryDal.Get(x => x.CategoryName == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Category model)
        {
            _categoryDal.Add(model);
        }

        public void TRemove(Category model)
        {
            _categoryDal.Delete(model);
        }

        public void TUpdate(Category model)
        {
            _categoryDal.Update(model);
        }
    }
}
