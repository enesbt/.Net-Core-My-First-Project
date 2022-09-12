using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PetAge
    {
        [Key]
        public int PetAgeId { get; set; }
        public string Age { get; set; }
        public bool Status { get; set; }
      
        public List<PetPost> PetPosts { get; set; }
    }
}
