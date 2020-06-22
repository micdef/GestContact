using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestContact.Models.Contact
{
    public class CreateForm
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
        [MaxLength(20)]
        [DisplayName("Téléphone : ")]
        public string Tel { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(384)]
        [DisplayName("Email : ")]
        public string Email { get; set; }
    }
}