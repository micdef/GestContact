using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GestContact.Infrastructure.Attributes;

namespace GestContact.Models.Auth
{
    public class RegisterForm
    {
        [Required]
        [MaxLength(50)]
        [DisplayName("Prénom : ")]
        public string Fname { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Nom de famille : ")]
        public string Lname { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(384)]
        [EmailExists(ErrorMessage = "Email already exists...")]
        [DisplayName("Email : ")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-=]).{8,50}$")]
        [DisplayName("Mot de passe : ")]
        public string Passwd { get; set; }

        [Compare(nameof(Passwd))]
        [DataType(DataType.Password)]
        [DisplayName("Répétez le mot de passe : ")]
        public string PasswdConfirm { get; set; }
    }
}