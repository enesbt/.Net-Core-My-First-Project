using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PetBreed
    {
        [Key]
        public int PetBreedId { get; set; }
        public string PetBreedName { get; set; }
        public bool Status{get;set;}
        public int PetTypeId { get; set; }
        public virtual PetType PetType { get; set; }
        public List<PetPost> PetPosts { get; set; }
    }
}
