using System.Linq;
using GestContact.Models.Global.Data;
using GestContact.Models.Global.Mappers;
using GestContact.Repositories;
using GestContact.ToolBox.ADO;

namespace GestContact.Models.Global.Services
{
    public class AuthService : IAuthService<User>
    {
        public User Login(string email, string pwd)
        {
            Command cmd = new Command("SP_User_Check", true);
            cmd.AddParameter("@email", email);
            cmd.AddParameter("@password", pwd);
            return ServiceLocator.Instance.Connection.ExecuteReader(cmd, r => r.ToUser()).SingleOrDefault();
        }

        public void Register(User user)
        {
            Command cmd = new Command("SP_User_Insert", true);
            cmd.AddParameter("@email", user.Email);
            cmd.AddParameter("@password", user.Password);
            cmd.AddParameter("@lastname", user.Lname);
            cmd.AddParameter("@firstname", user.Fname);
            ServiceLocator.Instance.Connection.ExecuteNonQuery(cmd);
            user.Password = null;
        }

        public bool EmailIsUsed(string email)
        {
            Command cmd = new Command("SELECT COUNT(*) FROM [V_Users] WHERE [email] = @email");
            cmd.AddParameter("@email", email);
            return 0 == (int)ServiceLocator.Instance.Connection.ExecuteScalar(cmd);
        }
    }
}
