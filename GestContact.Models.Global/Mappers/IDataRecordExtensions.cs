using GestContact.Models.Global.Data;
using System.Data;

namespace GestContact.Models.Global.Mappers
{
    internal static class IDataRecordExtensions
    {
        internal static User ToUser(this IDataRecord dr)
        {
            return new User() { Id = (int)dr["id"], Fname = dr["fname"].ToString(), Lname = dr["lname"].ToString(), Email = dr["email"].ToString() };
        }

        internal static Contact ToContact(this IDataRecord dr)
        {
            return new Contact() { Id = (int)dr["id"], Fname = dr["fname"].ToString(), Lname = dr["lname"].ToString(), Tel = dr["tel"].ToString(), Email = dr["email"].ToString() };
        }
    }
}
