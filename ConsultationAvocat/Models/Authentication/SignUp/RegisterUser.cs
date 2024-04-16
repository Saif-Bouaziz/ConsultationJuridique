using System.ComponentModel.DataAnnotations;

namespace ConsultationAvocat.Models.Authentication.SignUp
{
    public class RegisterUser
    {
      

        [Required(ErrorMessage = "UserName is required ")]
        public string? userName { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Email is required ")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Password is required ")]
        public string? Password { get; set; }

    }
}
