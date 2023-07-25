using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User is required.")]
        public string Usuario { get; set; }

        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "Length of chars {0} going to be  {2} minium.", MinimumLength = 8)]
        public string PasswordHash { get; set; }
    }
}
