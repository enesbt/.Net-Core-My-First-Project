using System.ComponentModel.DataAnnotations;

namespace PetsProject.Areas.Admin.Models
{
    public class RoleViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
