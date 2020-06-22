using System.ComponentModel;

namespace GestContact.Models.Contact
{
    public class ListingView
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Prénom")]
        public string Fname { get; set; }

        [DisplayName("Nom")]
        public string Lname { get; set; }
    }
}