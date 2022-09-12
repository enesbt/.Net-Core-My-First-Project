using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class PetDbContext:IdentityDbContext<AppUser,AppRole,string>
    {
        public PetDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Complain> Complains { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMe> ContactMes { get; set; }
        public DbSet<PetAge> PetAges { get; set; }
        public DbSet<PetBreed> PetBreeds { get; set; }
        public DbSet<PetPost> PetPosts { get; set; }
        public DbSet<PetsInformation> PetsInformations { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
