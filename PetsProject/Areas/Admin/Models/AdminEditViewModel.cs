using System.ComponentModel.DataAnnotations;

namespace PetsProject.Areas.Admin.Models
{
    public class AdminEditViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }   
    }
}
