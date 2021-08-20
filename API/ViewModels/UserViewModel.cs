using System.ComponentModel.DataAnnotations;

namespace API.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Name is required!")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        public string Email { get; set; }
        
        public string Phone { get; set; }
        public string Address { get; set; }  
    }
}