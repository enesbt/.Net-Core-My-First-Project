using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.AddService
{
    public static class DalAddServices
    {

        public static void AddServicesDal(this IServiceCollection services)
        {
           
            services.AddDbContext<PetDbContext>(options=>options.UseSqlServer("###"));

            services.AddIdentity<AppUser, AppRole>(x =>
            {
                x.Password.RequiredLength = 5;
                x.Password.RequireNonAlphanumeric = false; 
                x.Password.RequireLowercase = false; 
                x.Password.RequireUppercase = false; 
                x.Password.RequireDigit = false; 
            }).AddEntityFrameworkStores<PetDbContext>();

            services.AddScoped<ICategoryDal, CategoryRepository>();
            services.AddScoped<IComplainDal, ComplainRepository>();
            services.AddScoped<IContactDal, ContactRepository>();
            services.AddScoped<IContactMeDal, ContactMeRepository>();
            services.AddScoped<IPetAgeDal, PetAgeRepository>();
            services.AddScoped<IPetBreedDal, PetBreedRepository>();
            services.AddScoped<IPetPostDal, PetPostRepository>();
            services.AddScoped<IPetsInformationDal, PetsInformationRepository>();
            services.AddScoped<IPetType, PetTypeRepository>();
            services.AddScoped<ICityDal, CityRepository>();

        }
    }
}
