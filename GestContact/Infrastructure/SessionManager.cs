using System.Web;
using GestContact.Models.Client.Data;

namespace GestContact.Infrastructure
{
    public class SessionManager
    {
        public static User User
        {
            get { return (User)HttpContext.Current.Session[nameof(User)]; }
            set { HttpContext.Current.Session[nameof(User)] = value; }
        }

        public static void Abandon()
        {
            if (SessionManager.User != null)
                HttpContext.Current.Session.Abandon();
        }
    }
}