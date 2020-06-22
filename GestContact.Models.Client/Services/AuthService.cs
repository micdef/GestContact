using GestContact.Repositories;
using GestContact.Models.Client.Data;
using GestContact.Models.Client.Mappers;
using GS = GestContact.Models.Global.Services.ServiceLocator;

namespace GestContact.Models.Client.Services
{
    public class AuthService : IAuthService<User>
    {
        public User Login(string email, string pwd)
        {
            return GS.Instance.AuthService.Login(email, pwd)?.ToClient();
        }

        public void Register(User user)
        {
            GS.Instance.AuthService.Register(user.ToGlobal());
        }

        public bool EmailIsUsed(string email)
        {
            return GS.Instance.AuthService.EmailIsUsed(email);
        }
    }
}
