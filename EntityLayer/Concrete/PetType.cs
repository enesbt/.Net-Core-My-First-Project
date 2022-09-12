using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PetType
    {
        [Key]
        public int PetTypeId { get; set; }
        public string PetTypeName { get; set; }
        public bool Status { get; set; }
        public List<PetPost> PetPosts { get; set; }
        public List<PetBreed> PetBreeds { get; set; }
    }
}
