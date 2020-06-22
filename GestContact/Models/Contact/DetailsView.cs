using System.ComponentModel;

namespace GestContact.Models.Contact
{
    public class DetailsView
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Prénom")]
        public string Fname { get; set; }

        [DisplayName("Nom")]
        public string Lname { get; set; }

        [DisplayName("Téléphone")]
        public string Tel { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
    }
}