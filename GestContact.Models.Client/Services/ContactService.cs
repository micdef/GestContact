using GestContact.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestContact.Models.Client.Data;
using GS = GestContact.Models.Global.Services.ServiceLocator;
using G = GestContact.Models.Global.Data;
using GestContact.Models.Client.Mappers;

namespace GestContact.Models.Client.Services
{
    public class ContactService : IContactService<Contact>
    {
        public void Delete(int contactId)
        {
            GS.Instance.ContactService.Delete(contactId);
        }

        public Contact Get(int contactId)
        {
            return GS.Instance.ContactService.Get(contactId).ToClient();
        }

        public IEnumerable<Contact> GetAll(int userId)
        {
            List<Contact> contactList = new List<Contact>();
            foreach (G.Contact contact in GS.Instance.ContactService.GetAll(userId))
                contactList.Add(contact.ToClient());
            return contactList;
        }

        public void Insert(int idUser, Contact contact)
        {
            GS.Instance.ContactService.Insert(idUser, contact.ToGlobal());
        }

        public void Update(Contact contact)
        {
            GS.Instance.ContactService.Update(contact.ToGlobal());
        }
    }
}
