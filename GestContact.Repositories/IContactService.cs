using System.Collections.Generic;

namespace GestContact.Repositories
{
    public interface IContactService<TContact>
    {
        void Insert(int idUser, TContact contact);
        void Update(TContact contact);
        void Delete(int contactId);
        IEnumerable<TContact> GetAll(int userId);
        TContact Get(int contactId);
    }
}
