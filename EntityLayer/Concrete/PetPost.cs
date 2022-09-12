using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PetPost
    {
        [Key]
        public int PetPostId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public  DateTime PostTime { get; set; }
        public string ImageUrl { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int PetTypeId { get; set; }
        public virtual PetType PetType { get; set; }
        public int PetAgeId { get; set; }
        public virtual PetAge PetAge { get; set; }

        public int PetBreedId { get; set; }
        public virtual PetBreed PetBreed { get; set; }
        public List<Complain> Complains { get; set; }
        public List<ContactMe> ContactMes { get; set; }
        public bool Status { get; set; }
    }
}
