using Users.DTOs;

namespace Users.Repositories
{
    public interface IUserRepository
    {
        UserDTO? GetUserByEmail(string email);
        void Register(RegisterDTO model);
    }
}