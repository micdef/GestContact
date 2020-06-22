using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestContact.Models.Auth
{
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        [MaxLength(384)]
        [DisplayName("Email : ")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-=]).{8,50}$")]
        [DisplayName("Mot de passe : ")]
        public string Pwd { get; set; }
    }
}