using GestContact.Models.Client.Data;
using G = GestContact.Models.Global.Data;

namespace GestContact.Models.Client.Mappers
{
    internal static class Mappers
    {
        internal static G.User ToGlobal(this User entity)
        {
            return new G.User() { Id = entity.Id, Fname = entity.Fname, Lname = entity.Lname, Email = entity.Email, Password = entity.Pwd };
        }

        internal static User ToClient(this G.User entity)
        {
            return new User(entity.Id, entity.Fname, entity.Lname, entity.Email);
        }

        internal static G.Contact ToGlobal(this Contact entity)
        {
            return new G.Contact() { Id = entity.Id, Fname = entity.Fname, Lname = entity.Lname, Tel = entity.Tel, Email = entity.Email };
        }

        internal static Contact ToClient(this G.Contact entity)
        {
            return new Contact(entity.Id, entity.Fname, entity.Lname, entity.Tel, entity.Email);
        }
    }
}
