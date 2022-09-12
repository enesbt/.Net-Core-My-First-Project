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
	public class CityManager : ICityService
	{
		readonly ICityDal _cityDal;

		public CityManager(ICityDal cityDal)
		{
			_cityDal = cityDal;
		}

		public City GetById(int id)
		{
			return _cityDal.Get(x => x.CityId == id);
		}

		public City GetById(string id)
		{
			throw new NotImplementedException();
		}

		public List<City> GetList()
		{
			return _cityDal.GetAll();	
		}

		public List<City> GetListById(int id)
		{
			throw new NotImplementedException();
		}

		public List<City> GetListByName(string name)
		{
			throw new NotImplementedException();
		}

		public void TAdd(City model)
		{
			_cityDal.Add(model);
		}

		public void TRemove(City model)
		{
			_cityDal.Delete(model);
		}

		public void TUpdate(City model)
		{
			_cityDal.Update(model);
		}
	}
}
