using GestContact.Models.Global.Data;
using GestContact.ToolBox.ADO;
using System.Collections.Generic;
using System.Linq;
using GestContact.Models.Global.Mappers;
using GestContact.Repositories;

namespace GestContact.Models.Global.Services
{
    public class ContactService : IContactService<Contact>
    {
        public void Delete(int contactId)
        {
            Command cmd = new Command("SP_Contact_Delete", true);
            cmd.AddParameter("@id", contactId);
            ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd);
        }

        public Contact Get(int contactId)
        {
            Command cmd = new Command("SELECT * FROM [V_Contacts] WHERE [id] = @id");
            cmd.AddParameter("@id", contactId);
            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, c => c.ToContact()).FirstOrDefault();
        }

        public IEnumerable<Contact> GetAll(int userId)
        {
            Command cmd = new Command("SELECT * FROM [V_Contacts] WHERE [iduser] = @iduser");
            cmd.AddParameter("@iduser", userId);
            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, c => c.ToContact());
        }

        public void Insert(int idUser, Contact contact)
        {
            Command cmd = new Command("SP_Contact_Insert", true);
            cmd.AddParameter("@iduser", idUser);
            cmd.AddParameter("@fname", contact.Fname);
            cmd.AddParameter("@lname", contact.Lname);
            cmd.AddParameter("@tel", contact.Tel);
            cmd.AddParameter("@email", contact.Email);
            ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd);
        }

        public void Update(Contact contact)
        {
            Command cmd = new Command("SP_Contact_Update", true);
            cmd.AddParameter("@id", contact.Id);
            cmd.AddParameter("@fname", contact.Fname);
            cmd.AddParameter("@lname", contact.Lname);
            cmd.AddParameter("@tel", contact.Tel);
            cmd.AddParameter("@email", contact.Email);
            ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd);
        }
    }
}
