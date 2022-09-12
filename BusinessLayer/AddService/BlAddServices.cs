using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AddService
{
    public static class BlAddServices
    {
        public static void AddServicesBl(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IComplainService, ComplainManager>();
            services.AddScoped<IContactMeService, ContactMeManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IPetAgeService, PetAgeManager>();
            services.AddScoped<IPetBreedService, PetBreedManager>();
            services.AddScoped<IPetPostService, PetPostManager>();
            services.AddScoped<IPetsInformationService, PetsInformationManager>();
            services.AddScoped<IPetTypeService, PetTypeManager>();
            services.AddScoped<ICityService, CityManager>();
        }
    }
}
