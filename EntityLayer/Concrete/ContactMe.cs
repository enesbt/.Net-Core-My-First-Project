using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactMe
    {
        [Key]
        public int ContactMeId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
        public int PetPostId { get; set; }
        public virtual PetPost PetPost { get; set; }

    }
}
