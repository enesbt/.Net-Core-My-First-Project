﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Complain
    {
        [Key]
        public int ComplainId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public string Mail { get; set; }

        public bool Status { get; set; }

        public int PetPostId { get; set; }
        public virtual PetPost PetPost { get; set; }    
    }
}
