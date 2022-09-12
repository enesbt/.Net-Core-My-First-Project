using System.ComponentModel.DataAnnotations;

namespace PetsProject.Areas.Admin.Models
{
    public class RoleUpdateViewModel
    {
        [Required]
        public string id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
