using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
	public class CityRepository : GenericRepository<City>, ICityDal
	{
		public CityRepository(PetDbContext dbContext) : base(dbContext)
		{
		}
	}
}
