using Users.DTOs;

namespace Users.Services
{
    public interface IUserService
    {
        string Login(LoginDTO user);
        void Register(RegisterDTO model);
    }
}