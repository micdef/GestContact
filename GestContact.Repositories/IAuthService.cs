namespace GestContact.Repositories
{
    public interface IAuthService<TUser>
    {
        void Register(TUser user);
        TUser Login(string email, string pwd);
        bool EmailIsUsed(string email);
    }
}
